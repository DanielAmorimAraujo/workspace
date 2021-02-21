// <copyright file="IconExtractor.cs" company="github.com/DanielAmorimAraujo">
// Copyright (c) github.com/DanielAmorimAraujo. All rights reserved.
// </copyright>

namespace Workspace.Utils
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Extracts icons from files.
    /// </summary>
    public class IconExtractor
    {
        /// <summary>
        /// Extracts icons from files.
        /// </summary>
        /// <param name="file">Name of file to be extracted.</param>
        /// <param name="number">Index of icon.</param>
        /// <param name="largeIcon">If a large icon should be extracted.</param>
        /// <returns>The icon. </returns>
        public static Icon Extract(string file, int number, bool largeIcon)
        {
            ExtractIconEx(file, number, out IntPtr large, out IntPtr small, 1);
            try
            {
                return Icon.FromHandle(largeIcon ? large : small);
            }
            catch
            {
                return null;
            }
        }

        [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern int ExtractIconEx(string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons);
    }
}