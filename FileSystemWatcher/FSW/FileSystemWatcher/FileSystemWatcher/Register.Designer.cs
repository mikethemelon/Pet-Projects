
namespace FileSystemWatcher
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label5 = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.TextBox();
            this.tpasshash = new System.Windows.Forms.TextBox();
            this.bexit = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.bgen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cshow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(61, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            // 
            // temail
            // 
            this.temail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temail.Location = new System.Drawing.Point(198, 158);
            this.temail.Margin = new System.Windows.Forms.Padding(4);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(431, 22);
            this.temail.TabIndex = 24;
            // 
            // tpasshash
            // 
            this.tpasshash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpasshash.Location = new System.Drawing.Point(710, 27);
            this.tpasshash.Margin = new System.Windows.Forms.Padding(4);
            this.tpasshash.Multiline = true;
            this.tpasshash.Name = "tpasshash";
            this.tpasshash.ReadOnly = true;
            this.tpasshash.Size = new System.Drawing.Size(307, 242);
            this.tpasshash.TabIndex = 23;
            // 
            // bexit
            // 
            this.bexit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bexit.Location = new System.Drawing.Point(525, 220);
            this.bexit.Margin = new System.Windows.Forms.Padding(4);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(105, 50);
            this.bexit.TabIndex = 22;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bsave
            // 
            this.bsave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bsave.Location = new System.Drawing.Point(400, 220);
            this.bsave.Margin = new System.Windows.Forms.Padding(4);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(105, 50);
            this.bsave.TabIndex = 21;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bgen
            // 
            this.bgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bgen.Location = new System.Drawing.Point(198, 220);
            this.bgen.Margin = new System.Windows.Forms.Padding(4);
            this.bgen.Name = "bgen";
            this.bgen.Size = new System.Drawing.Size(177, 50);
            this.bgen.TabIndex = 20;
            this.bgen.Text = "Generate";
            this.bgen.UseVisualStyleBackColor = true;
            this.bgen.Click += new System.EventHandler(this.bgen_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(60, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 65);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đăng ký username và password";
            // 
            // cshow
            // 
            this.cshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cshow.AutoSize = true;
            this.cshow.Location = new System.Drawing.Point(638, 130);
            this.cshow.Margin = new System.Windows.Forms.Padding(4);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(64, 21);
            this.cshow.TabIndex = 18;
            this.cshow.Text = "Show";
            this.cshow.UseVisualStyleBackColor = true;
            this.cshow.CheckedChanged += new System.EventHandler(this.cshow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // tpass
            // 
            this.tpass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpass.Location = new System.Drawing.Point(198, 126);
            this.tpass.Margin = new System.Windows.Forms.Padding(4);
            this.tpass.Name = "tpass";
            this.tpass.PasswordChar = '*';
            this.tpass.Size = new System.Drawing.Size(431, 22);
            this.tpass.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // tuser
            // 
            this.tuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tuser.Location = new System.Drawing.Point(198, 94);
            this.tuser.Margin = new System.Windows.Forms.Padding(4);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(431, 22);
            this.tuser.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.tpasshash);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.bgen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cshow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tpasshash;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bgen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tuser;
    }
}