// <copyright file="File.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace
{
    using System.Diagnostics;

    /// <summary>
    /// Represents a file item.
    /// </summary>
    public class File : Item
    {
        private readonly int id;
        private readonly string name;
        private readonly string path;

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public File(string path)
        {
            this.id = GetId();
            this.name = System.IO.Path.GetFileName(path);
            this.path = path;
        }

        /// <inheritdoc/>
        public override int Id => this.id;

        /// <inheritdoc/>
        public override ItemType Type => ItemType.File;

        /// <summary>
        /// Gets <see cref="name"/>.
        /// </summary>
        public string Name => this.name;

        /// <summary>
        /// Gets <see cref="path"/>.
        /// </summary>
        public string Path => this.path;

        /// <summary>
        /// Gets the title for <see cref="File"/>.
        /// </summary>
        /// <param name="plural">If the title should be plural.</param>
        /// <param name="lowercase">If the title should be lowercase.</param>
        /// <returns>The title.</returns>
        public static string GetTitle(bool plural = false, bool lowercase = false)
        {
            string title = "File";
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
            process.StartInfo.FileName = this.path;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }
    }
}