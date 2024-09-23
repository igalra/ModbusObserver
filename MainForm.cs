using System;
using System.Linq;
using System.Windows.Forms;

namespace ModbusObserverTool
{
    public partial class MainForm : Form
    {
        private MainControlPanel mainControlPanel;

        public MainForm()
        {
            InitializeComponent();

            this.mainControlPanel = new MainControlPanel() { Dock = DockStyle.Fill };
            this.panelMain.Controls.Add(this.mainControlPanel);

            this.FormClosing += MainForm_FormClosing;
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainControlPanel.Stop();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SettingForm())
                form.ShowDialog();
        }
    }
}
