namespace NMSModdingStation
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.unpackedPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mbinPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectsPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pcbanksPath = new System.Windows.Forms.TextBox();
            this.unpackedReadonly = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unpackedButton = new System.Windows.Forms.Button();
            this.mbinButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.pcbanksButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pakExml = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unpacked Game Files Path";
            // 
            // unpackedPath
            // 
            this.unpackedPath.Location = new System.Drawing.Point(157, 13);
            this.unpackedPath.Name = "unpackedPath";
            this.unpackedPath.ReadOnly = true;
            this.unpackedPath.Size = new System.Drawing.Size(406, 20);
            this.unpackedPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MBINCompiler Path";
            // 
            // mbinPath
            // 
            this.mbinPath.Location = new System.Drawing.Point(157, 40);
            this.mbinPath.Name = "mbinPath";
            this.mbinPath.ReadOnly = true;
            this.mbinPath.Size = new System.Drawing.Size(406, 20);
            this.mbinPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Projects Path";
            // 
            // projectsPath
            // 
            this.projectsPath.Location = new System.Drawing.Point(157, 67);
            this.projectsPath.Name = "projectsPath";
            this.projectsPath.ReadOnly = true;
            this.projectsPath.Size = new System.Drawing.Size(406, 20);
            this.projectsPath.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PCBANKS Path";
            // 
            // pcbanksPath
            // 
            this.pcbanksPath.Location = new System.Drawing.Point(157, 94);
            this.pcbanksPath.Name = "pcbanksPath";
            this.pcbanksPath.ReadOnly = true;
            this.pcbanksPath.Size = new System.Drawing.Size(406, 20);
            this.pcbanksPath.TabIndex = 7;
            // 
            // unpackedReadonly
            // 
            this.unpackedReadonly.AutoSize = true;
            this.unpackedReadonly.Location = new System.Drawing.Point(17, 120);
            this.unpackedReadonly.Name = "unpackedReadonly";
            this.unpackedReadonly.Size = new System.Drawing.Size(236, 17);
            this.unpackedReadonly.TabIndex = 9;
            this.unpackedReadonly.Text = "Make Unpacked Game Files Tab Read Only";
            this.unpackedReadonly.UseVisualStyleBackColor = true;
            this.unpackedReadonly.CheckedChanged += new System.EventHandler(this.unpackedReadonly_CheckedChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(569, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // unpackedButton
            // 
            this.unpackedButton.Location = new System.Drawing.Point(570, 12);
            this.unpackedButton.Name = "unpackedButton";
            this.unpackedButton.Size = new System.Drawing.Size(75, 21);
            this.unpackedButton.TabIndex = 12;
            this.unpackedButton.Text = "Set";
            this.unpackedButton.UseVisualStyleBackColor = true;
            this.unpackedButton.Click += new System.EventHandler(this.unpackedButton_Click);
            // 
            // mbinButton
            // 
            this.mbinButton.Location = new System.Drawing.Point(570, 39);
            this.mbinButton.Name = "mbinButton";
            this.mbinButton.Size = new System.Drawing.Size(75, 21);
            this.mbinButton.TabIndex = 13;
            this.mbinButton.Text = "Set";
            this.mbinButton.UseVisualStyleBackColor = true;
            this.mbinButton.Click += new System.EventHandler(this.mbinButton_Click);
            // 
            // projectsButton
            // 
            this.projectsButton.Location = new System.Drawing.Point(569, 67);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Size = new System.Drawing.Size(75, 20);
            this.projectsButton.TabIndex = 14;
            this.projectsButton.Text = "Set";
            this.projectsButton.UseVisualStyleBackColor = true;
            this.projectsButton.Click += new System.EventHandler(this.projectsButton_Click);
            // 
            // pcbanksButton
            // 
            this.pcbanksButton.Location = new System.Drawing.Point(570, 94);
            this.pcbanksButton.Name = "pcbanksButton";
            this.pcbanksButton.Size = new System.Drawing.Size(75, 20);
            this.pcbanksButton.TabIndex = 15;
            this.pcbanksButton.Text = "Set";
            this.pcbanksButton.UseVisualStyleBackColor = true;
            this.pcbanksButton.Click += new System.EventHandler(this.pcbanksButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reset To Default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pakExml
            // 
            this.pakExml.AutoSize = true;
            this.pakExml.Location = new System.Drawing.Point(17, 144);
            this.pakExml.Name = "pakExml";
            this.pakExml.Size = new System.Drawing.Size(100, 17);
            this.pakExml.TabIndex = 17;
            this.pakExml.Text = "pak EXML Files";
            this.pakExml.UseVisualStyleBackColor = true;
            this.pakExml.CheckedChanged += new System.EventHandler(this.pakExml_CheckedChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(656, 227);
            this.Controls.Add(this.pakExml);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pcbanksButton);
            this.Controls.Add(this.projectsButton);
            this.Controls.Add(this.mbinButton);
            this.Controls.Add(this.unpackedButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unpackedReadonly);
            this.Controls.Add(this.pcbanksPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.projectsPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mbinPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unpackedPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox unpackedPath;
        public System.Windows.Forms.TextBox mbinPath;
        public System.Windows.Forms.TextBox projectsPath;
        public System.Windows.Forms.TextBox pcbanksPath;
        private System.Windows.Forms.Button unpackedButton;
        private System.Windows.Forms.Button mbinButton;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Button pcbanksButton;
        public System.Windows.Forms.CheckBox unpackedReadonly;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox pakExml;
    }
}