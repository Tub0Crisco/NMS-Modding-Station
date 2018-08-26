using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NMSModdingStation
{
    [SuppressMessage("ReSharper", "UseStringInterpolation")]
    public static class Functions
    {
        public static void Run(string arguments, string workingDirectory)
        {
            var path = Path.GetTempFileName() + ".exe"; // Actually PSARC.EXE, but we just call it something random just cause.
            File.WriteAllBytes(path, Properties.Resources.psarc);
            var procInfo = new ProcessStartInfo(path, arguments);
            procInfo.UseShellExecute = false;
            procInfo.CreateNoWindow = true;
            if (!string.IsNullOrEmpty(workingDirectory))
            {
                procInfo.WorkingDirectory = workingDirectory;
            }
            Process.Start(procInfo).WaitForExit();
        }

        public static void Extract(string pakFilePath, string outputPath)
        {
            var pakFile = new FileInfo(pakFilePath);
            if (pakFile.Exists)
            {
                var psarcArgs = string.Format("extract -y \"{0}\"", pakFile.FullName);
                if (!string.IsNullOrEmpty(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                    Run(psarcArgs, outputPath);
                }else
                {
                    Run(psarcArgs, pakFile.DirectoryName);
                }
            }
        }

        public static void Create(string dirPath, string pakName)
        {
            if (Directory.Exists(dirPath))
            {
                Create(GetFileList("*", dirPath).ToList(), pakName, Directory.GetParent(dirPath).FullName);
            }
        }

        public static void Create(IList<string> paths, string pakName, string rootPath = null)
        {
            if (paths.Any() && paths.All(path => File.Exists(path) || Directory.Exists(path)))
            {
                if (string.IsNullOrWhiteSpace(pakName))
                    pakName = "psarc";
                // If no rootPath provided, we assume first file is the top-most relative to other files.
                if (string.IsNullOrEmpty(rootPath) || !Directory.Exists(rootPath))
                {
                    var firstPath = paths.First();
                    if (File.Exists(firstPath))
                    {
                        rootPath = new FileInfo(firstPath).DirectoryName;
                    }
                    else if (Directory.Exists(firstPath))
                    {
                        rootPath = Directory.GetParent(firstPath).FullName;
                    }
                }

                var filePaths = paths.Where(File.Exists).ToList();

                foreach (var dirPath in paths.Where(Directory.Exists))
                {
                    filePaths.AddRange(GetFileList("*", dirPath));
                }

                if (!string.IsNullOrEmpty(rootPath) && Directory.Exists(rootPath))
                {
                    var tmpFilePath = Path.GetTempFileName();
                    using (var writer = new StreamWriter(tmpFilePath))
                    {
                        foreach (var filePath in filePaths)
                        {
                            // Needs to be relative paths??
                            var relPath = filePath;
                            //if (relPath.StartsWith(rootPath, StringComparison.OrdinalIgnoreCase))
                            //{
                            //    relPath = filePath.Remove(0, rootPath.Length);
                            //    if (relPath.StartsWith("\\"))
                            //    {
                            //        relPath = relPath.Substring(1);
                            //    }
                            //}
                            writer.WriteLine(relPath);
                        }
                    }
                    Console.WriteLine(rootPath + pakName);
                    Console.WriteLine(rootPath.Length + pakName.Length);
                    if (rootPath.Length + pakName.Length < 252)
                    {
                        Run(
                            string.Format("create -y -a --zlib --inputfile=\"{0}\" --output={1}", tmpFilePath, pakName + ".pak"),
                            rootPath);
                    }
                    else
                    {
                        MessageBox.Show("Path character count is too long!\n\nTry moving your project directory closer to your root directory.\n(example: C:\\NMSProjects) \n\nDecrease your path character count by " + ((rootPath.Length + pakName.Length) - 251) + " characters.", "Your path character count is too long!");
                    }
                }
            }
        }

        public static
            IEnumerable<string> GetFileList(string fileSearchPattern, string rootFolderPath)
        {
            var pending = new Queue<string>();
            pending.Enqueue(rootFolderPath);
            while (pending.Count > 0)
            {
                rootFolderPath = pending.Dequeue();
                var tmp = Directory.GetFiles(rootFolderPath, fileSearchPattern);
                foreach (var t in tmp)
                {
                    yield return t;
                }
                tmp = Directory.GetDirectories(rootFolderPath);
                foreach (var t in tmp)
                {
                    pending.Enqueue(t);
                }
            }
        }

    }
}
