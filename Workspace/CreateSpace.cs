using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workspace
{
    public partial class CreateSpace : Form
    {
        private Space space = new Space();
        private OpenFileDialog addFileDialog = new OpenFileDialog();
        private FolderBrowserDialog addFolderDialog= new FolderBrowserDialog();

        public CreateSpace()
        {
            InitializeComponent();
        }

        private void CreateSpace_Load(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog() == DialogResult.OK)
            {
                space.AddFile(addFileDialog.FileName);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (addFolderDialog.ShowDialog() == DialogResult.OK)
            {
                space.AddFolder(addFolderDialog.SelectedPath);
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            space.AddLink(txtLink.Text);
            txtLink.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            foreach (string file in space.Files)
            {
                Process process = new Process();
                process.StartInfo.FileName = file;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            foreach (string folder in space.Folders)
            {
                Process process = new Process();
                process.StartInfo.FileName = folder;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        private void btnOpenLink_Click(object sender, EventArgs e)
        {
            foreach (string link in space.Links)
            {
                Process process = new Process();
                process.StartInfo.FileName = link;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        private void btnOpenItem_Click(object sender, EventArgs e)
        {
            btnOpenFile_Click(sender, e);
            btnOpenFolder_Click(sender, e);
            btnOpenLink_Click(sender, e);
        }
    }
}
