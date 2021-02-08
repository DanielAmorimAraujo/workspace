// <copyright file="Program.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Entry point of the program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!Directory.Exists(Constants.LocalDataDirectory))
            {
                Directory.CreateDirectory(Constants.LocalDataDirectory);
            }

            if (!System.IO.File.Exists(Constants.LocalDataPath))
            {
                FileStream fileStream = System.IO.File.Create(Constants.LocalDataPath);
                fileStream.Dispose();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreateSpace());
        }
    }
}