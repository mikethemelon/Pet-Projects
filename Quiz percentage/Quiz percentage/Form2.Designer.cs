
namespace Quiz_percentage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.btnd = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.tenq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(169, 365);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 33);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(88, 58);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(12, 17);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = ".";
            // 
            // btnd
            // 
            this.btnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnd.Location = new System.Drawing.Point(109, 287);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(198, 49);
            this.btnd.TabIndex = 9;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            // 
            // btnc
            // 
            this.btnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnc.Location = new System.Drawing.Point(109, 226);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(198, 55);
            this.btnc.TabIndex = 8;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            // 
            // btnb
            // 
            this.btnb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnb.Location = new System.Drawing.Point(109, 167);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(198, 53);
            this.btnb.TabIndex = 7;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            // 
            // btna
            // 
            this.btna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btna.Location = new System.Drawing.Point(109, 102);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(198, 59);
            this.btna.TabIndex = 6;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            // 
            // tenq
            // 
            this.tenq.Location = new System.Drawing.Point(12, 438);
            this.tenq.Name = "tenq";
            this.tenq.Size = new System.Drawing.Size(392, 23);
            this.tenq.TabIndex = 11;
            this.tenq.Text = "10 Questions";
            this.tenq.UseVisualStyleBackColor = true;
            this.tenq.Click += new System.EventHandler(this.tenq_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 474);
            this.Controls.Add(this.tenq);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button tenq;
    }
}