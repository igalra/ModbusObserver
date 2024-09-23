using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusObserverTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Settings.LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading settings. " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Run(new MainForm());
        }
    }
}
