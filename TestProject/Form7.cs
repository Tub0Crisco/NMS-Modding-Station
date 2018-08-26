using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMSModdingStation
{
    public partial class Form7 : Form
    {
        FolderBrowserDialog setPakPath = new FolderBrowserDialog();
        FolderBrowserDialog setPathToYourModProjects = new FolderBrowserDialog();
        FolderBrowserDialog pcbanksPathSelect = new FolderBrowserDialog();
        OpenFileDialog setMBINCompilerPath = new OpenFileDialog();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void unpackedButton_Click(object sender, EventArgs e)
        {
            setPakPath.Description = "Select the directory that contains your unpacked game files";
            if (setPakPath.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default["PAKPath"] = setPakPath.SelectedPath;
                unpackedPath.Text = Properties.Settings.Default["PAKPath"].ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void mbinButton_Click(object sender, EventArgs e)
        {
            setMBINCompilerPath.Filter = "EXE Files | *.exe";
            if (setMBINCompilerPath.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default["MBINCompilerPath"] = setMBINCompilerPath.FileName;
                mbinPath.Text = Properties.Settings.Default["MBINCompilerPath"].ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            setPathToYourModProjects.Description = "Select the directory that contains the mods you are creating";
            if (setPathToYourModProjects.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default["yourModsPath"] = setPathToYourModProjects.SelectedPath;
                projectsPath.Text = Properties.Settings.Default["yourModsPath"].ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void pcbanksButton_Click(object sender, EventArgs e)
        {
            setupPCBANKS();
        }

        //
        //Setup PCBANKS path (enable mods and create MODS folder)
        public void setupPCBANKS()
        {
            pcbanksPathSelect.Description = @"Select the PCBANKS directory (\No Man's Sky\GAMEDATA\PCBANKS)";
            if (pcbanksPathSelect.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(pcbanksPathSelect.SelectedPath + @"\MODS");
                Properties.Settings.Default["PCBanks"] = pcbanksPathSelect.SelectedPath;
                pcbanksPath.Text = Properties.Settings.Default["PCBanks"].ToString();
                Properties.Settings.Default.Save();
                if (File.Exists(pcbanksPathSelect.SelectedPath + @"\DISABLEMODS.TXT") && !File.Exists(pcbanksPathSelect.SelectedPath + @"\ENABLEMODS.TXT"))
                {
                    File.Move(pcbanksPathSelect.SelectedPath + @"\DISABLEMODS.TXT", pcbanksPathSelect.SelectedPath + @"\ENABLEMODS.TXT");
                }
            }
        }

        private void unpackedReadonly_CheckedChanged(object sender, EventArgs e)
        {
            switch (unpackedReadonly.CheckState)
            {
                case CheckState.Checked:
                    Properties.Settings.Default["unpackedReadOnly"] = true;
                    Properties.Settings.Default.Save();
                    break;
                case CheckState.Unchecked:
                    Properties.Settings.Default["unpackedReadOnly"] = false;
                    Properties.Settings.Default.Save();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            unpackedPath.Text = "";
            mbinPath.Text = "";
            projectsPath.Text = "";
            pcbanksPath.Text = "";
            unpackedReadonly.CheckState = CheckState.Checked;
        }

        private void pakExml_CheckedChanged(object sender, EventArgs e)
        {
            switch (pakExml.CheckState)
            {
                case CheckState.Checked:
                    Properties.Settings.Default["pakEXML"] = true;
                    Properties.Settings.Default.Save();
                    break;
                case CheckState.Unchecked:
                    Properties.Settings.Default["pakEXML"] = false;
                    Properties.Settings.Default.Save();
                    break;
            }
        }
    }
}
