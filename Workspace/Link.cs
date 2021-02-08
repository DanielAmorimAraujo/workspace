// <copyright file="Link.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace
{
    using System.Diagnostics;

    /// <summary>
    /// Represents a link item.
    /// </summary>
    internal class Link : Item
    {
        private readonly int id;
        private readonly string url;

        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class.
        /// </summary>
        /// <param name="url">The url.</param>
        public Link(string url)
        {
            this.id = this.GetId();
            this.url = url;
        }

        /// <inheritdoc/>
        public override int Id => this.id;

        /// <inheritdoc/>
        public override ItemType Type => ItemType.Link;

        /// <summary>
        /// Gets <see cref="url"/>.
        /// </summary>
        public string Url => this.url;

        /// <summary>
        /// Gets the title for <see cref="Link"/>.
        /// </summary>
        /// <param name="plural">If the title should be plural.</param>
        /// <param name="lowercase">If the title should be lowercase.</param>
        /// <returns>The title.</returns>
        public static string GetTitle(bool plural = false, bool lowercase = false)
        {
            string title = "Link";
            if (lowercase)
            {
                title.ToLower();
            }

            if (plural)
            {
                title += "s";
            }

            return title;
        }

        /// <inheritdoc/>
        public override void Run()
        {
            Process process = new Process();
            process.StartInfo.FileName = this.url;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }
    }
}