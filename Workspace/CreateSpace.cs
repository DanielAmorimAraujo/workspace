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
        private OpenFileDialog addFileDialog = new OpenFileDialog();
        private FolderBrowserDialog addFolderDialog= new FolderBrowserDialog();
        private List<string> files = new List<string>();
        private List<string> folders = new List<string>();

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
                files.Add(addFileDialog.FileName);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (addFolderDialog.ShowDialog() == DialogResult.OK)
            {
                folders.Add(addFolderDialog.SelectedPath);
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {

        }
    }
}
