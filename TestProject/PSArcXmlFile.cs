using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PSArcLib
{
    public class PSArcXmlFile
    {
        [Flags]
        public enum XmlFileType
        {
            None = 1,
            Create = 2,
            Extract = 4,
            ByFile = 8,
            ByFileList = 16,
            ByDirectory = 32,
            MultiFile = 64
        }

        private List<string> paksToExtract;
        private List<string> filesToExtract;
        private List<string> filesToPack;
        private XmlFileType fileType;
        private string outputFileName;
        private string inputDirectory;

        public string OutputDirectory
        {
            get
            {
                return Path.GetDirectoryName(OutputFileName);
            }
        }

        public string OutputFileName
        {
            get
            {
                return outputFileName;
            }
            set
            {
                outputFileName = Path.GetFullPath(value);
            }
        }

        public string InputDirectory
        {
            get
            {
                return inputDirectory;
            }
            set
            {
                inputDirectory = Path.GetFullPath(value);
            }
        }

        public PSArcXmlFile(XmlFileType type)
        {
            fileType = type;
            paksToExtract = new List<string>();
            filesToExtract = new List<string>();
            filesToPack = new List<string>();
            OutputFileName = "DefaultOut";
        }

        public void AddPakToExtract(string fileName)
        {
            paksToExtract.Add(Path.GetFullPath(fileName));
        }

        public void AddFileToExtract(string fileName)
        {
            filesToExtract.Add(Path.GetFullPath(fileName));
        }

        public void AddFileToPack(string fileName)
        {
            filesToPack.Add(Path.GetFullPath(fileName));
        }

        private void writeExtractBlock(XmlTextWriter writer)
        {
            foreach(string s in paksToExtract)
            {
                writer.WriteStartElement("extract");
                writer.WriteAttributeString("archive", s);
                writer.WriteAttributeString("to", OutputFileName);
                if(fileType.HasFlag(XmlFileType.ByFile))
                {
                    foreach(string f in filesToExtract)
                    {
                        writer.WriteStartElement("file");
                        writer.WriteAttributeString("archivepath", f);
                        writer.WriteAttributeString("skipifmissing", "true");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
            }
        }

        private void writeCreateBlock(XmlTextWriter writer)
        {
            if (OutputFileName == string.Empty)
                throw new PSArcException("OutputFileName not set.");
            writer.WriteStartElement("create");
            writer.WriteAttributeString("archive", OutputFileName);
            writer.WriteAttributeString("absolute", "false");
            writer.WriteStartElement("compression");
            writer.WriteAttributeString("type", "zlib");
            writer.WriteAttributeString("enabled", "true");
            writer.WriteEndElement();
            writer.WriteStartElement("strip");
            writer.WriteAttributeString("regex", InputDirectory);
            writer.WriteEndElement();
            foreach(string s in filesToPack)
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("path", s);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        public override string ToString()
        {
            using (MemoryStream ms = new MemoryStream())
            using (XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("psarc");
                if(fileType.HasFlag(XmlFileType.Create))
                    writeCreateBlock(writer);
                if(fileType.HasFlag(XmlFileType.Extract))
                    writeExtractBlock(writer);
                writer.WriteEndElement();
                writer.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                StreamReader sr = new StreamReader(ms);
                return sr.ReadToEnd();
            }
        }
    }
}
