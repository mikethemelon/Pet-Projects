using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcher
{
    public partial class FileSystemMonitor : Form
    {
        //
        private string content = "";
        private string last_event_filename = "";
        public FileSystemMonitor()
        {
            InitializeComponent();
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            if (folderB.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderB.SelectedPath;
                fileMon.Path = txtFolderPath.Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            fileMon.EnableRaisingEvents = false;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //Allow admin to see all the child files inside a folder
        private void chkRecursive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecursive.Checked == true)
            {
                fileMon.IncludeSubdirectories = true;
            }
            else
                fileMon.IncludeSubdirectories = false;
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "File System Monitor đang chạy... " + Environment.NewLine;
            fileMon.Path = txtFolderPath.Text;
            fileMon.EnableRaisingEvents = true;
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolderPath.Text))
                chkRecursive.Enabled = false;
            else
                chkRecursive.Enabled = true;
        }

        private void fileMon_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (chkModified.CheckState == CheckState.Checked && last_event_filename != e.FullPath)
            {
                content = "Cảnh báo: " + e.FullPath + " vừa được sửa đổi!" + Environment.NewLine;
                txtDisplay.AppendText(content);
            }
            last_event_filename = e.FullPath;
        }

        private void fileMon_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            if (chkCreated.CheckState == CheckState.Checked)
            {
                content = "Cảnh báo: " + e.FullPath + " vừa được tạo!" + Environment.NewLine ;
                txtDisplay.AppendText(content);
            }
            last_event_filename = e.FullPath;
        }

        private void fileMon_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            if (chkDeleted.CheckState == CheckState.Checked)
            {
                content = "Cảnh báo: " + e.FullPath + " vừa bị xóa!" + Environment.NewLine;
                txtDisplay.AppendText(content);
            }
            last_event_filename = e.FullPath;
        }

        private void fileMon_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            if (chkRenamed.CheckState == CheckState.Checked)
            {
                content = "Cảnh báo: Thư mục - " + e.OldFullPath + "  vừa đổi tên thành: " + e.FullPath + Environment.NewLine;
                txtDisplay.AppendText(content);
            }
            last_event_filename = e.FullPath;
        }

        
    }
}
