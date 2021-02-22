namespace Workspace.Forms
{
    partial class SpaceForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListItems = new System.Windows.Forms.ImageList(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.contextMenuStripAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitButtonAdd = new wyDay.Controls.SplitButton();
            this.splitButtonOpen = new wyDay.Controls.SplitButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(542, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // listViewItems
            // 
            this.listViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(12, 12);
            this.listViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(630, 312);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // imageListItems
            // 
            this.imageListItems.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListItems.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListItems.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(118, 329);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 25);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // contextMenuStripAdd
            // 
            this.contextMenuStripAdd.Name = "contextMenuStripAdd";
            this.contextMenuStripAdd.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStripOpen
            // 
            this.contextMenuStripOpen.Name = "contextMenuStripOpen";
            this.contextMenuStripOpen.Size = new System.Drawing.Size(61, 4);
            // 
            // splitButtonAdd
            // 
            this.splitButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.splitButtonAdd.AutoSize = true;
            this.splitButtonAdd.ContextMenuStrip = this.contextMenuStripAdd;
            this.splitButtonAdd.Location = new System.Drawing.Point(12, 329);
            this.splitButtonAdd.Name = "splitButtonAdd";
            this.splitButtonAdd.Size = new System.Drawing.Size(100, 25);
            this.splitButtonAdd.SplitMenuStrip = this.contextMenuStripAdd;
            this.splitButtonAdd.TabIndex = 1;
            this.splitButtonAdd.Text = "Add";
            this.splitButtonAdd.UseVisualStyleBackColor = true;
            // 
            // splitButtonOpen
            // 
            this.splitButtonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.splitButtonOpen.AutoSize = true;
            this.splitButtonOpen.ContextMenuStrip = this.contextMenuStripOpen;
            this.splitButtonOpen.Location = new System.Drawing.Point(224, 329);
            this.splitButtonOpen.Name = "splitButtonOpen";
            this.splitButtonOpen.Size = new System.Drawing.Size(100, 25);
            this.splitButtonOpen.SplitMenuStrip = this.contextMenuStripOpen;
            this.splitButtonOpen.TabIndex = 3;
            this.splitButtonOpen.Text = "Open All";
            this.splitButtonOpen.UseVisualStyleBackColor = true;
            this.splitButtonOpen.Click += new System.EventHandler(this.SplitButtonOpen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(436, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 366);
            this.Controls.Add(this.splitButtonAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.splitButtonOpen);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listViewItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(564, 200);
            this.Name = "SpaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ImageList imageListItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOpen;
        private wyDay.Controls.SplitButton splitButtonOpen;
        private wyDay.Controls.SplitButton splitButtonAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}

