using System;
using System.Windows.Forms;

namespace ModbusObserverTool
{
    public partial class Register : UserControl
    {
        public Register(int id)
        {
            InitializeComponent();
            Id = id;
            this.label1.Text = Id.ToString();
        }

        public int Id { get; }

        public void SetValue(int value) =>
            this.label3.Text = value.ToString();
    }
}
