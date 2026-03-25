namespace FacultyListCreator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deansNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abbreviationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtDean = new System.Windows.Forms.TextBox();
            this.txtAbbrev = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editWindowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editWindowsToolStripMenuItem
            // 
            this.editWindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultyToolStripMenuItem,
            this.deansNameToolStripMenuItem,
            this.abbreviationToolStripMenuItem});
            this.editWindowsToolStripMenuItem.Name = "editWindowsToolStripMenuItem";
            this.editWindowsToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.editWindowsToolStripMenuItem.Text = "Edit Windows";
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facultyToolStripMenuItem.Text = "Faculty";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // deansNameToolStripMenuItem
            // 
            this.deansNameToolStripMenuItem.Name = "deansNameToolStripMenuItem";
            this.deansNameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deansNameToolStripMenuItem.Text = "Dean\'s Name";
            this.deansNameToolStripMenuItem.Click += new System.EventHandler(this.deansNameToolStripMenuItem_Click);
            // 
            // abbreviationToolStripMenuItem
            // 
            this.abbreviationToolStripMenuItem.Name = "abbreviationToolStripMenuItem";
            this.abbreviationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abbreviationToolStripMenuItem.Text = "Abbreviation";
            this.abbreviationToolStripMenuItem.Click += new System.EventHandler(this.abbreviationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faculty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dean\'s Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Abbreviation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Output file name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(149, 64);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.ReadOnly = true;
            this.txtFaculty.Size = new System.Drawing.Size(155, 22);
            this.txtFaculty.TabIndex = 5;
            // 
            // txtDean
            // 
            this.txtDean.Location = new System.Drawing.Point(149, 104);
            this.txtDean.Name = "txtDean";
            this.txtDean.ReadOnly = true;
            this.txtDean.Size = new System.Drawing.Size(155, 22);
            this.txtDean.TabIndex = 6;
            // 
            // txtAbbrev
            // 
            this.txtAbbrev.Location = new System.Drawing.Point(149, 143);
            this.txtAbbrev.Name = "txtAbbrev";
            this.txtAbbrev.ReadOnly = true;
            this.txtAbbrev.Size = new System.Drawing.Size(155, 22);
            this.txtAbbrev.TabIndex = 7;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(231, 233);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 22);
            this.txtFileName.TabIndex = 8;
            this.txtFileName.Text = "TSU.txt";
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(24, 231);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(148, 23);
            this.btnAppend.TabIndex = 9;
            this.btnAppend.Text = "Append to File";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 267);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtAbbrev);
            this.Controls.Add(this.txtDean);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Faculty List Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deansNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abbreviationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtDean;
        private System.Windows.Forms.TextBox txtAbbrev;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnAppend;
    }
}

