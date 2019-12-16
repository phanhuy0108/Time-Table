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
    public partial class signin : Form
    {
        subjectManagerment Business;
        public signin()
        {
            Business = new subjectManagerment();
            InitializeComponent();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSignIn.Click += btnSignIn_Click;
        }

        void btnSignIn_Click(object sender, EventArgs e)
        {
            if (Business.IsValidLogin(txtAcc.Text, txtPass.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                indexTimeTable QLMH = new indexTimeTable(txtAcc.Text);
                QLMH.ShowDialog();
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
            

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
