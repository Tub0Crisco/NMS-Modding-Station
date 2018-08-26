using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace PSArcLib
{
    public class PSArc
    {
        //public const string PSARCPATH = path;

        public event ListCommandEventHandler ListCommandComplete;
        public event CreateCommandEventHandler CreateCommandComplete;
        public event ExtractCommandEventHandler ExtractCommandComplete;
        public event ProgressUpdateEventHandler ProgressUpdated;

        public StreamWriter Logger { get; set; }

        private int currentOpItemCount = 0;
        private int currentOpTotalItems = 0;

        public enum PSArcOption
        {
            Output,
            InputFile,
            Zlib,
            Lzma,
            Level,
            NoCompress,
            BlockSize,
            Jobs,
            Strip,
            StripAll,
            Absolute,
            Relative,
            IgnoreCase,
            Exclude,
            SkipMissingFiles,
            MergeDups,
            Input,
            To,
        }

        public void Create(string outputPath, string inputPath, params string[] inputFiles)
        {
            PSArcXmlFile xml = new PSArcXmlFile(PSArcXmlFile.XmlFileType.Create | PSArcXmlFile.XmlFileType.ByFile);
            xml.OutputFileName = outputPath;
            xml.InputDirectory = inputPath;
            foreach(string s in inputFiles)
            {
                xml.AddFileToPack(s);
            }
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
            logAndUpdate("Starting PSARC.", currentOpItemCount, currentOpTotalItems);
            string outputMsg = executeWithXml(writeXmlToFile(xml));
            CreateCommandComplete?.Invoke(new CreateCommandEventArgs(outputMsg));
            logAndUpdate("Done.", 0, 0);
        }

        public void Create(string outputPath, string inputDirectory)
        {
            PSArcXmlFile xml = new PSArcXmlFile(PSArcXmlFile.XmlFileType.Create | PSArcXmlFile.XmlFileType.ByFile);
            xml.OutputFileName = outputPath;
            xml.InputDirectory = inputDirectory;
            foreach(string s in getFiles(inputDirectory))
            {
                xml.AddFileToPack(s);
            }
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
            logAndUpdate("Starting PSARC.", currentOpItemCount, currentOpTotalItems);
            string outputMsg = executeWithXml(writeXmlToFile(xml));
            CreateCommandComplete?.Invoke(new CreateCommandEventArgs(outputMsg));
            logAndUpdate("Done.", 0, 0);
        }

        public void Extract(string inputFile, string outputDir)
        {
            PSArcXmlFile xml = new PSArcXmlFile(PSArcXmlFile.XmlFileType.Extract);
            xml.OutputFileName = outputDir;
            xml.AddPakToExtract(inputFile);
            Extract(xml);
        }

        public void Extract(string inputFile, string outputDir, params string[] archiveFiles)
        {
            PSArcXmlFile xml = new PSArcXmlFile(PSArcXmlFile.XmlFileType.Extract | PSArcXmlFile.XmlFileType.ByFile);
            xml.OutputFileName = outputDir;
            xml.AddPakToExtract(inputFile);
            foreach(string s in archiveFiles)
            {
                xml.AddFileToExtract(s);
            }
            Extract(xml);
        }

        public void Extract(PSArcXmlFile xmlFile)
        {
            Extract(writeXmlToFile(xmlFile));
        }

        public void Extract(string xmlFile)
        {
            string output = executeWithXml(xmlFile);
            ExtractCommandComplete?.Invoke(new ExtractCommandEventArgs(output));
            logAndUpdate("Done.", 0, 0);
        }

        public ICollection<string> List(string inputFile)
        {
            string outputMsg = executeCommandLine($"list \"{inputFile}\"");
            // parse output to get files.
            List<string> fileNames = new List<string>();
            string[] outputLines = outputMsg.Split('\n');
            // ignore the first line.
            for(int i = 1; i < outputLines.Length; i++)
            {
                if(outputLines[i].Length > 0)
                    fileNames.Add(outputLines[i].Substring(0, outputLines[i].IndexOf(' ')).Trim('\r'));
            }
            ListCommandComplete?.Invoke(new ListCommandEventArgs(outputMsg, fileNames));
            logAndUpdate("Done.", 0, 0);
            return fileNames;
        }

        //public void Dump()
        //{

        //}

        //public void Dtd()
        //{

        //}

        private string executeWithXml(string xmlFile)
        {
            string outputMsg = executeCommandLine($"--xml=\"{xmlFile}\"");
            File.Delete(xmlFile);
            return outputMsg;
        }

        private string executeCommandLine(string args)
        {
            string outputMsg = string.Empty;
            Process p = new Process();
            p.StartInfo = getProcessStartInfo(args);

            p.Start();
            //outputMsg = p.StandardOutput.ReadToEnd();
            //Console.WriteLine(outputMsg);
            p.WaitForExit();
            return outputMsg;
        }

        private string writeXmlToFile(PSArcXmlFile xmlFile)
        {
            string tempFilePath = Path.GetTempFileName();
            using (FileStream fs = File.Open(tempFilePath, FileMode.Create, FileAccess.ReadWrite))
            using (StreamWriter sr = new StreamWriter(fs))
            {
                sr.Write(xmlFile.ToString());
                sr.Flush();
            }
#if DEBUG
            Console.WriteLine(xmlFile.ToString());
#endif
            return tempFilePath;
        }

        private ProcessStartInfo getProcessStartInfo(string args = "")
        {
            var path = Path.GetTempFileName() + ".exe"; // Actually PSARC.EXE, but we just call it something random just cause.
            File.WriteAllBytes(path, NMSModdingStation.Properties.Resources.psarc);
            ProcessStartInfo psInfo = new ProcessStartInfo(path);
            psInfo.CreateNoWindow = true;
            //psInfo.RedirectStandardOutput = true;
            psInfo.UseShellExecute = false;
            psInfo.Arguments = args;
            psInfo.WorkingDirectory = Environment.CurrentDirectory;
            return psInfo;
        }

        private string[] getFiles(string path)
        {
            return Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        }

        private void logAndUpdate(string msg, int itemsComplete, int totalItems)
        {
            Logger?.Write($"[{DateTime.Now}] {msg}");
            ProgressUpdated?.Invoke(new ProgressUpdateEventArgs(msg, itemsComplete, totalItems));
        }
    }
}
