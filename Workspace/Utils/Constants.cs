// <copyright file="Constants.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace.Utils
{
    using System;
    using System.IO;

    /// <summary>
    /// Stores constants used in this project.
    /// </summary>
    internal class Constants
    {
        /// <summary>
        /// Name of the program.
        /// </summary>
        public const string ProgramName = "Workspace";

        /// <summary>
        /// Name of the file that store the programs data.
        /// </summary>
        public const string LocalDataFile = "data.json";

        /// <summary>
        /// Name of the local directory.
        /// </summary>
        public static readonly string LocalDataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProgramName);

        /// <summary>
        /// Path of <see cref="LocalDataFile"/>.
        /// </summary>
        public static readonly string LocalDataPath = Path.Combine(LocalDataDirectory, LocalDataFile);
    }
}