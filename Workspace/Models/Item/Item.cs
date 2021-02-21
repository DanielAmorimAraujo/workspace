// <copyright file="Item.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace.Models
{
    /// <summary>
    /// Abstract class for any <see cref="ItemType"/>.
    /// </summary>
    public abstract class Item
    {
        private static int counter = 0;

        /// <summary>
        /// Type of <see cref="Item"/>.
        /// </summary>
        public enum ItemType
        {
            /// <summary>
            /// A file.
            /// </summary>
            File,

            /// <summary>
            /// A folder.
            /// </summary>
            Folder,

            /// <summary>
            /// A link.
            /// </summary>
            Link,
        }

        /// <summary>
        /// Gets id.
        /// </summary>
        public abstract int Id { get; }

        /// <summary>
        /// Gets type.
        /// </summary>
        public abstract ItemType Type { get; }

        /// <summary>
        /// Gets a new ID.
        /// </summary>
        /// <returns>The ID.</returns>
        public static int GetId()
        {
            return ++counter;
        }

        /// <summary>
        /// Runs the <see cref="Item"/>.
        /// </summary>
        public abstract void Run();
    }
}