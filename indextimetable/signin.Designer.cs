namespace indextimetable
{
    partial class signin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtAcc);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblAcc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(148, 85);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(169, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(148, 38);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(169, 26);
            this.txtAcc.TabIndex = 0;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(46, 91);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(46, 39);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(75, 20);
            this.lblAcc.TabIndex = 0;
            this.lblAcc.Text = "Account";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(58, 179);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(86, 37);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.groupBox1);
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSignIn;
    }
}