﻿namespace Workspace.Forms
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Form to enter in a <see cref="Link.Url"/>.
    /// </summary>
    public partial class EnterLink : Form
    {
        private string linkValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterLink"/> class.
        /// </summary>
        public EnterLink()
        {
            this.InitializeComponent();

            // event handlers
            this.txtBoxLink.TextChanged += new EventHandler(this.TxtBoxLink_TextChanged);
            this.txtBoxLink.KeyDown += new KeyEventHandler(this.TxtBoxLink_KeyDown);
        }

        /// <summary>
        /// Gets <see cref="returnValue"/>.
        /// </summary>
        public string LinkValue => this.linkValue;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (Uri.TryCreate(this.txtBoxLink.Text, UriKind.Absolute, out Uri uri) && uri.IsWellFormedOriginalString())
            {
                this.linkValue = this.txtBoxLink.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.errProviderLink.SetError(this.txtBoxLink, "Invalid URL");
            }
        }

        private void TxtBoxLink_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxLink.Text))
            {
                this.btnEnter.Enabled = false;
            }
            else
            {
                this.btnEnter.Enabled = true;
            }
        }

        private void TxtBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.BtnEnter_Click(sender, e);
            }
        }
    }
}