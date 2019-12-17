using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace indextimetable
{
    public partial class indexTimeTable : Form
    {
        private readonly subjectManagerment Business;

        // The timer.
        readonly System.Threading.Timer TheTimer = null;

        public static DateTime? reminderDateTime = null;

        public indexTimeTable(string taikhoan)
        {
            Business = new subjectManagerment();
            InitializeComponent();
            this.Load += Form1_Load;
            this.dataGridView1.DoubleClick += DataGridView1_DoubleClick;
            this.tmAdd.Click += TmAdd_Click;
            this.tmDelete.Click += tmDelete_Click;
            this.tmSet.Click += TmSet_Click;
            this.timer1.Tick += Timer1_Tick;

            // Make the timer start now and tick every 500 ms.
            TheTimer = new System.Threading.Timer(this.Tick, null, 0, 1000);
        }

        void tmDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                {
                    var subject = (Table)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    this.Business.deleteStudent(subject.Id);
                    this.loadAllSubject();
                }
            }
        }


        
        public void Tick(object info)
        {
            while (!this.IsHandleCreated)
                System.Threading.Thread.Sleep(500);
            this.Invoke((Action)this.CheckReminderDate);
        }

        // Update the countdown on the UI thread.
        private void CheckReminderDate()
        {
            if(reminderDateTime < DateTime.Now)
            {
                MessageBox.Show("TIME TO STUDY NOW");
                reminderDateTime = null;
            }           
            Debug.WriteLine(DateTime.Now);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void TmSet_Click(object sender, EventArgs e)
        {
            var setTimeRemind = new setTimeRemind();
            setTimeRemind.ShowDialog();
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
                var updateForm = new updateStudentForm(subject.Id);
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
    }
}
