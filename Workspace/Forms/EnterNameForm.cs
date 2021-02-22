// <copyright file="EnterNameForm.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace.Forms
{
    using System;
    using System.Windows.Forms;
    using Workspace.Models;

    /// <summary>
    /// Form to name a new <see cref="Space"/>.
    /// </summary>
    public partial class EnterNameForm : Form
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterNameForm"/> class.
        /// </summary>
        public EnterNameForm()
        {
            this.InitializeComponent();

            // event handlers
            this.txtBoxName.TextChanged += new EventHandler(this.TxtBoxName_TextChanged);
            this.txtBoxName.KeyDown += new KeyEventHandler(this.TxtBoxName_KeyDown);
        }

        /// <summary>
        /// Gets name entered in the form.
        /// </summary>
        public string ReturnName => this.name;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            this.name = this.txtBoxName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxName.Text))
            {
                this.btnEnter.Enabled = false;
            }
            else
            {
                this.btnEnter.Enabled = true;
            }
        }

        private void TxtBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.btnEnter.Enabled)
            {
                this.BtnEnter_Click(sender, e);
            }
        }
    }
}