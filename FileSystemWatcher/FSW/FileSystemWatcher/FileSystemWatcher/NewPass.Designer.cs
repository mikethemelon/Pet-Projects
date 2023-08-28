
namespace FileSystemWatcher
{
    partial class NewPass
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
            this.toldpass = new System.Windows.Forms.TextBox();
            this.tnewpass = new System.Windows.Forms.TextBox();
            this.tnewpass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bsave = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.tpasshash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toldpass
            // 
            this.toldpass.Location = new System.Drawing.Point(164, 80);
            this.toldpass.Name = "toldpass";
            this.toldpass.Size = new System.Drawing.Size(260, 20);
            this.toldpass.TabIndex = 0;
            // 
            // tnewpass
            // 
            this.tnewpass.Location = new System.Drawing.Point(164, 123);
            this.tnewpass.Name = "tnewpass";
            this.tnewpass.Size = new System.Drawing.Size(260, 20);
            this.tnewpass.TabIndex = 1;
            // 
            // tnewpass2
            // 
            this.tnewpass2.Location = new System.Drawing.Point(164, 161);
            this.tnewpass2.Name = "tnewpass2";
            this.tnewpass2.Size = new System.Drawing.Size(260, 20);
            this.tnewpass2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(249, 203);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(97, 23);
            this.bsave.TabIndex = 7;
            this.bsave.Text = "Đổi mật khẩu";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(352, 203);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(72, 23);
            this.bcancel.TabIndex = 8;
            this.bcancel.Text = "Hủy bỏ";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // tpasshash
            // 
            this.tpasshash.Location = new System.Drawing.Point(430, 80);
            this.tpasshash.Multiline = true;
            this.tpasshash.Name = "tpasshash";
            this.tpasshash.ReadOnly = true;
            this.tpasshash.Size = new System.Drawing.Size(206, 143);
            this.tpasshash.TabIndex = 25;
            // 
            // NewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 246);
            this.Controls.Add(this.tpasshash);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnewpass2);
            this.Controls.Add(this.tnewpass);
            this.Controls.Add(this.toldpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewPass";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toldpass;
        private System.Windows.Forms.TextBox tnewpass;
        private System.Windows.Forms.TextBox tnewpass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.TextBox tpasshash;
    }
}