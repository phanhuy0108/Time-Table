using System;
using System.Windows.Forms;

namespace indextimetable
{
    public partial class setTimeRemind : Form
    {     
        public setTimeRemind()
        {
            InitializeComponent();
            
            
            this.btnOk.Click += BtnOk_Click;
            this.btnClose.Click += BtnClose_Click;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(rbOn.Checked)
            {
                // on selected
                indexTimeTable.reminderDateTime = dateTimePicker1.Value;
            }
            this.Close();
        }

        private void rbOn_CheckedChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = rbOn.Checked;
        }
    }
}
