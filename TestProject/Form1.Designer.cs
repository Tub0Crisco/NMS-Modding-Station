namespace NMSModdingStation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCurrentProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPAKPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMBINCompilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathToYourModProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathToPCBANKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackGameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpfulLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToProjectPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recompileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToModsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpfulLinksToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(195, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCurrentProjectToolStripMenuItem,
            this.editCurrentProjectToolStripMenuItem,
            this.setPAKPathToolStripMenuItem,
            this.setMBINCompilerToolStripMenuItem,
            this.setPathToYourModProjectsToolStripMenuItem,
            this.setPathToPCBANKSToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.unpackGameFilesToolStripMenuItem,
            this.clearAllSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fileToolStripMenuItem.Text = "Setup";
            // 
            // setCurrentProjectToolStripMenuItem
            // 
            this.setCurrentProjectToolStripMenuItem.Name = "setCurrentProjectToolStripMenuItem";
            this.setCurrentProjectToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.setCurrentProjectToolStripMenuItem.Text = "Set Current Project";
            this.setCurrentProjectToolStripMenuItem.ToolTipText = "No Current Project Chosen";
            this.setCurrentProjectToolStripMenuItem.Click += new System.EventHandler(this.setCurrentProjectToolStripMenuItem_Click);
            // 
            // editCurrentProjectToolStripMenuItem
            // 
            this.editCurrentProjectToolStripMenuItem.Name = "editCurrentProjectToolStripMenuItem";
            this.editCurrentProjectToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.editCurrentProjectToolStripMenuItem.Text = "Edit Current Project";
            this.editCurrentProjectToolStripMenuItem.Click += new System.EventHandler(this.editCurrentProjectToolStripMenuItem_Click);
            // 
            // setPAKPathToolStripMenuItem
            // 
            this.setPAKPathToolStripMenuItem.Name = "setPAKPathToolStripMenuItem";
            this.setPAKPathToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.setPAKPathToolStripMenuItem.Text = "Set Path to Unpacked Game Files";
            this.setPAKPathToolStripMenuItem.ToolTipText = "Path Not Set";
            this.setPAKPathToolStripMenuItem.Visible = false;
            // 
            // setMBINCompilerToolStripMenuItem
            // 
            this.setMBINCompilerToolStripMenuItem.Name = "setMBINCompilerToolStripMenuItem";
            this.setMBINCompilerToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.setMBINCompilerToolStripMenuItem.Text = "Set Path to MBINCompiler";
            this.setMBINCompilerToolStripMenuItem.ToolTipText = "Path Not Set";
            this.setMBINCompilerToolStripMenuItem.Visible = false;
            // 
            // setPathToYourModProjectsToolStripMenuItem
            // 
            this.setPathToYourModProjectsToolStripMenuItem.Name = "setPathToYourModProjectsToolStripMenuItem";
            this.setPathToYourModProjectsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.setPathToYourModProjectsToolStripMenuItem.Text = "Set Path to Your Mod Projects";
            this.setPathToYourModProjectsToolStripMenuItem.ToolTipText = "Path Not Set";
            this.setPathToYourModProjectsToolStripMenuItem.Visible = false;
            // 
            // setPathToPCBANKSToolStripMenuItem
            // 
            this.setPathToPCBANKSToolStripMenuItem.Name = "setPathToPCBANKSToolStripMenuItem";
            this.setPathToPCBANKSToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.setPathToPCBANKSToolStripMenuItem.Text = "Set Path to PCBANKS";
            this.setPathToPCBANKSToolStripMenuItem.Visible = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // unpackGameFilesToolStripMenuItem
            // 
            this.unpackGameFilesToolStripMenuItem.Name = "unpackGameFilesToolStripMenuItem";
            this.unpackGameFilesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.unpackGameFilesToolStripMenuItem.Text = "Unpack Game Files";
            this.unpackGameFilesToolStripMenuItem.ToolTipText = "This will unpack the game files where you choose. Warning: This operation takes a" +
    " few minutes to complete.";
            this.unpackGameFilesToolStripMenuItem.Click += new System.EventHandler(this.unpackGameFilesToolStripMenuItem_Click);
            // 
            // clearAllSettingsToolStripMenuItem
            // 
            this.clearAllSettingsToolStripMenuItem.Name = "clearAllSettingsToolStripMenuItem";
            this.clearAllSettingsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.clearAllSettingsToolStripMenuItem.Text = "Clear All Path Settings";
            this.clearAllSettingsToolStripMenuItem.ToolTipText = "Clears all set paths";
            this.clearAllSettingsToolStripMenuItem.Visible = false;
            // 
            // helpfulLinksToolStripMenuItem
            // 
            this.helpfulLinksToolStripMenuItem.Name = "helpfulLinksToolStripMenuItem";
            this.helpfulLinksToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.helpfulLinksToolStripMenuItem.Text = "Helpful Links";
            this.helpfulLinksToolStripMenuItem.Click += new System.EventHandler(this.helpfulLinksToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 606);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(585, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unpacked Game Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType,
            this.columnDate,
            this.columnSize});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(4, 27);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 552);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 275;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date Modified";
            this.columnDate.Width = 150;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnHomeToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.copyToProjectPathToolStripMenuItem,
            this.recompileToolStripMenuItem,
            this.packModToolStripMenuItem,
            this.createNewFolderToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.openInFileExplorerToolStripMenuItem,
            this.editProjectSettingsToolStripMenuItem,
            this.copyToModsFolderToolStripMenuItem,
            this.openModsFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 246);
            // 
            // returnHomeToolStripMenuItem
            // 
            this.returnHomeToolStripMenuItem.Name = "returnHomeToolStripMenuItem";
            this.returnHomeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.returnHomeToolStripMenuItem.Text = "Return Home";
            this.returnHomeToolStripMenuItem.Click += new System.EventHandler(this.returnHomeToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // copyToProjectPathToolStripMenuItem
            // 
            this.copyToProjectPathToolStripMenuItem.Name = "copyToProjectPathToolStripMenuItem";
            this.copyToProjectPathToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.copyToProjectPathToolStripMenuItem.Text = "Copy to Project Path";
            this.copyToProjectPathToolStripMenuItem.ToolTipText = "Copy Directory/File to Chosen Project Directory With Folder Structure";
            this.copyToProjectPathToolStripMenuItem.Visible = false;
            this.copyToProjectPathToolStripMenuItem.Click += new System.EventHandler(this.copyToProjectPathToolStripMenuItem_Click);
            // 
            // recompileToolStripMenuItem
            // 
            this.recompileToolStripMenuItem.Name = "recompileToolStripMenuItem";
            this.recompileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.recompileToolStripMenuItem.Text = "Recompile";
            this.recompileToolStripMenuItem.Visible = false;
            this.recompileToolStripMenuItem.Click += new System.EventHandler(this.recompileToolStripMenuItem_Click);
            // 
            // packModToolStripMenuItem
            // 
            this.packModToolStripMenuItem.Name = "packModToolStripMenuItem";
            this.packModToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.packModToolStripMenuItem.Text = "Pack Mod";
            this.packModToolStripMenuItem.ToolTipText = "Pack Contents of Current Directory Into .pak File";
            this.packModToolStripMenuItem.Visible = false;
            this.packModToolStripMenuItem.Click += new System.EventHandler(this.packModToolStripMenuItem_Click);
            // 
            // createNewFolderToolStripMenuItem
            // 
            this.createNewFolderToolStripMenuItem.Name = "createNewFolderToolStripMenuItem";
            this.createNewFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.createNewFolderToolStripMenuItem.Text = "Create New Folder";
            this.createNewFolderToolStripMenuItem.Click += new System.EventHandler(this.createNewFolderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openInFileExplorerToolStripMenuItem
            // 
            this.openInFileExplorerToolStripMenuItem.Name = "openInFileExplorerToolStripMenuItem";
            this.openInFileExplorerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openInFileExplorerToolStripMenuItem.Text = "Open In File Explorer";
            this.openInFileExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInFileExplorerToolStripMenuItem_Click);
            // 
            // editProjectSettingsToolStripMenuItem
            // 
            this.editProjectSettingsToolStripMenuItem.Name = "editProjectSettingsToolStripMenuItem";
            this.editProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editProjectSettingsToolStripMenuItem.Text = "Edit Project";
            this.editProjectSettingsToolStripMenuItem.Click += new System.EventHandler(this.editProjectSettingsToolStripMenuItem_Click);
            // 
            // copyToModsFolderToolStripMenuItem
            // 
            this.copyToModsFolderToolStripMenuItem.Name = "copyToModsFolderToolStripMenuItem";
            this.copyToModsFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.copyToModsFolderToolStripMenuItem.Text = "Copy To Mods Folder";
            this.copyToModsFolderToolStripMenuItem.ToolTipText = "Copy pak file to PCBANKS/MODS";
            this.copyToModsFolderToolStripMenuItem.Click += new System.EventHandler(this.copyToModsFolderToolStripMenuItem_Click);
            // 
            // openModsFolderToolStripMenuItem
            // 
            this.openModsFolderToolStripMenuItem.Name = "openModsFolderToolStripMenuItem";
            this.openModsFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openModsFolderToolStripMenuItem.Text = "Open Mods Folder";
            this.openModsFolderToolStripMenuItem.ToolTipText = "Open PCBANKS/MODS in File Explorer";
            this.openModsFolderToolStripMenuItem.Click += new System.EventHandler(this.openModsFolderToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_16.png");
            this.imageList1.Images.SetKeyName(1, "mbin_16.png");
            this.imageList1.Images.SetKeyName(2, "xml_16.png");
            this.imageList1.Images.SetKeyName(3, "default_16.gif");
            this.imageList1.Images.SetKeyName(4, "back_16.png");
            this.imageList1.Images.SetKeyName(5, "pak_16.png");
            this.imageList1.Images.SetKeyName(6, "settings_16.png");
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(4, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(581, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(585, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Your Project";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.FullRowSelect = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(4, 27);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(581, 552);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 275;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date Modified";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Size";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(4, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(581, 20);
            this.textBox2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(75, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 652);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NMS Mod Station";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPAKPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMBINCompilerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem setPathToYourModProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllSettingsToolStripMenuItem;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToProjectPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpfulLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recompileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCurrentProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpackGameFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInFileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem editCurrentProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToModsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathToPCBANKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

