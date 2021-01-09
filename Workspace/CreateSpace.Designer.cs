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
            this.btnFile = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenLink = new System.Windows.Forms.Button();
            this.btnOpenItem = new System.Windows.Forms.Button();
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
            this.txtLink.Location = new System.Drawing.Point(330, 12);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(258, 20);
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
            // CreateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
    }
}

