using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Workspace
{
    public partial class CreateSpace : Form
    {
        private Space space = new Space();
        private OpenFileDialog addFileDialog = new OpenFileDialog();
        private FolderBrowserDialog addFolderDialog = new FolderBrowserDialog();
        private static string localDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Workspace");
        private static string localDataFile = Path.Combine(localDataDir, "data.json");

        public CreateSpace()
        {
            InitializeComponent();

            if (!Directory.Exists(localDataDir))
            {
                Directory.CreateDirectory(localDataDir);
            }

            if (File.Exists(localDataFile))
            {
                space = JsonConvert.DeserializeObject<Space>(File.ReadAllText(localDataFile), new JsonSerializerSettings
                {
                    Error = (se, ev) => ev.ErrorContext.Handled = true
                }) ?? space;
            }
        }

        private void CreateSpace_Load(object sender, EventArgs e)
        {
            listViewItems.SmallImageList = imageListItems;
            listViewItems.LargeImageList = imageListItems;

            imageListItems.Images.Add(IconExtractor.Extract("shell32.dll", 4, true));

            FileStream blankFile = File.Create(Path.Combine(localDataDir, "blank.html"));
            imageListItems.Images.Add(Icon.ExtractAssociatedIcon(Path.Combine(localDataDir, "blank.html")));
            blankFile.Close();
            File.Delete(Path.Combine(localDataDir, "blank.html"));

            listViewItems.BeginUpdate();

            foreach (string file in space.Files)
            {
                imageListItems.Images.Add(Path.GetFileName(file), Icon.ExtractAssociatedIcon(file));
                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                item.Name = file;
                item.ImageKey = Path.GetFileName(file);
                item.Group = listViewItems.Groups[0];
                listViewItems.Items.Add(item);
            }

            foreach (string folder in space.Folders)
            {
                ListViewItem item = new ListViewItem(folder);
                item.ImageIndex = 0;
                item.Group = listViewItems.Groups[1];
                listViewItems.Items.Add(item);
            }

            foreach (string link in space.Links)
            {
                ListViewItem item = new ListViewItem(link);
                item.ImageIndex = 1;
                item.Group = listViewItems.Groups[2];
                listViewItems.Items.Add(item);
            }

            listViewItems.Columns[0].Width = -1;

            listViewItems.EndUpdate();

            listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string file = addFileDialog.FileName;

            space.AddFile(file);

            listViewItems.BeginUpdate();

            imageListItems.Images.Add(Path.GetFileName(file), Icon.ExtractAssociatedIcon(file));
            ListViewItem item = new ListViewItem(Path.GetFileName(file));
            item.ImageKey = Path.GetFileName(file);
            item.Group = listViewItems.Groups[0];
            listViewItems.Items.Add(item);

            listViewItems.Columns[0].Width = -1;

            listViewItems.EndUpdate();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (addFolderDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string folder = addFolderDialog.SelectedPath;

            space.AddFolder(folder);

            listViewItems.BeginUpdate();

            ListViewItem item = new ListViewItem(folder);
            item.ImageIndex = 0;
            item.Group = listViewItems.Groups[1];
            listViewItems.Items.Add(item);

            listViewItems.Columns[0].Width = -1;

            listViewItems.EndUpdate();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            string link = txtLink.Text;

            Uri uri;
            if (Uri.TryCreate(link, UriKind.Absolute, out uri) && uri.IsWellFormedOriginalString())
            {
                space.AddLink(link);

                listViewItems.BeginUpdate();

                ListViewItem item = new ListViewItem(link);
                item.ImageIndex = 1;
                item.Group = listViewItems.Groups[2];
                listViewItems.Items.Add(item);

                listViewItems.Columns[0].Width = -1;

                listViewItems.EndUpdate();

                errorProviderLink.Clear();

                txtLink.Clear();
            }
            else
            {
                errorProviderLink.SetError(txtLink, "Invalid URL");
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(localDataFile, JsonConvert.SerializeObject(space, Formatting.Indented));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listViewItems.BeginUpdate();

            foreach (ListViewItem item in listViewItems.SelectedItems)
            {
                if (item.Group.Name == "listViewGroupFile")
                {
                    space.RemoveFile(item.Name);

                }
                else if (item.Group.Name == "listViewGroupFolder")
                {
                    space.RemoveFolder(item.Text);
                }
                else if (item.Group.Name == "listViewGroupLink")
                {
                    space.RemoveLink(item.Text);
                }
                listViewItems.Items.Remove(item);
            }

            listViewItems.EndUpdate();
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0 && btnRemove.Enabled)
            {
                btnRemove.Enabled = false;
            }
            else if (listViewItems.SelectedItems.Count != 0 && !btnRemove.Enabled)
            {
                btnRemove.Enabled = true;
            }
        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLink.Text) && btnLink.Enabled)
            {
                btnLink.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(txtLink.Text) && !btnLink.Enabled)
            {
                btnLink.Enabled = true;
            }
        }

    }
}
