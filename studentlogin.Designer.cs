namespace Asm2DB
{
    partial class studentlogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.txtaccount1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbforgotpass = new System.Windows.Forms.Label();
            this.lbregister = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(541, 203);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(108, 39);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "&Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(541, 250);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 39);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtpassword1
            // 
            this.txtpassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword1.Location = new System.Drawing.Point(227, 250);
            this.txtpassword1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.Size = new System.Drawing.Size(258, 39);
            this.txtpassword1.TabIndex = 2;
            // 
            // txtaccount1
            // 
            this.txtaccount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount1.Location = new System.Drawing.Point(227, 203);
            this.txtaccount1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtaccount1.Name = "txtaccount1";
            this.txtaccount1.Size = new System.Drawing.Size(258, 39);
            this.txtaccount1.TabIndex = 1;
            this.txtaccount1.TextChanged += new System.EventHandler(this.txtaccount1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student\'s login";
            // 
            // lbforgotpass
            // 
            this.lbforgotpass.AutoSize = true;
            this.lbforgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbforgotpass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbforgotpass.Location = new System.Drawing.Point(222, 305);
            this.lbforgotpass.Name = "lbforgotpass";
            this.lbforgotpass.Size = new System.Drawing.Size(168, 25);
            this.lbforgotpass.TabIndex = 5;
            this.lbforgotpass.Text = "Forgot password?";
            this.lbforgotpass.Click += new System.EventHandler(this.lbforgotpass_Click);
            // 
            // lbregister
            // 
            this.lbregister.AutoSize = true;
            this.lbregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbregister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbregister.Location = new System.Drawing.Point(667, 385);
            this.lbregister.Name = "lbregister";
            this.lbregister.Size = new System.Drawing.Size(83, 25);
            this.lbregister.TabIndex = 6;
            this.lbregister.Text = "Register";
            this.lbregister.Click += new System.EventHandler(this.lbregister_Click);
            // 
            // studentlogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(762, 419);
            this.Controls.Add(this.lbregister);
            this.Controls.Add(this.lbforgotpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtpassword1);
            this.Controls.Add(this.txtaccount1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "studentlogin";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.studentlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.TextBox txtaccount1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbforgotpass;
        private System.Windows.Forms.Label lbregister;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}