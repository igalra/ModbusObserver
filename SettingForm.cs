using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModbusObserverTool
{
    public partial class SettingForm : Form
    {
        private bool formValidationFailed;
        private IDictionary<TextBox, Func<string, bool>> validationsDic;
        private BindingSource bindingSource = new BindingSource();

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.InitValidationsDic();
            this.LoadData();
        }

        private void InitValidationsDic()
        {
            this.validationsDic = new Dictionary<TextBox, Func<string, bool>>()
            {
                {this.textBoxIp, this.ValidateString },
                {this.textBoxPort, ValidateUshort },
                {this.textBoxSlaveId, ValidateUshort }
            };
        }

        private void LoadData()
        {
            this.textBoxIp.Text = Settings.Ip;
            this.textBoxPort.Text = Settings.Port.ToString();
            this.textBoxSlaveId.Text = Settings.SlaveId.ToString();
            this.numericUpDownStartId.Value = Settings.StartId;
            this.numericUpDownRange.Value = Settings.Range;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.ValidateInputs();
            if (formValidationFailed) return;

            this.SaveData();
            this.Close();
        }

        private void SaveData()
        {
            Settings.Ip = this.textBoxIp.Text;
            Settings.Port = int.Parse(this.textBoxPort.Text);
            Settings.SlaveId = Convert.ToByte(this.textBoxSlaveId.Text);
            Settings.StartId = (int)numericUpDownStartId.Value;
            Settings.Range = (byte)numericUpDownRange.Value;

            Settings.SaveData();
        }

        private bool ValidateInput(TextBox textBox)
        {
            var ok = this.validationsDic[textBox](textBox.Text);

            textBox.BackColor = ok ? Color.White : Color.Gold;
            if (!ok) this.formValidationFailed = true;

            return ok;
        }

        private void ValidateInputs()
        {
            formValidationFailed = false;

            foreach (var textBox in this.validationsDic.Keys)
            {
                this.ValidateInput(textBox);
            }

            if (formValidationFailed)
            {
                MessageBox.Show("Incorrect settings fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static bool ValidateUshort(string value) =>
            ushort.TryParse(value, out _);

        private bool ValidateString(string value) =>
            !string.IsNullOrWhiteSpace(value);

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var textBox = (TextBox)sender;

                this.ValidateInput(textBox);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
