namespace Workspace
{
    partial class CreateSpace
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Folders", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Links", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnFile = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenLink = new System.Windows.Forms.Button();
            this.btnOpenItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListItems = new System.Windows.Forms.ImageList(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.errorProviderLink = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLink)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 23);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Add File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(118, 12);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(100, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Add Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(224, 12);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(100, 23);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "Add Link";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(330, 14);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(138, 20);
            this.txtLink.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 331);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(100, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open Files";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOpenFolder.Location = new System.Drawing.Point(118, 331);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(100, 23);
            this.btnOpenFolder.TabIndex = 5;
            this.btnOpenFolder.Text = "Open Folders";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenLink
            // 
            this.btnOpenLink.Location = new System.Drawing.Point(224, 331);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Size = new System.Drawing.Size(100, 23);
            this.btnOpenLink.TabIndex = 6;
            this.btnOpenLink.Text = "Open Links";
            this.btnOpenLink.UseVisualStyleBackColor = true;
            this.btnOpenLink.Click += new System.EventHandler(this.btnOpenLink_Click);
            // 
            // btnOpenItem
            // 
            this.btnOpenItem.Location = new System.Drawing.Point(330, 331);
            this.btnOpenItem.Name = "btnOpenItem";
            this.btnOpenItem.Size = new System.Drawing.Size(100, 23);
            this.btnOpenItem.TabIndex = 7;
            this.btnOpenItem.Text = "Open All";
            this.btnOpenItem.UseVisualStyleBackColor = true;
            this.btnOpenItem.Click += new System.EventHandler(this.btnOpenItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(491, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            listViewGroup1.Header = "Files";
            listViewGroup1.Name = "listViewGroupFile";
            listViewGroup2.Header = "Folders";
            listViewGroup2.Name = "listViewGroupFolder";
            listViewGroup3.Header = "Links";
            listViewGroup3.Name = "listViewGroupLink";
            this.listViewItems.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listViewItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(12, 40);
            this.listViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(579, 286);
            this.listViewItems.TabIndex = 9;
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
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(491, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // errorProviderLink
            // 
            this.errorProviderLink.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLink.ContainerControl = this;
            // 
            // CreateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenItem);
            this.Controls.Add(this.btnOpenLink);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateSpace";
            this.Text = "Create a New Workspace";
            this.Load += new System.EventHandler(this.CreateSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenLink;
        private System.Windows.Forms.Button btnOpenItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ImageList imageListItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ErrorProvider errorProviderLink;
    }
}

