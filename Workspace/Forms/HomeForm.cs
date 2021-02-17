// <copyright file="HomeForm.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Newtonsoft.Json;

    /// <summary>
    /// Form for viewing saved <see cref="Space"/>s.
    /// </summary>
    public partial class HomeForm : Form
    {
        private readonly List<Space> spaces = new List<Space>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeForm"/> class.
        /// </summary>
        public HomeForm()
        {
            this.InitializeComponent();

            // load saved data
            this.spaces = JsonConvert.DeserializeObject<List<Space>>(System.IO.File.ReadAllText(Constants.LocalDataPath), new JsonSerializerSettings { Error = (se, ev) => ev.ErrorContext.Handled = true, }) ?? this.spaces;

            foreach (Space space in this.spaces)
            {
                this.AddListViewSpace(space);
            }

            // event handlers
            this.listViewSpaces.SelectedIndexChanged += new EventHandler(this.ListViewSpaces_SelectedIndexChanged);
        }

        /// <inheritdoc/>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(Constants.LocalDataPath, JsonConvert.SerializeObject(this.spaces, Formatting.Indented));
            base.OnFormClosing(e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Space space = (Space)this.listViewSpaces.SelectedItems[0].Tag;
            using (CreateSpace createSpaceForm = new CreateSpace(new Space(space)))
            {
                createSpaceForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = createSpaceForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.spaces[this.spaces.FindIndex(ind => ind.Equals(space))] = createSpaceForm.ReturnSpace;
                    this.listViewSpaces.SelectedItems[0].Tag = createSpaceForm.ReturnSpace;
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult confirmRemove = MessageBox.Show("Are you sure you want to remove this space?", "Remove Space", MessageBoxButtons.YesNo);
            if (confirmRemove == DialogResult.Yes)
            {
                this.spaces.Remove((Space)this.listViewSpaces.SelectedItems[0].Tag);
                this.RemoveListViewSpace(this.listViewSpaces.SelectedItems[0]);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
        }

        private void AddListViewSpace(Space space)
        {
            this.listViewSpaces.BeginUpdate();

            ListViewItem listViewItem = new ListViewItem(space.Name)
            {
                Name = space.Name,
                Tag = space,
            };
            this.listViewSpaces.Items.Add(listViewItem);

            this.listViewSpaces.Columns[0].Width = -1;

            this.listViewSpaces.EndUpdate();
        }

        private void RemoveListViewSpace(ListViewItem listViewItem)
        {
            this.listViewSpaces.BeginUpdate();

            this.listViewSpaces.Items.Remove(listViewItem);
            this.listViewSpaces.Columns[0].Width = -1;

            this.listViewSpaces.EndUpdate();
        }

        private void ListViewSpaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = this.btnRemove.Enabled = this.listViewSpaces.SelectedItems.Count > 0;
        }
    }
}