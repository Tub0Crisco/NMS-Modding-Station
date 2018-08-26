namespace NMSModdingStation
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modAuthorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modNameBox = new System.Windows.Forms.TextBox();
            this.versionCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.versionBox1 = new System.Windows.Forms.NumericUpDown();
            this.versionBox2 = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.versionBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(125, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mod Author";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modAuthorBox
            // 
            this.modAuthorBox.Location = new System.Drawing.Point(101, 13);
            this.modAuthorBox.Name = "modAuthorBox";
            this.modAuthorBox.Size = new System.Drawing.Size(143, 22);
            this.modAuthorBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mod Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modNameBox
            // 
            this.modNameBox.Location = new System.Drawing.Point(101, 58);
            this.modNameBox.Name = "modNameBox";
            this.modNameBox.Size = new System.Drawing.Size(143, 22);
            this.modNameBox.TabIndex = 5;
            // 
            // versionCheckBox
            // 
            this.versionCheckBox.AutoSize = true;
            this.versionCheckBox.Location = new System.Drawing.Point(270, 15);
            this.versionCheckBox.Name = "versionCheckBox";
            this.versionCheckBox.Size = new System.Drawing.Size(127, 21);
            this.versionCheckBox.TabIndex = 7;
            this.versionCheckBox.Text = "Version Control";
            this.toolTip1.SetToolTip(this.versionCheckBox, "Check this box to increment version number automatically \r\nwhen packing the mod. " +
        "This will also include the version\r\nnumber in the pak filename.");
            this.versionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = ".";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // versionBox1
            // 
            this.versionBox1.Location = new System.Drawing.Point(330, 61);
            this.versionBox1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.versionBox1.Name = "versionBox1";
            this.versionBox1.Size = new System.Drawing.Size(43, 22);
            this.versionBox1.TabIndex = 11;
            // 
            // versionBox2
            // 
            this.versionBox2.Location = new System.Drawing.Point(398, 61);
            this.versionBox2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.versionBox2.Name = "versionBox2";
            this.versionBox2.Size = new System.Drawing.Size(43, 22);
            this.versionBox2.TabIndex = 12;
            this.versionBox2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form6
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(511, 164);
            this.Controls.Add(this.versionBox2);
            this.Controls.Add(this.versionBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionCheckBox);
            this.Controls.Add(this.modNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modAuthorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Project Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.versionBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modAuthorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modNameBox;
        private System.Windows.Forms.CheckBox versionCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown versionBox1;
        private System.Windows.Forms.NumericUpDown versionBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}