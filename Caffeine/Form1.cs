using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Caffeine
{
    public partial class Form1 : Form
    {
        bool bTimeOutEnabled = false;
        DateTime expiredDateTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtFeq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtFeq_Leave(object sender, EventArgs e)
        {
            freqTimer.Interval = Convert.ToInt32(txtFreq.Text);
        }

        private void cmdToTray_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.nifMin.Visible = true;
        }

        private void nifMin_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.nifMin.Visible = false;
        }

        private void freqTimer_Tick(object sender, EventArgs e)
        {
            InputSimulator sim = new InputSimulator();
            WindowsInput.KeyboardSimulator simk = new KeyboardSimulator(sim);
            //simk.KeyPress(VirtualKeyCode.VK_X);
            simk.KeyPress(VirtualKeyCode.F15);

            if (cbTimeOutEnable.Checked)
            {
                if (DateTime.Now > expiredDateTime)
                {
                    freqTimer.Enabled = false;
                    cbTimeOutEnable.Checked = false;
                    cbEnabled.Checked = false;
                }
            }
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.freqTimer.Enabled = this.cbEnabled.Checked;
        }

        private void cbTimeOutEnable_CheckedChanged(object sender, EventArgs e)
        {
            bTimeOutEnabled = true;
            expiredDateTime = DateTime.Now.AddMinutes(Convert.ToInt32(txtTimeOut.Text));
        }

        private void txtTimeOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
