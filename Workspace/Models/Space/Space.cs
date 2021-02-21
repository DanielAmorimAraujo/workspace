// <copyright file="Space.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Manages a set of <see cref="Item"/>.
    /// </summary>
    public class Space
    {
        private static int counter = 0;
        private readonly int id;
        private readonly string name;
        private readonly List<File> files = new List<File>();
        private readonly List<Folder> folders = new List<Folder>();
        private readonly List<Link> links = new List<Link>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class.
        /// </summary>
        /// <param name="name">The name of the space.</param>
        [JsonConstructor]
        public Space(string name)
        {
            this.id = GetId();
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class.
        /// </summary>
        /// <param name="other">The space being copied.</param>
        public Space(Space other)
        {
            this.id = other.id;
            this.name = other.name;
            this.files = new List<File>(other.files);
            this.folders = new List<Folder>(other.folders);
            this.links = new List<Link>(other.links);
        }

        /// <summary>
        /// Gets <see cref="id"/>.
        /// </summary>
        public int Id => this.id;

        /// <summary>
        /// Gets <see cref="name"/>.
        /// </summary>
        public string Name => this.name;

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
        /// Gets a new ID.
        /// </summary>
        /// <returns>The ID.</returns>
        public static int GetId()
        {
            return ++counter;
        }

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

        /// <summary>
        /// Runs the items in the space.
        /// </summary>
        /// <param name="type">Specifies the <see cref="Item"/>. If omitted, all will run.</param>
        public void Run(Item.ItemType? type = null)
        {
            if (type.HasValue)
            {
                switch (type)
                {
                    case Item.ItemType.File:
                        foreach (File file in this.files)
                        {
                            file.Run();
                        }

                        break;

                    case Item.ItemType.Folder:
                        foreach (Folder folder in this.folders)
                        {
                            folder.Run();
                        }

                        break;

                    case Item.ItemType.Link:
                        foreach (Link link in this.links)
                        {
                            link.Run();
                        }

                        break;
                }
            }
            else
            {
                foreach (File file in this.files)
                {
                    file.Run();
                }

                foreach (Folder folder in this.folders)
                {
                    folder.Run();
                }

                foreach (Link link in this.links)
                {
                    link.Run();
                }
            }
        }
    }
}