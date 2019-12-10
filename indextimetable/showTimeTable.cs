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
    public partial class showTimeTable : Form
    {
        private const int ALARM_OFF = 0;
        private const int ALARM_ON = 1;
        public showTimeTable()
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private bool m_Set = false;
        public bool AlarmSet
        {
            get { return m_Set; }
            set { m_Set = value; }
        }
        private DateTime m_TimeSet = DateTime.Now;
        public DateTime TimeSet
        {
            get { return m_TimeSet; }
            set { m_TimeSet = value; }
        }
    }
}
