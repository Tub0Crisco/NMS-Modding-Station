using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NMSModdingStation
{
    public partial class Form6 : Form
    {
        string settingsFile = "";
        List<KeyValuePair<string, string>> settings = new List<KeyValuePair<string, string>>();

        //
        //Edit project from folder
        public Form6(string project)
        {
            InitializeComponent();
            project = project.Remove(project.LastIndexOf("\\"));
            settingsFile = ProjectSettings.getProjectSettingsFile(project);
            settings = ProjectSettings.getProjectSettings(project);
            populateForm();

        }

        //
        //Edit current project
        public Form6()
        {
            InitializeComponent();
            settingsFile = ProjectSettings.getProjectSettingsFile(Form1.currentProject);
            settings = ProjectSettings.getProjectSettings(Form1.currentProject);
            populateForm();
        }

        private void populateForm()
        {
            if (settings != null)
            {
                modAuthorBox.Text = settings[0].Value;
                modNameBox.Text = settings[1].Value;
                if (settings[2].Value == "true")
                {
                    versionCheckBox.Checked = true;
                }
                else
                {
                    versionCheckBox.Checked = false;
                }
                if (settings[3].Value.Contains("."))
                {
                    string[] version = settings[3].Value.Split(new char[] { '.' });
                    versionBox1.Value = Convert.ToInt16(version[0]);
                    versionBox2.Value = Convert.ToInt16(version[1]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modAuthor = modAuthorBox.Text;
            string modName = modNameBox.Text;
            string versionControl;
            if (versionCheckBox.Checked == true)
            {
                versionControl = "true";
            }else
            {
                versionControl = "false";
            }
            string version1 = Convert.ToString(versionBox1.Value);
            string version2 = Convert.ToString(versionBox2.Value);
            string version = version1 + "." + version2;

            ProjectSettings.saveProjectSettings(settingsFile, modAuthor, modName, versionControl, version);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
