using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
