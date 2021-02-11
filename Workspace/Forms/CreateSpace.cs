// <copyright file="CreateSpace.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Newtonsoft.Json;

    /// <summary>
    /// Form for creating and editing a new <see cref="Space"/>.
    /// </summary>
    public partial class CreateSpace : Form
    {
        private readonly Space space = new Space();
        private readonly OpenFileDialog fileDialog = new OpenFileDialog();
        private readonly FolderBrowserDialog folderDialog = new FolderBrowserDialog();
        private readonly int folderImageIndex;
        private readonly int linkImageIndex;
        private readonly ListViewGroup fileGroup = new ListViewGroup(File.GetTitle(true));
        private readonly ListViewGroup folderGroup = new ListViewGroup(Folder.GetTitle(true));
        private readonly ListViewGroup linkGroup = new ListViewGroup(Link.GetTitle(true));

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpace"/> class.
        /// </summary>
        public CreateSpace()
        {
            this.InitializeComponent();

            // building form
            this.splitButtonAdd.DropDown = true;

            this.contextMenuStripAdd.Items.Add(new ToolStripMenuItem("Add " + File.GetTitle(), null, this.FileToolStripMenuItemAdd_Click));
            this.contextMenuStripAdd.Items.Add(new ToolStripMenuItem("Add " + Folder.GetTitle(), null, this.FolderToolStripMenuItemAdd_Click));
            this.contextMenuStripAdd.Items.Add(new ToolStripMenuItem("Add " + Link.GetTitle(), null, this.LinkToolStripMenuItemAdd_Click));

            this.contextMenuStripOpen.Items.Add(new ToolStripMenuItem("Open " + File.GetTitle(), null, this.FileToolStripMenuItemOpen_Click));
            this.contextMenuStripOpen.Items.Add(new ToolStripMenuItem("Open " + Folder.GetTitle(), null, this.FolderToolStripMenuItemOpen_Click));
            this.contextMenuStripOpen.Items.Add(new ToolStripMenuItem("Open " + Link.GetTitle(), null, this.LinkToolStripMenuItemOpen_Click));

            this.listViewItems.Groups.AddRange(new ListViewGroup[] { this.fileGroup, this.folderGroup, this.linkGroup });
            this.listViewItems.SmallImageList = this.imageListItems;
            this.listViewItems.LargeImageList = this.imageListItems;

            this.imageListItems.Images.Add(IconExtractor.Extract("shell32.dll", 4, true));
            this.folderImageIndex = 0;

            string blankFileName = Path.Combine(Constants.LocalDataDirectory, "blank.html");
            FileStream blankFile = System.IO.File.Create(blankFileName);
            this.imageListItems.Images.Add(Icon.ExtractAssociatedIcon(blankFileName));
            this.linkImageIndex = 1;
            blankFile.Close();
            System.IO.File.Delete(blankFileName);

            // loading saved data
            this.space = JsonConvert.DeserializeObject<Space>(System.IO.File.ReadAllText(Constants.LocalDataPath), new JsonSerializerSettings { Error = (se, ev) => ev.ErrorContext.Handled = true, }) ?? this.space;

            foreach (File file in this.space.Files)
            {
                this.AddListViewItem(file);
            }

            foreach (Folder folder in this.space.Folders)
            {
                this.AddListViewItem(folder);
            }

            foreach (Link link in this.space.Links)
            {
                this.AddListViewItem(link);
            }

            // event handlers
            this.listViewItems.SelectedIndexChanged += new EventHandler(this.ListViewItems_SelectedIndexChanged);
            this.txtLink.KeyDown += new KeyEventHandler(this.TxtLink_KeyDown);
        }

        private void CreateSpace_Load(object sender, EventArgs e)
        {
        }

        private void FileToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            if (this.fileDialog.ShowDialog() == DialogResult.OK)
            {
                File file = new File(this.fileDialog.FileName);
                this.space.AddItem(file);
                this.AddListViewItem(file);
            }
        }

        private void FolderToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            if (this.folderDialog.ShowDialog() == DialogResult.OK)
            {
                Folder folder = new Folder(this.folderDialog.SelectedPath);
                this.space.AddItem(folder);
                this.AddListViewItem(folder);
            }
        }

        private void LinkToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            if (Uri.TryCreate(this.txtLink.Text, UriKind.Absolute, out Uri uri) && uri.IsWellFormedOriginalString())
            {
                Link link = new Link(this.txtLink.Text);
                this.space.AddItem(link);
                this.AddListViewItem(link);

                this.errorProviderLink.Clear();
                this.txtLink.Clear();
            }
            else
            {
                this.errorProviderLink.SetError(this.txtLink, "Invalid URL");
            }
        }

        private void FileToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            foreach (File file in this.space.Files)
            {
                file.Run();
            }
        }

        private void FolderToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            foreach (Folder folder in this.space.Folders)
            {
                folder.Run();
            }
        }

        private void LinkToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            foreach (Link link in this.space.Links)
            {
                link.Run();
            }
        }

        private void SplitButtonOpen_Click(object sender, EventArgs e)
        {
            this.FileToolStripMenuItemOpen_Click(sender, e);
            this.FolderToolStripMenuItemOpen_Click(sender, e);
            this.LinkToolStripMenuItemOpen_Click(sender, e);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.listViewItems.SelectedItems)
            {
                this.RemoveListViewItem(listViewItem);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Constants.LocalDataPath, JsonConvert.SerializeObject(this.space, Formatting.Indented));
        }

        private void AddListViewItem(Item item)
        {
            this.listViewItems.BeginUpdate();

            switch (item.Type)
            {
                case Item.ItemType.File:
                    {
                        File file = (File)item;
                        this.imageListItems.Images.Add(file.Name, Icon.ExtractAssociatedIcon(file.Path));
                        ListViewItem listViewItem = new ListViewItem(file.Name)
                        {
                            Name = file.Path,
                            ImageKey = file.Name,
                            Group = this.fileGroup,
                            Tag = file,
                        };
                        this.listViewItems.Items.Add(listViewItem);
                    }

                    break;

                case Item.ItemType.Folder:
                    {
                        Folder folder = (Folder)item;
                        ListViewItem listViewItem = new ListViewItem(folder.Path)
                        {
                            ImageIndex = this.folderImageIndex,
                            Group = this.folderGroup,
                            Tag = folder,
                        };
                        this.listViewItems.Items.Add(listViewItem);
                    }

                    break;

                case Item.ItemType.Link:
                    {
                        Link link = (Link)item;
                        ListViewItem listViewItem = new ListViewItem(link.Url)
                        {
                            ImageIndex = this.linkImageIndex,
                            Group = this.linkGroup,
                            Tag = link,
                        };
                        this.listViewItems.Items.Add(listViewItem);
                    }

                    break;
            }

            this.listViewItems.Columns[0].Width = -1;

            this.listViewItems.EndUpdate();
        }

        private void RemoveListViewItem(ListViewItem listViewItem)
        {
            this.listViewItems.BeginUpdate();

            switch (((Item)listViewItem.Tag).Type)
            {
                case Item.ItemType.File:
                    this.space.RemoveItem((File)listViewItem.Tag);
                    break;

                case Item.ItemType.Folder:
                    this.space.RemoveItem((Folder)listViewItem.Tag);
                    break;

                case Item.ItemType.Link:
                    this.space.RemoveItem((Link)listViewItem.Tag);
                    break;
            }

            this.listViewItems.Items.Remove(listViewItem);

            this.listViewItems.Columns[0].Width = -1;

            this.listViewItems.EndUpdate();
        }

        private void ListViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnRemove.Enabled = this.listViewItems.SelectedItems.Count > 0;
        }

        private void TxtLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.LinkToolStripMenuItemAdd_Click(sender, e);
            }
        }
    }
}