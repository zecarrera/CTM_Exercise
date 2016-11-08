﻿using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EnergyJourneyTests.Utils
{
    internal static class TestFolders
    {
        public static readonly string UniqueId = GetRawTimestamp();

        public static string InputFolder
        {
            get { return Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath); }
        }

        public static string OutputFolder
        {
            //a simple solution that puts everyting to the output folder directly would look like this:
            //get { return Directory.GetCurrentDirectory(); }
            get
            {
                var outputFolder = Path.Combine(Directory.GetCurrentDirectory(), UniqueId);
                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);
                return outputFolder;
            }
        }

        public static string TempFolder
        {
            get { return Path.GetTempPath(); }
        }

        // very simple helper methods that can improve the test code readability

        public static string GetInputFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(InputFolder, fileName));
        }

        public static string GetOutputFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(OutputFolder, fileName));
        }

        public static string GetTempFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(TempFolder, fileName));
        }

        /// <summary>
        /// Returns a raw timestamp value, that can be included in paths
        /// </summary>
        public static string GetRawTimestamp()
        {
            return DateTime.Now.ToString("s", CultureInfo.InvariantCulture).Replace(":", "");
        }

        /// <summary>
        /// Makes string path-compatible, ie removes characters not allowed in path and replaces whitespace with '_'
        /// </summary>
        public static string ToPath(string s)
        {
            var builder = new StringBuilder(s);
            foreach (var invalidChar in Path.GetInvalidFileNameChars())
            {
                builder.Replace(invalidChar.ToString(), "");
            }
            builder.Replace(' ', '_');
            return builder.ToString();
        }
    }
}