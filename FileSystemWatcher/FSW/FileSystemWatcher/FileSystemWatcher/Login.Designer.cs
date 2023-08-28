
namespace FileSystemWatcher
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bexit = new System.Windows.Forms.Button();
            this.blogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cshow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tuser = new System.Windows.Forms.TextBox();
            this.tpasshash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bexit.Location = new System.Drawing.Point(484, 230);
            this.bexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(105, 50);
            this.bexit.TabIndex = 32;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // blogin
            // 
            this.blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.blogin.Location = new System.Drawing.Point(359, 230);
            this.blogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(105, 50);
            this.blogin.TabIndex = 31;
            this.blogin.Text = "Login";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(352, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 65);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đăng nhập";
            // 
            // cshow
            // 
            this.cshow.AutoSize = true;
            this.cshow.Location = new System.Drawing.Point(157, 203);
            this.cshow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(64, 21);
            this.cshow.TabIndex = 29;
            this.cshow.Text = "Show";
            this.cshow.UseVisualStyleBackColor = true;
            this.cshow.CheckedChanged += new System.EventHandler(this.cshow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password";
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(157, 171);
            this.tpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpass.Name = "tpass";
            this.tpass.PasswordChar = '*';
            this.tpass.Size = new System.Drawing.Size(431, 22);
            this.tpass.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "Username";
            // 
            // tuser
            // 
            this.tuser.Location = new System.Drawing.Point(157, 105);
            this.tuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(431, 22);
            this.tuser.TabIndex = 25;
            this.tuser.TextChanged += new System.EventHandler(this.tuser_TextChanged);
            // 
            // tpasshash
            // 
            this.tpasshash.Location = new System.Drawing.Point(597, 102);
            this.tpasshash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpasshash.Multiline = true;
            this.tpasshash.Name = "tpasshash";
            this.tpasshash.ReadOnly = true;
            this.tpasshash.Size = new System.Drawing.Size(255, 178);
            this.tpasshash.TabIndex = 33;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 290);
            this.Controls.Add(this.tpasshash);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cshow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.TextBox tpasshash;
    }
}