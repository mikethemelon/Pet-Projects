
namespace FileSystemWatcher
{
    partial class FileSystemMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSystemMonitor));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.chkCreated = new System.Windows.Forms.CheckBox();
            this.chkModified = new System.Windows.Forms.CheckBox();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.chkRenamed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.fileMon = new System.IO.FileSystemWatcher();
            this.folderB = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileMon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(1166, 388);
            this.txtDisplay.TabIndex = 0;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.Location = new System.Drawing.Point(209, 422);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(916, 20);
            this.txtFolderPath.TabIndex = 1;
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btnPickFolder.Location = new System.Drawing.Point(1131, 420);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Size = new System.Drawing.Size(47, 23);
            this.btnPickFolder.TabIndex = 2;
            this.btnPickFolder.Text = "Tìm";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // chkRecursive
            // 
            this.chkRecursive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.BackColor = System.Drawing.Color.Transparent;
            this.chkRecursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecursive.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRecursive.Location = new System.Drawing.Point(982, 508);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(91, 22);
            this.chkRecursive.TabIndex = 3;
            this.chkRecursive.Text = "Nâng cao";
            this.chkRecursive.UseVisualStyleBackColor = false;
            this.chkRecursive.CheckedChanged += new System.EventHandler(this.chkRecursive_CheckedChanged);
            // 
            // chkCreated
            // 
            this.chkCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCreated.AutoSize = true;
            this.chkCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreated.ForeColor = System.Drawing.SystemColors.Control;
            this.chkCreated.Location = new System.Drawing.Point(209, 454);
            this.chkCreated.Name = "chkCreated";
            this.chkCreated.Size = new System.Drawing.Size(110, 22);
            this.chkCreated.TabIndex = 4;
            this.chkCreated.Text = "Tạo thư mục";
            this.chkCreated.UseVisualStyleBackColor = true;
            // 
            // chkModified
            // 
            this.chkModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkModified.AutoSize = true;
            this.chkModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModified.ForeColor = System.Drawing.SystemColors.Control;
            this.chkModified.Location = new System.Drawing.Point(325, 454);
            this.chkModified.Name = "chkModified";
            this.chkModified.Size = new System.Drawing.Size(131, 22);
            this.chkModified.TabIndex = 5;
            this.chkModified.Text = "Đổi tên thư mục";
            this.chkModified.UseVisualStyleBackColor = true;
            // 
            // chkDeleted
            // 
            this.chkDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleted.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDeleted.Location = new System.Drawing.Point(462, 454);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(111, 22);
            this.chkDeleted.TabIndex = 6;
            this.chkDeleted.Text = "Xóa thư mục";
            this.chkDeleted.UseVisualStyleBackColor = true;
            // 
            // chkRenamed
            // 
            this.chkRenamed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRenamed.AutoSize = true;
            this.chkRenamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRenamed.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRenamed.Location = new System.Drawing.Point(579, 454);
            this.chkRenamed.Name = "chkRenamed";
            this.chkRenamed.Size = new System.Drawing.Size(131, 22);
            this.chkRenamed.TabIndex = 7;
            this.chkRenamed.Text = "Đổi tên thư mục";
            this.chkRenamed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn thư mục để Monitor:";
            // 
            // btnMonitor
            // 
            this.btnMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btnMonitor.Location = new System.Drawing.Point(1079, 449);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(99, 23);
            this.btnMonitor.TabIndex = 9;
            this.btnMonitor.Text = "Bắt đầu";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btnClear.Location = new System.Drawing.Point(1079, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btnClose.Location = new System.Drawing.Point(1079, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fileMon
            // 
            this.fileMon.EnableRaisingEvents = true;
            this.fileMon.SynchronizingObject = this;
            this.fileMon.Changed += new System.IO.FileSystemEventHandler(this.fileMon_Changed);
            this.fileMon.Created += new System.IO.FileSystemEventHandler(this.fileMon_Created);
            this.fileMon.Deleted += new System.IO.FileSystemEventHandler(this.fileMon_Deleted);
            this.fileMon.Renamed += new System.IO.RenamedEventHandler(this.fileMon_Renamed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(166, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lọc:";
            // 
            // FileSystemMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1190, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRenamed);
            this.Controls.Add(this.chkDeleted);
            this.Controls.Add(this.chkModified);
            this.Controls.Add(this.chkCreated);
            this.Controls.Add(this.chkRecursive);
            this.Controls.Add(this.btnPickFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.txtDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileSystemMonitor";
            this.Text = "File System Watcher (IDS)";
            ((System.ComponentModel.ISupportInitialize)(this.fileMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.CheckBox chkCreated;
        private System.Windows.Forms.CheckBox chkModified;
        private System.Windows.Forms.CheckBox chkDeleted;
        private System.Windows.Forms.CheckBox chkRenamed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.IO.FileSystemWatcher fileMon;
        private System.Windows.Forms.FolderBrowserDialog folderB;
        private System.Windows.Forms.Label label2;
    }
}

