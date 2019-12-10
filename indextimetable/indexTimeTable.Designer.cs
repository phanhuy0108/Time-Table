namespace indextimetable
{
    partial class indexTimeTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tmSet = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTIMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(928, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 283);
            this.panel1.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(328, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 24);
            this.label.TabIndex = 6;
            this.label.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmAdd,
            this.tmSet,
            this.sETTIMEToolStripMenuItem,
            this.tmCancel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(928, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmAdd
            // 
            this.tmAdd.Name = "tmAdd";
            this.tmAdd.Size = new System.Drawing.Size(43, 19);
            this.tmAdd.Text = "ADD";
            // 
            // tmSet
            // 
            this.tmSet.Name = "tmSet";
            this.tmSet.Size = new System.Drawing.Size(84, 19);
            this.tmSet.Text = "SET REMIND";
            // 
            // sETTIMEToolStripMenuItem
            // 
            this.sETTIMEToolStripMenuItem.Name = "sETTIMEToolStripMenuItem";
            this.sETTIMEToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.sETTIMEToolStripMenuItem.Text = "SET TIME";
            // 
            // tmCancel
            // 
            this.tmCancel.Name = "tmCancel";
            this.tmCancel.Size = new System.Drawing.Size(54, 19);
            this.tmCancel.Text = "CLOSE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // indexTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 407);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "indexTimeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIME TABLE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmAdd;
        private System.Windows.Forms.ToolStripMenuItem tmSet;
        private System.Windows.Forms.ToolStripMenuItem tmCancel;
        private System.Windows.Forms.ToolStripMenuItem sETTIMEToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
    }
}

