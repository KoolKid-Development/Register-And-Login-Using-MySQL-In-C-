namespace RegisterAndLoginUsingMySQL
{
    partial class Form2
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
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.btregister = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassword1
            // 
            this.txtpassword1.Location = new System.Drawing.Point(12, 64);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.Size = new System.Drawing.Size(100, 20);
            this.txtpassword1.TabIndex = 6;
            this.txtpassword1.UseSystemPasswordChar = true;
            // 
            // btregister
            // 
            this.btregister.Location = new System.Drawing.Point(26, 116);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(75, 23);
            this.btregister.TabIndex = 5;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = true;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(12, 38);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(12, 12);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 7;
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(12, 90);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(100, 20);
            this.txtpassword2.TabIndex = 8;
            this.txtpassword2.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(26, 139);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 174);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword1);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.txtemail);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Button btnlogin;
    }
}