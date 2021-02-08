// <copyright file="Space.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace
{
    using System.Collections.Generic;

    /// <summary>
    /// Manages a set of <see cref="Item"/>.
    /// </summary>
    internal class Space
    {
        private readonly List<File> files = new List<File>();
        private readonly List<Folder> folders = new List<Folder>();
        private readonly List<Link> links = new List<Link>();

        /// <summary>
        /// Gets <see cref="files"/>.
        /// </summary>
        public List<File> Files => this.files;

        /// <summary>
        /// Gets <see cref="folders"/>.
        /// </summary>
        public List<Folder> Folders => this.folders;

        /// <summary>
        /// Gets <see cref="links"/>.
        /// </summary>
        public List<Link> Links => this.links;

        /// <summary>
        /// Adds an <see cref="Item"/> to our <see cref="Space"/>.
        /// </summary>
        /// <param name="item">The <see cref="Item"/> being added.</param>
        public void AddItem(Item item)
        {
            switch (item.Type)
            {
                case Item.ItemType.File:
                    this.files.Add((File)item);
                    break;

                case Item.ItemType.Folder:
                    this.folders.Add((Folder)item);
                    break;

                case Item.ItemType.Link:
                    this.links.Add((Link)item);
                    break;
            }
        }

        /// <summary>
        /// Removes an <see cref="Item"/> from our <see cref="Space"/>.
        /// </summary>
        /// <param name="item">The <see cref="Item"/> being removed.</param>
        public void RemoveItem(Item item)
        {
            switch (item.Type)
            {
                case Item.ItemType.File:
                    this.files.Remove((File)item);
                    break;

                case Item.ItemType.Folder:
                    this.folders.Remove((Folder)item);
                    break;

                case Item.ItemType.Link:
                    this.links.Remove((Link)item);
                    break;
            }
        }
    }
}