using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "All Files|*.*",
                Title = "Select Files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    FilesListBox.Items.Add(filePath);
                }
            }
        }

        private void RemovePrefixButton_Click(object sender, EventArgs e)
        {
            string prefixToRemove = PrefixTextBox.Text.Trim();

            if (string.IsNullOrEmpty(prefixToRemove))
            {
                MessageBox.Show("Please enter a prefix to remove.");
                return;
            }

            foreach (object item in FilesListBox.Items)
            {
                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string newFileName = fileName.StartsWith(prefixToRemove) ? fileName.Substring(prefixToRemove.Length) : fileName;
                string newFilePath = Path.Combine(directory, newFileName);

                if (File.Exists(newFilePath))
                {
                    MessageBox.Show($"A file with the name '{newFileName}' already exists in the directory.");
                    return;
                }

                File.Move(filePath, newFilePath);
            }

            MessageBox.Show($"Prefix '{prefixToRemove}' removed from file names successfully.");
        }

      
    }
}
