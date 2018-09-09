using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace NMSModdingStation
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog pcbanksPath = new FolderBrowserDialog();
        ToolTip listViewLoc = new ToolTip();
        public static string currentProject = "";
        

        public Form1()
        {
            InitializeComponent();
            controlControls();
        }

        internal static void listViewFill(string v, object listView1, object textBox1)
        {
            throw new NotImplementedException();
        }

        public void setStatus(string status)
        {
            statusLabel.Text = status;
        }

        //
        //Enable/Disable controls based on set Paths
        public void controlControls()
        {
            if (Properties.Settings.Default["PAKPath"].ToString() == String.Empty || Properties.Settings.Default["MBINCompilerPath"].ToString() == String.Empty || Properties.Settings.Default["yourModsPath"].ToString() == String.Empty)
            {
                disableControls();
                setStatus("Set All Paths In Settings To Begin");
            }
            else
            {
                enableControls();
                setStatus("Ready");
            }
        }

        public void disableControls()
        {
            listView1.Enabled = false;
            textBox1.Enabled = false;
            listView2.Enabled = false;
            textBox2.Enabled = false;
            setCurrentProjectToolStripMenuItem.Enabled = false;
            editCurrentProjectToolStripMenuItem.Enabled = false;
            listView1.Items.Clear();
            textBox1.Text = "";
            listView2.Items.Clear();
            textBox2.Text = "";
        }

        public void enableControls()
        {
            listView1.Enabled = true;
            textBox1.Enabled = true;
            listView2.Enabled = true;
            textBox2.Enabled = true;
            setCurrentProjectToolStripMenuItem.Enabled = true;
            editCurrentProjectToolStripMenuItem.Enabled = true;
            listViewFill(Properties.Settings.Default["PAKPath"].ToString(), listView1, textBox1);
            listViewFill(Properties.Settings.Default["yourModsPath"].ToString(), listView2, textBox2);
        }
       
        //
        //Fill listView with Path
        public void listViewFill(String path, ListView listview, TextBox textbox)
        {
            if (Directory.Exists(path))
            {
                listview.Items.Clear();
                textbox.Text = path;
                if (path != Properties.Settings.Default["PAKPath"].ToString() && path != Properties.Settings.Default["yourModsPath"].ToString())
                {
                    ListViewItem backNavItem = new ListViewItem("Go Back");
                    backNavItem.SubItems.Add("NAV");
                    backNavItem.ImageIndex = 4;
                    listview.Items.Add(backNavItem);
                }

                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {

                    string dirName = dir.Substring(dir.LastIndexOf("\\") + 1);
                    ListViewItem item = new ListViewItem(dirName);
                    item.Tag = dir;
                    item.SubItems.Add("DIR");
                    FileInfo fi = new FileInfo(dir);
                    fi.Refresh();
                    DateTime modified = fi.LastWriteTime;
                    item.SubItems.Add(modified.ToString());
                    item.ImageIndex = 0;
                    listview.Items.Add(item);

                }

                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {

                    string fileName = Path.GetFileNameWithoutExtension(file);
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;
                    item.SubItems.Add(Path.GetExtension(file));
                    FileInfo fi = new FileInfo(file);
                    fi.Refresh();
                    DateTime modified = fi.LastWriteTime;
                    item.SubItems.Add(modified.ToString());
                    long size = fi.Length;
                    long kb = size / 1024;
                    if(kb <= 0)
                    {
                        item.SubItems.Add(size.ToString() + " B");
                    }
                    else
                    {
                        item.SubItems.Add(kb.ToString() + " KB");
                    }                    

                    item.ImageIndex = 3;

                    if (item.SubItems[1].Text.ToUpper() == ".MBIN")
                    {
                        item.ImageIndex = 1;
                    }

                    if (item.SubItems[1].Text.ToUpper() == ".EXML")
                    {
                        item.ImageIndex = 2;
                    }

                    if (item.SubItems[1].Text.ToUpper() == ".PAK")
                    {
                        item.ImageIndex = 5;
                    }

                    if (item.SubItems[1].Text.ToUpper() == ".NMF")
                    {
                        item.ImageIndex = 6;
                    }

                    listview.Items.Add(item);

                }
            }
        }

        //
        //Method to get current tab for context menu items
        public string whichTabContextMenu()
        {
            string currentTab = tabControl1.SelectedTab.Name;
            if (currentTab == "tabPage1")
            {
                return "tab1";
            }else
            {
                return "tab2";
            }
        }

        //
        //Mouse click on listview
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView thisList = sender as ListView;
                string currentTab = whichTabContextMenu();
                contextMenuStrip1.Items[2].Visible = false; //Copy to Project
                contextMenuStrip1.Items[4].Visible = false; //Pack Mod
                contextMenuStrip1.Items[6].Visible = false; //Delete
                contextMenuStrip1.Items[3].Visible = false; //Recompile
                contextMenuStrip1.Items[5].Visible = false; //Create New Folder
                contextMenuStrip1.Items[8].Visible = false; //Edit Project
                contextMenuStrip1.Items[9].Visible = false; //Copy To PCBANKS/MODS
                contextMenuStrip1.Items[10].Visible = true; //Open PCBANKS/MODS
                Point mousePosition = thisList.PointToClient(Control.MousePosition);
                ListViewHitTestInfo hit = thisList.HitTest(mousePosition);

                //If current tab is the project view
                if (currentTab == "tab2")
                {
                    string path = getCurrentProjectRoot();
                    if (path != null)
                    {
                        contextMenuStrip1.Items[4].Visible = true; //Show Pack Mod
                        contextMenuStrip1.Items[8].Visible = true; //Show Edit Project
                    }
                    contextMenuStrip1.Items[5].Visible = true; //Show Create New Folder
                }

                //If item is right clicked
                if (hit.Item != null)
                {
                    if (currentTab == "tab2")
                    {
                        contextMenuStrip1.Items[6].Visible = true; //Show Delete
                    }else
                    {
                        if (!Properties.Settings.Default.unpackedReadOnly)
                        {
                            contextMenuStrip1.Items[6].Visible = true; //Show Delete
                        }
                    }
                    contextMenuStrip1.Items[5].Visible = false; //Hide Create New Folder
                }
                else
                {
                    contextMenuStrip1.Items[5].Visible = true; //Show Create New Folder
                }

                try
                {
                    if (thisList.FocusedItem.Bounds.Contains(e.Location) == true)
                    {
                        //If not a directory or nav item
                        if (thisList.FocusedItem.SubItems[1].Text != "DIR" && thisList.FocusedItem.SubItems[1].Text != "NAV")
                        {
                            //If item is an exml file
                            if (thisList.FocusedItem.SubItems[1].Text.ToUpper() == ".EXML")
                            {
                                contextMenuStrip1.Items[3].Visible = true; // Show Recompile
                            }
                            //If item is in PAK View
                            if (currentTab == "tab1")
                            {
                                contextMenuStrip1.Items[2].Visible = true; //Show Copy to Project
                            }else //If item is in Project View
                            {
                                if(thisList.FocusedItem.SubItems[1].Text.ToUpper() == ".PAK")
                                {
                                    contextMenuStrip1.Items[9].Visible = true; //Show Copy To PCBANKS/MODS
                                }
                            }
                        }
                        else //If is a directory or nav item
                        {
                            //If item is not nav
                            if(thisList.FocusedItem.SubItems[1].Text != "NAV")
                            {
                                //If item is in PAK View
                                if (currentTab == "tab1")
                                {
                                    contextMenuStrip1.Items[2].Visible = true; //Show Copy to Project
                                }
                            }
                            else //If item is nav
                            {
                                contextMenuStrip1.Items[6].Visible = false; //Hide Delete
                            }
                        }
                    }
                }
                catch (NullReferenceException) { }
            }
        }

        //
        //Double click on listview
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            ListView thisList = sender as ListView;
            TextBox pathText = thisList.Parent.Controls[1] as TextBox;
            if (thisList.FocusedItem.SubItems[1].Text == "DIR")
            {
                listViewFill(pathText.Text + "\\" + thisList.FocusedItem.Text, thisList, pathText);
            }
            else if (thisList.FocusedItem.SubItems[1].Text == "NAV")
            {
                string current = pathText.Text;
                DirectoryInfo parentDir = Directory.GetParent(current.EndsWith("\\") ? current : string.Concat(current, "\\"));
                listViewFill(parentDir.Parent.FullName, thisList, pathText);
            }else
            {
                string currentTab = whichTabContextMenu();
                if(currentTab == "tab2")
                {
                    processFileToolStripMenuItem_Click(sender, e);
                }else
                {
                    if(Properties.Settings.Default.unpackedReadOnly)
                    {
                        setStatus("To process file copy to project first");
                    }
                    else
                    {
                        processFileToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

        //
        //Return to the set path of each listview
        private void returnHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentTab = whichTabContextMenu();

            if (currentTab == "tab1")
            {
                listViewFill(Properties.Settings.Default["PAKPath"].ToString(), listView1, textBox1);
            }else
            {
                if(currentProject == "" || currentProject == null)
                {
                    listViewFill(Properties.Settings.Default["yourModsPath"].ToString(), listView2, textBox2);
                }else
                {
                    listViewFill(currentProject, listView2, textBox2);
                }
            }
        }

        //
        //Robust Method for Deleting Directories
        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        //
        //Delete Files and Folders
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentTab = whichTabContextMenu();
            ListView thisList = new ListView();
            TextBox thisTextBox = new TextBox();
            if (currentTab == "tab1")
            {
                thisList = listView1;
                thisTextBox = textBox1;
            }
            else
            {
                thisList = listView2;
                thisTextBox = textBox2;
            }

            DialogResult deleteYesNo = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);

            if (deleteYesNo == DialogResult.Yes)
            {
                foreach (ListViewItem item in thisList.SelectedItems)
                {
                    if (item.SubItems[1].Text != "NAV")
                    {
                        string name = item.Text;
                        string ext = "\\";
                        string currentPath = thisTextBox.Text;

                        if (item.SubItems[1].Text != "DIR")
                        {
                            ext = item.SubItems[1].Text;
                        }

                        currentPath = currentPath + "\\" + name + ext;
                        if (ext == "\\")
                        {
                            DeleteDirectory(currentPath);
                            setStatus("Delete Successful");
                        }
                        else
                        {
                            try
                            {
                                File.Delete(currentPath);
                                setStatus("Delete Successful");
                            }
                            catch (IOException)
                            {
                                MessageBox.Show("Can't Delete. Check if the file is in use.");
                            }
                            catch (UnauthorizedAccessException)
                            {
                                MessageBox.Show("Can't Delete. Are you allowed? Try running as Administrator.");
                            }
                        }
                    }
                }

                listViewFill(thisTextBox.Text, thisList, thisTextBox);
            }          
        }

        //
        //Copy Files/Folders to Selected Project Folder
        private void copyToProjectPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentProject == "")
            {
                currentProject = showProjectSelect();
            }
            if(currentProject != null)
            {
                setCurrentProjectToolStripMenuItem.ToolTipText = currentProject;
                string copyFrom = textBox1.Text + "\\";
                string copyTo = copyFrom.Replace(Properties.Settings.Default["PAKPath"].ToString(), currentProject);
                bool isFile = false;
                string file;
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    copyTo = copyTo.Replace(item.Text + item.SubItems[1].Text, "\\");
                    file = item.Text;
                    if (item.SubItems[1].Text != "DIR")
                    {
                        file = file + item.SubItems[1].Text;
                        isFile = true;
                    }

                    if (isFile)
                    {
                        Directory.CreateDirectory(copyTo);
                        File.Copy(copyFrom + file, copyTo + file, true);
                    }
                    else
                    {
                        string source_dir = copyFrom + file + "\\";
                        string destination_dir = copyTo + file + "\\";
                        Directory.CreateDirectory(destination_dir);
                        foreach (string dir in Directory.GetDirectories(source_dir, "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(destination_dir + dir.Substring(source_dir.Length));
                        }
                        foreach (string file_name in Directory.GetFiles(source_dir, "*.*", SearchOption.AllDirectories))
                        {
                            File.Copy(file_name, destination_dir + file_name.Substring(source_dir.Length), true);
                        }
                    }
                }

                listViewFill(copyTo.Remove(copyTo.LastIndexOf("\\")), listView2, textBox2);
                tabControl1.SelectedIndex = 1;
                setStatus("Copy Successful");
            }
            else
            {
                currentProject = "";
            }
        }

        //
        //Method to start program with arguments
        private void processFile(string command, string arg)
        {
            ProcessStartInfo start = new ProcessStartInfo("\"" + command + "\"", arg);
            start.UseShellExecute = false;
            start.CreateNoWindow = true; // Important if you want to keep shell window hidden
            Process.Start(start).WaitForExit(); //important to add WaitForExit()
        }

        //
        //Process files from context menu
        private void processFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentTab = whichTabContextMenu();
            ListView thisList = new ListView();
            TextBox thisBox = new TextBox();

            if (currentTab == "tab1")
            {
                thisList = listView1;
                thisBox = textBox1;
            }else
            {
                thisList = listView2;
                thisBox = textBox2;
            }

            string path = thisBox.Text + "\\";
            string file = thisList.FocusedItem.Text;
            string ext = thisList.FocusedItem.SubItems[1].Text;

            if(ext.ToUpper() == ".MBIN" || ext.ToUpper() == ".PC")
            {
                processFile(@Properties.Settings.Default["MBINCompilerPath"].ToString(), "convert -y " + "\"" + @path + @file + @ext + "\"");
                setStatus("Decompiled " +  @file + @ext);
            }else if(ext.ToUpper() == ".PAK")
            {
                Functions.Extract(path + file + ext, null);
                setStatus("Extracted " + file + ext);
            }else if(ext.ToUpper() == ".EXML" || ext.ToUpper() == ".H" || ext.ToUpper() == ".GLSL" || ext.ToUpper() == ".TXT" || ext.ToUpper() == ".CSV" || ext.ToUpper() == ".XML" || ext.ToUpper() == ".JSON")
            {
                try
                {
                    Process.Start("notepad++.exe", path + file + ext);
                }
                catch(Win32Exception)
                {
                    Process.Start("notepad.exe", path + file + ext);
                }
            }else if(ext.ToUpper() == ".NMF")
            {
                string project = getCurrentProjectRoot();
                if (project != null)
                {
                    Form6 settingsForm = new Form6(project);
                    settingsForm.ShowDialog();
                }
            }
            else {
                Process.Start(path + file + ext);
            }

            listViewFill(path.Remove(path.LastIndexOf("\\")), thisList, thisBox);
        }

        //
        //Refresh current listview
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentTab = whichTabContextMenu();
            ListView thisList = new ListView();
            TextBox thisBox = new TextBox();

            if (currentTab == "tab1")
            {
                thisList = listView1;
                thisBox = textBox1;
            }
            else
            {
                thisList = listView2;
                thisBox = textBox2;
            }

            listViewFill(thisBox.Text, thisList, thisBox);
        }

        //
        //Show Helpful Links Window
        private void helpfulLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 helpLinks = new Form2();
            helpLinks.ShowDialog();
        }

        //
        //Show naming dialog
        public string showPakNamePrompt(string text, bool folder = false)
        {
            Form3 pakPrompt = new Form3();
            pakPrompt.Text = text;
            if (!folder)
            {
                string project = getCurrentProjectRoot();
                if (project != null)
                {
                    project = project.Remove(project.LastIndexOf("\\"));
                    List<KeyValuePair<string, string>> settings = ProjectSettings.getProjectSettings(project);
                    string author = "";
                    string modName = "";
                    string version = "";
                    if (settings[0].Value != "")
                    {
                        author = settings[0].Value + ".";
                    }
                    if(settings[1].Value != "")
                    {
                        modName = settings[1].Value;
                    }
                    if(settings[2].Value == "true")
                    {
                        if(File.Exists(project + "\\_" + author + modName + "." + settings[3].Value + ".pak"))
                        {
                            if (settings[3].Value.Contains("."))
                            {
                                string[] versionSplit = settings[3].Value.Split(new char[] { '.' });
                                string version1 = versionSplit[0];
                                string version2 = versionSplit[1];
                                int vers2 = Convert.ToInt16(version2) + 1;
                                version = "." + version1 + "." + vers2.ToString();
                            }else
                            {
                                version = ".0.1";
                            }
                        }else
                        {
                            version = "." + settings[3].Value;
                        }
                    }
                    string filename = author + modName + version;
                    if(!string.IsNullOrWhiteSpace(filename))
                    {
                        pakPrompt.textBox1.Text = "_" + filename;
                    }
                }
            }
            return pakPrompt.ShowDialog() == DialogResult.OK ? pakPrompt.textBox1.Text : null;
        }

        //
        //Show project pick dialog
        public static string showProjectSelect()
        {
            Form4 projectSelect = new Form4();
            return projectSelect.ShowDialog() == DialogResult.OK ? projectSelect.textBox1.Text : null;
        }

        //
        //Get current project root
        public string getCurrentProjectRoot(bool ignoreCurrentProject = true)
        {
            if(ignoreCurrentProject)
            {
                string[] myModsPath = Properties.Settings.Default["yourModsPath"].ToString().Split(new char[] { '\\' });
                string[] currentPath = textBox2.Text.Split(new char[] { '\\' });
                if(myModsPath.Length == currentPath.Length)
                {
                    return null;
                }
                string modRootPath = "";
                for (int x = 0; x < myModsPath.Length + 1; x++)
                {
                    modRootPath += currentPath[x] + "\\";
                }
                return modRootPath;
            }else
            {
                return currentProject;
            }
        }

        //
        //pack all files in current directory with psarctool
        private void packModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = getCurrentProjectRoot();
            if(path == null)
            {
                return;
            }
            List<string> entriesAll = new List<string>(Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories));

            foreach(string entry in entriesAll.ToList())
            {
                if (Properties.Settings.Default.pakEXML)
                {
                    if (!entry.ToUpper().Contains(".EXML") && !entry.ToUpper().Contains(".MBIN") && !entry.ToUpper().Contains(".PC") && !entry.ToUpper().Contains(".BIN") && !entry.ToUpper().Contains(".TTC") && !entry.ToUpper().Contains(".TTF") && !entry.ToUpper().Contains(".DDS") && !entry.ToUpper().Contains(".FNT") && !entry.ToUpper().Contains(".H") && !entry.ToUpper().Contains(".GLSL") && !entry.ToUpper().Contains(".SQS") && !entry.ToUpper().Contains(".TXT") && !entry.ToUpper().Contains(".CSV") && !entry.ToUpper().Contains(".WEM") && !entry.ToUpper().Contains(".BNK") && !entry.ToUpper().Contains(".XML") && !entry.ToUpper().Contains(".JSON"))
                    {
                        entriesAll.Remove(entry);
                    }
                }else
                {
                    if (!entry.ToUpper().Contains(".MBIN") && !entry.ToUpper().Contains(".PC") && !entry.ToUpper().Contains(".BIN") && !entry.ToUpper().Contains(".TTC") && !entry.ToUpper().Contains(".TTF") && !entry.ToUpper().Contains(".DDS") && !entry.ToUpper().Contains(".FNT") && !entry.ToUpper().Contains(".H") && !entry.ToUpper().Contains(".GLSL") && !entry.ToUpper().Contains(".SQS") && !entry.ToUpper().Contains(".TXT") && !entry.ToUpper().Contains(".CSV") && !entry.ToUpper().Contains(".WEM") && !entry.ToUpper().Contains(".BNK") && !entry.ToUpper().Contains(".XML") && !entry.ToUpper().Contains(".JSON"))
                    {
                        entriesAll.Remove(entry);
                    }
                }
                
                FileAttributes attr = File.GetAttributes(entry);
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    entriesAll.Remove(entry);
                }
            }

            IList<string> entries = entriesAll as IList<string>;

            string pakName = showPakNamePrompt("Name your PAK File");

            if (pakName != null && entries.Any())
            {
                Functions.Create(entries, pakName, path);

                string project = getCurrentProjectRoot();
                if (project != null)
                {
                    project = project.Remove(project.LastIndexOf("\\"));
                    List<KeyValuePair<string, string>> settings = ProjectSettings.getProjectSettings(project);
                    if (settings[2].Value == "true")
                    {
                        string author = settings[0].Value;
                        string modName = settings[1].Value;
                        string versionControl = settings[2].Value;
                        string version = settings[3].Value;

                        if (File.Exists(project + "\\_" + author + "." + modName + "." + version + ".pak"))
                        {
                            if (version.Contains("."))
                            {
                                string[] versionSplit = version.Split(new char[] { '.' });
                                string version1 = versionSplit[0];
                                string version2 = versionSplit[1];
                                int vers2 = Convert.ToInt16(version2) + 1;
                                version = version1 + "." + vers2.ToString();
                            }else
                            {
                                version = "0.1";
                            }
                        }
                        ProjectSettings.saveProjectSettings(ProjectSettings.getProjectSettingsFile(project), author, modName, versionControl, version);
                    }
                }

                //File.WriteAllLines(path + pakName + ".PAKFILES.txt", entries);
                listViewFill(path.Remove(path.LastIndexOf("\\")), listView2, textBox2);
                setStatus("Packed " + pakName);
            }else
            {
                setStatus("Nothing to pack!");
            }
        }

        //
        //Recompile exml to mbin
        private void recompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentTab = whichTabContextMenu();
            ListView thisList = new ListView();
            TextBox thisBox = new TextBox();

            if (currentTab == "tab1")
            {
                thisList = listView1;
                thisBox = textBox1;
            }
            else
            {
                thisList = listView2;
                thisBox = textBox2;
            }

            string path = thisBox.Text + "\\";
            string file = thisList.FocusedItem.Text;
            string ext = thisList.FocusedItem.SubItems[1].Text;

            processFile(@Properties.Settings.Default["MBINCompilerPath"].ToString(), "convert -y " + "\"" + @path + @file + @ext + "\"");
            listViewFill(path.Remove(path.LastIndexOf("\\")), thisList, thisBox);
            setStatus("Compiled " + @file + @ext);
        }

        //
        //Create new folder
        private void createNewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderName = showPakNamePrompt("Name the New Folder", true);
            if (folderName != null)
            {
                if (string.IsNullOrWhiteSpace(folderName))
                    folderName = "New Folder";

                string path = textBox2.Text;

                Directory.CreateDirectory(path + "\\" + folderName);
                listViewFill(path, listView2, textBox2);
                setStatus("New Folder Created");
            }
        }

        //
        //Set Current Project
        private void setCurrentProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentProject = showProjectSelect();
            if (currentProject != null)
            {
                setCurrentProjectToolStripMenuItem.ToolTipText = currentProject;
                listViewFill(currentProject, listView2, textBox2);
                setStatus("Project Set");
            }
            else
            {
                currentProject = "";
            }
        }

        //
        //Delete files, and backspace navigation
        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            string currentTab = whichTabContextMenu();
            if (e.KeyCode == Keys.Delete)
            {
                if (currentTab == "tab2")
                {
                    deleteToolStripMenuItem_Click(this, new EventArgs());
                }else
                {
                    if (!Properties.Settings.Default.unpackedReadOnly)
                    {
                        deleteToolStripMenuItem_Click(this, new EventArgs());
                    }
                }
            }

            if(e.KeyCode == Keys.Back)
            {
                ListView thisList = sender as ListView;
                if (thisList.Items[0].SubItems[1].Text == "NAV")
                {
                    TextBox pathText = thisList.Parent.Controls[1] as TextBox;
                    string current = pathText.Text;
                    DirectoryInfo parentDir = Directory.GetParent(current.EndsWith("\\") ? current : string.Concat(current, "\\"));
                    listViewFill(parentDir.Parent.FullName, thisList, pathText);
                }
            }
        }

        //
        //Unpack game files
        private void unpackGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog unpackPath = new FolderBrowserDialog();
            string[] gameFiles = { };

            if (String.IsNullOrWhiteSpace(Properties.Settings.Default["PCBanks"].ToString()))
            {
                setupPCBANKS();
            }
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default["PCBanks"].ToString()))
            {
                gameFiles = Directory.GetFiles(Properties.Settings.Default["PCBanks"].ToString(), "NMSARC.*.pak", SearchOption.TopDirectoryOnly);
                if (gameFiles != null && gameFiles.Length != 0)
                {
                    unpackPath.Description = "Select where to unpack the game files";
                    if (unpackPath.ShowDialog() == DialogResult.OK)
                    {
                        PSArcLib.PSArcXmlFile.XmlFileType xmlType = PSArcLib.PSArcXmlFile.XmlFileType.Extract;
                        PSArcLib.PSArcXmlFile gamefilesXML1 = new PSArcLib.PSArcXmlFile(xmlType);
                        gamefilesXML1.OutputFileName = unpackPath.SelectedPath;
                        PSArcLib.PSArcXmlFile gamefilesXML2 = new PSArcLib.PSArcXmlFile(xmlType);
                        gamefilesXML2.OutputFileName = unpackPath.SelectedPath;
                        PSArcLib.PSArcXmlFile gamefilesXML3 = new PSArcLib.PSArcXmlFile(xmlType);
                        gamefilesXML3.OutputFileName = unpackPath.SelectedPath;
                        PSArcLib.PSArcXmlFile gamefilesXML4 = new PSArcLib.PSArcXmlFile(xmlType);
                        gamefilesXML4.OutputFileName = unpackPath.SelectedPath;
                        PSArcLib.PSArcXmlFile gamefilesXML5 = new PSArcLib.PSArcXmlFile(xmlType);
                        gamefilesXML5.OutputFileName = unpackPath.SelectedPath;
                        int fifth = gameFiles.Length / 5;
                        int counter = 1;
                        
                        foreach (string file in gameFiles)
                        {
                            if(counter <= fifth)
                            {
                                gamefilesXML1.AddPakToExtract(file);
                            }
                            if(counter > fifth && counter <= fifth * 2)
                            {
                                gamefilesXML2.AddPakToExtract(file);
                            }
                            if (counter > fifth * 2 && counter <= fifth * 3)
                            {
                                gamefilesXML3.AddPakToExtract(file);
                            }
                            if (counter > fifth * 3 && counter <= fifth * 4)
                            {
                                gamefilesXML4.AddPakToExtract(file);
                            }
                            if (counter > fifth * 4)
                            {
                                gamefilesXML5.AddPakToExtract(file);
                            }
                            counter++;
                        }
                        PSArcLib.PSArc psarc = new PSArcLib.PSArc();

                        BackgroundWorker bw = new BackgroundWorker();

                        // this allows our worker to report progress during work
                        bw.WorkerReportsProgress = true;

                        // what to do in the background thread
                        bw.DoWork += new DoWorkEventHandler(
                        delegate (object o, DoWorkEventArgs args)
                        {
                            BackgroundWorker b = o as BackgroundWorker;

                            Invoke((MethodInvoker)(() => setPAKPathToolStripMenuItem.Enabled = false));
                            Invoke((MethodInvoker)(() => setPathToPCBANKSToolStripMenuItem.Enabled = false));
                            Invoke((MethodInvoker)(() => unpackGameFilesToolStripMenuItem.Enabled = false));
                            Invoke((MethodInvoker)(() => clearAllSettingsToolStripMenuItem.Enabled = false));
                            Invoke((MethodInvoker)(() => toolStripProgressBar1.Value = 0));
                            Invoke((MethodInvoker)(() => toolStripProgressBar1.Visible = true));

                            b.ReportProgress(0);
                            psarc.Extract(gamefilesXML1);
                            b.ReportProgress(20);
                            psarc.Extract(gamefilesXML2);
                            b.ReportProgress(40);
                            psarc.Extract(gamefilesXML3);
                            b.ReportProgress(60);
                            psarc.Extract(gamefilesXML4);
                            b.ReportProgress(80);
                            psarc.Extract(gamefilesXML5);
                            b.ReportProgress(100);

                        });

                        // what to do when progress changed (update the progress bar for example)
                        bw.ProgressChanged += new ProgressChangedEventHandler(
                        delegate (object o, ProgressChangedEventArgs args)
                        {
                            Console.WriteLine("{0}% Completed", args.ProgressPercentage);
                            setStatus(String.Format("Unpacking Game Files {0}%...", args.ProgressPercentage));
                            Invoke((MethodInvoker)(() => toolStripProgressBar1.Value = args.ProgressPercentage));
                        });

                        // what to do when worker completes its task (notify the user)
                        bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                        delegate (object o, RunWorkerCompletedEventArgs args)
                        {
                            Invoke((MethodInvoker)(() => setPAKPathToolStripMenuItem.Enabled = true));
                            Invoke((MethodInvoker)(() => setPathToPCBANKSToolStripMenuItem.Enabled = true));
                            Invoke((MethodInvoker)(() => unpackGameFilesToolStripMenuItem.Enabled = true));
                            Invoke((MethodInvoker)(() => clearAllSettingsToolStripMenuItem.Enabled = true));
                            Invoke((MethodInvoker)(() => toolStripProgressBar1.Value = 0));
                            Invoke((MethodInvoker)(() => toolStripProgressBar1.Visible = false));
                            Console.WriteLine("Finished");
                            Properties.Settings.Default["PAKPath"] = unpackPath.SelectedPath;
                            Properties.Settings.Default.Save();
                            setPAKPathToolStripMenuItem.ToolTipText = Properties.Settings.Default["PAKPath"].ToString();
                            listViewFill(Properties.Settings.Default["PAKPath"].ToString(), listView1, textBox1);
                            controlControls();
                        });

                        bw.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Game files not found! Try to set your PCBANKS folder again!");
                }
            }
        }

        //
        //Open current view in Windows File Explorer
        private void openInFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentTab = whichTabContextMenu();
            if (currentTab == "tab1")
            {
                Process.Start(textBox1.Text);
            }
            else
            {
                Process.Start(textBox2.Text);
            }
        }

        //
        //Open About Dialog
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        //
        //Edit Project Settings
        private void editCurrentProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentProject == "" || currentProject == null)
            {
                currentProject = showProjectSelect();
            }
            if (currentProject != null)
            {
                Form6 settingsForm = new Form6();
                settingsForm.ShowDialog();
                listViewFill(currentProject, listView2, textBox2);
            }
        }

        //
        //Edit Project from context menu
        private void editProjectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = getCurrentProjectRoot();
            if(path != null)
            {
                Form6 settingsForm = new Form6(path);
                settingsForm.ShowDialog();
            }
        }

        //
        //Setup PCBANKS path (enable mods and create MODS folder)
        public void setupPCBANKS()
        {
            pcbanksPath.Description = @"Select the PCBANKS directory (\No Man's Sky\GAMEDATA\PCBANKS)";
            if (pcbanksPath.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(pcbanksPath.SelectedPath + @"\MODS");
                Properties.Settings.Default["PCBanks"] = pcbanksPath.SelectedPath;
                Properties.Settings.Default.Save();
                setPathToPCBANKSToolStripMenuItem.ToolTipText = Properties.Settings.Default["PCBanks"].ToString();
                if (File.Exists(pcbanksPath.SelectedPath + @"\DISABLEMODS.TXT") && !File.Exists(pcbanksPath.SelectedPath + @"\ENABLEMODS.TXT"))
                {
                    File.Move(pcbanksPath.SelectedPath + @"\DISABLEMODS.TXT", pcbanksPath.SelectedPath + @"\ENABLEMODS.TXT");
                }
            }
        }

        //
        //Copy selected pak to PCBANKS/MODS
        private void copyToModsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default["PCBanks"].ToString()))
            {
                setupPCBANKS();
            }
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default["PCBanks"].ToString()))
            {
                string path = textBox2.Text + "\\";
                string filename = listView2.FocusedItem.Text + listView2.FocusedItem.SubItems[1].Text;

                if (File.Exists(path + filename))
                {
                    File.Copy(path + filename, Properties.Settings.Default["PCBanks"].ToString() + "\\MODS" + "\\" + filename, true);
                    setStatus("Copied " + filename + " to MODS Folder");
                }
                else
                {
                    setStatus("File not found.");
                }
            }
        }

        //
        //Open PCBANKS/MODS
        private void openModsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default["PCBanks"].ToString()))
            {
                setupPCBANKS();
            }
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default["PCBanks"].ToString()))
            {
                Process.Start(Properties.Settings.Default["PCBanks"].ToString() + "\\MODS");
            }
        }

        //
        //Open Settings dialog
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 settings = new Form7();
            settings.unpackedPath.Text = Properties.Settings.Default["PAKPath"].ToString();
            settings.mbinPath.Text = Properties.Settings.Default["MBINCompilerPath"].ToString();
            settings.projectsPath.Text = Properties.Settings.Default["yourModsPath"].ToString();
            settings.pcbanksPath.Text = Properties.Settings.Default["PCBanks"].ToString();
            if(Properties.Settings.Default.unpackedReadOnly)
            {
                settings.unpackedReadonly.CheckState = CheckState.Checked;
            }
            else
            {
                settings.unpackedReadonly.CheckState = CheckState.Unchecked;
            }
            if (Properties.Settings.Default.pakEXML)
            {
                settings.pakExml.CheckState = CheckState.Checked;
            }
            else
            {
                settings.pakExml.CheckState = CheckState.Unchecked;
            }
            settings.ShowDialog();
            controlControls();
        }
    }
}