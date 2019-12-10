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
    public partial class indexTimeTable : Form
    {
        private subjectManagerment Business;
        public indexTimeTable()
        {
            Business = new subjectManagerment();
            InitializeComponent();
            this.Load += Form1_Load;
            this.dataGridView1.DoubleClick += DataGridView1_DoubleClick;
            this.tmAdd.Click += TmAdd_Click;
            this.tmCancel.Click += TmCancel_Click;
            this.tmSet.Click += TmSet_Click;
            this.timer1.Tick += Timer1_Tick;
            
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToLongTimeString();

        }

        private void TmSet_Click(object sender, EventArgs e)
        {
            var setTimeRemind = new setTimeRemind();
            setTimeRemind.ShowDialog();
        }

        private void TmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TmAdd_Click(object sender, EventArgs e)
        {
            var createSubjectForm = new createSubjectForm();
            createSubjectForm.ShowDialog();
            this.loadAllSubject();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var subject = (Table)this.dataGridView1.SelectedRows[0].DataBoundItem;
                var updateForm = new updateStudentForm(subject.ID);
                updateForm.ShowDialog();
                this.loadAllSubject();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadAllSubject();
        }
        private void loadAllSubject()
        {
            var subject = this.Business.getSubject();
            this.dataGridView1.DataSource = subject;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
