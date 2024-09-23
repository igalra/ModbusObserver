using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ModbusObserverTool
{
    public partial class MainControlPanel : UserControl
    {
        private System.Threading.Timer timer;

        private ModbusClient modbusClient;
        private bool isStopped;

        public MainControlPanel()
        {
            InitializeComponent();

            this.modbusClient = new ModbusClient(Settings.Ip, Settings.Port,5000);
            this.modbusClient.Disconnected += ModbusClient_Disconnected;

            this.timer = new System.Threading.Timer(new TimerCallback(this.TimerCallback));
        }

        private void ModbusClient_Disconnected()
        {
            this.Invoke(() =>
            {
                isStopped = true;
                this.buttonStart.Enabled = true;
                this.buttonStop.Enabled = false;
                SetIsConnected(false);
            });
        }

        private void SetMessage(string text)
        {
            this.Invoke(() => this.labelMessage.Text = text);
        }

        private void SetIsConnected(bool connected, string message = null)
        {
            this.Invoke(() =>
            {
                if (connected)
                {
                    this.labelRunning.Text = message ?? "Running";
                    this.labelRunning.ForeColor = Color.Lime;
                }
                else
                {
                    this.labelRunning.Text = message ?? "Not Connected";
                    this.labelRunning.ForeColor = Color.Red;
                }
            });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (Settings.StartId == 0 || Settings.Range == 0)
            {
                SetMessage("Please set up at least one register");
                return;
            }

            SetMessage("");
            this.flowLayoutPanelMain.Controls.Clear();

            this.flowLayoutPanelMain.Controls.AddRange(Enumerable.Range(Settings.StartId, Settings.Range).Select(n => new Register(n)).ToArray());

            this.Stop();

            this.labelRunning.Text = "Connecting...";
            this.labelRunning.ForeColor = Color.DodgerBlue;

            Application.DoEvents();

            try
            {
                this.modbusClient.IpAddress = Settings.Ip;
                this.modbusClient.Port = Settings.Port;
                this.modbusClient.Connect();
                this.SetIsConnected(true);
                isStopped = false;
            }
            catch(Exception ex)
            {
                SetIsConnected(false, "Connection Error");
                SetMessage(ex.Message);
                return;
            }

            this.timer.Change(500, Timeout.Infinite);
            this.buttonStart.Enabled = false;
            this.buttonStop.Enabled = true;
        }

        public void Stop()
        {
            isStopped = true;
            this.timer.Change(Timeout.Infinite, Timeout.Infinite);
            this.modbusClient.Disconnect();

            SetIsConnected(false);

            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;
            SetMessage("");
        }

        private async void TimerCallback(object sender)
        {
            try
            {
                var results = await this.modbusClient.ReadHoldingRegistersSafeAsync(Settings.SlaveId, (ushort)Settings.StartId, Settings.Range);

                this.Invoke(async () =>
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        var register = flowLayoutPanelMain.Controls.OfType<Register>().FirstOrDefault(x => x.Id == Settings.StartId + i);
                        register?.SetValue(results.ElementAt(i));
                    }
                    await ReadRegister(textBoxReg1, labelReg1);
                    await ReadRegister(textBoxReg2, labelReg2);
                    SetMessage("Reading registes success");
                });
            }
            catch (Exception ex)
            {
                SetMessage($"Error while reading. Error message: {ex.InnerException?.Message ?? ex.Message}");
            }
            finally
            {
                if (!isStopped)
                    timer.Change(1000, Timeout.Infinite);
            }
        }

        private async Task ReadRegister(TextBox textBox, Label label)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                return;
            try
            {
                var i = ushort.Parse(textBox.Text);
                var results = await this.modbusClient.ReadHoldingRegistersSafeAsync(Settings.SlaveId, i, 1);
                label.Text = results.First().ToString();
            }
            catch (Exception e)
            {
                label.Text = "-";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void buttonStartDebug_EnabledChanged(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = button.Enabled ? Color.White : Color.Gray;
        }

        private async void buttonWrite1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxReg1.Text) || string.IsNullOrWhiteSpace(this.textBoxWrite1.Text) || !this.isStopped)
                return;
            try
            {
                await this.modbusClient.WriteSingleRegisterAsync(Settings.SlaveId, ushort.Parse(this.textBoxReg1.Text), ushort.Parse(this.textBoxWrite1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void buttonWrite2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxReg2.Text) || string.IsNullOrWhiteSpace(this.textBoxWrite2.Text) || !this.isStopped)
                return;
            try
            {
                await this.modbusClient.WriteSingleRegisterAsync(Settings.SlaveId, ushort.Parse(this.textBoxReg2.Text), ushort.Parse(this.textBoxWrite2.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Invoke(Action action)
        {
            this.Invoke(new MethodInvoker(() => action()));
        }
    }
}
