using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace NMSModdingStation
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            listViewFill();
        }

        private void listViewFill()
        {
            listView1.Items.Clear();

            textBox1.Text = Properties.Settings.Default["yourModsPath"].ToString();

            string[] dirs = Directory.GetDirectories(Properties.Settings.Default["yourModsPath"].ToString());
            foreach (string dir in dirs)
            {

                string dirName = dir.Substring(dir.LastIndexOf("\\") + 1);
                ListViewItem item = new ListViewItem(dirName);
                item.Tag = dir;
                item.ImageIndex = 0;
                listView1.Items.Add(item);

            }
        }

        private void listView1_Click(object sender, MouseEventArgs e)
        {
            Point mousePosition = listView1.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listView1.HitTest(mousePosition);

            if(hit != null)
            {
                textBox1.Text = Properties.Settings.Default["yourModsPath"].ToString() + "\\" + listView1.FocusedItem.Text;
            }
        }

        private void listView1_DoubleClick(object sender, MouseEventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string newProject = f1.showPakNamePrompt("Name New Project");

            if (string.IsNullOrWhiteSpace(newProject))
                newProject = "New Project";

            Directory.CreateDirectory(Properties.Settings.Default["yourModsPath"].ToString() + "\\" + newProject);
            listViewFill();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Cancel;
            }else
            {
                if (textBox1.Text == Properties.Settings.Default["yourModsPath"].ToString())
                {
                    MessageBox.Show("Select a Project or Create a New Project");
                    e.Cancel = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
