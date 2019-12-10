using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indextimetable
{
    public partial class setTimeRemind : Form
    {
        private showTimeTable show = null;

       

        public setTimeRemind()
        {
            InitializeComponent();
            
            this.rbOn.Checked = rbOn.AlarmSet;
            this.rbOff.Checked = showtable.AlarmSet;
            this.dateTimePicker1.Text = showtable.TimeSet.ToShortTimeString();
            this.btnOk.Click += BtnOk_Click;
            this.btnClose.Click += BtnClose_Click;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            show.AlarmSet = rbOn.Checked;

            if (rbOn.Checked)
            {
                try
                {
                    show.TimeSet = DateTime.Parse(this.dateTimePicker1.Text);
                }
                catch (Exception ex)
                {
                    show.TimeSet = DateTime.Now;
                }
            }
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
