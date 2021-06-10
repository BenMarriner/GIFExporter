namespace GIFExporter
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listboxFrames = new System.Windows.Forms.ListBox();
            this.chkboxLoop = new System.Windows.Forms.CheckBox();
            this.chkboxLoopInfinitely = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lblFrames = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtboxLoopCount = new System.Windows.Forms.TextBox();
            this.lblLoopCount = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.txtboxOutputName = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxFrames
            // 
            this.listboxFrames.FormattingEnabled = true;
            this.listboxFrames.ItemHeight = 15;
            this.listboxFrames.Location = new System.Drawing.Point(12, 43);
            this.listboxFrames.Name = "listboxFrames";
            this.listboxFrames.Size = new System.Drawing.Size(300, 364);
            this.listboxFrames.TabIndex = 0;
            this.listboxFrames.SelectedIndexChanged += new System.EventHandler(this.listboxFrames_SelectedIndexChanged);
            // 
            // chkboxLoop
            // 
            this.chkboxLoop.AutoSize = true;
            this.chkboxLoop.Location = new System.Drawing.Point(319, 98);
            this.chkboxLoop.Name = "chkboxLoop";
            this.chkboxLoop.Size = new System.Drawing.Size(53, 19);
            this.chkboxLoop.TabIndex = 1;
            this.chkboxLoop.Text = "Loop";
            this.chkboxLoop.UseVisualStyleBackColor = true;
            this.chkboxLoop.CheckedChanged += new System.EventHandler(this.chkboxLoop_CheckedChanged);
            // 
            // chkboxLoopInfinitely
            // 
            this.chkboxLoopInfinitely.AutoSize = true;
            this.chkboxLoopInfinitely.Location = new System.Drawing.Point(319, 123);
            this.chkboxLoopInfinitely.Name = "chkboxLoopInfinitely";
            this.chkboxLoopInfinitely.Size = new System.Drawing.Size(102, 19);
            this.chkboxLoopInfinitely.TabIndex = 2;
            this.chkboxLoopInfinitely.Text = "Loop Infinitely";
            this.chkboxLoopInfinitely.UseVisualStyleBackColor = true;
            this.chkboxLoopInfinitely.CheckedChanged += new System.EventHandler(this.chkboxLoopInfinitely_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Location = new System.Drawing.Point(495, 383);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 66);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(12, 413);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 4;
            this.btnAddFile.Text = "Add File(s)";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(12, 25);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(45, 15);
            this.lblFrames.TabIndex = 6;
            this.lblFrames.Text = "Frames";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(237, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtboxLoopCount
            // 
            this.txtboxLoopCount.Location = new System.Drawing.Point(319, 176);
            this.txtboxLoopCount.Name = "txtboxLoopCount";
            this.txtboxLoopCount.Size = new System.Drawing.Size(100, 23);
            this.txtboxLoopCount.TabIndex = 8;
            // 
            // lblLoopCount
            // 
            this.lblLoopCount.AutoSize = true;
            this.lblLoopCount.Location = new System.Drawing.Point(319, 158);
            this.lblLoopCount.Name = "lblLoopCount";
            this.lblLoopCount.Size = new System.Drawing.Size(100, 15);
            this.lblLoopCount.TabIndex = 9;
            this.lblLoopCount.Text = "Number of Loops";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(624, 25);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripFile.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.Location = new System.Drawing.Point(319, 43);
            this.lblOutputName.Name = "lblOutputName";
            this.lblOutputName.Size = new System.Drawing.Size(39, 15);
            this.lblOutputName.TabIndex = 11;
            this.lblOutputName.Text = "Name";
            // 
            // txtboxOutputName
            // 
            this.txtboxOutputName.Location = new System.Drawing.Point(318, 61);
            this.txtboxOutputName.Name = "txtboxOutputName";
            this.txtboxOutputName.Size = new System.Drawing.Size(100, 23);
            this.txtboxOutputName.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.txtboxOutputName);
            this.Controls.Add(this.lblOutputName);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lblLoopCount);
            this.Controls.Add(this.txtboxLoopCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFrames);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chkboxLoopInfinitely);
            this.Controls.Add(this.chkboxLoop);
            this.Controls.Add(this.listboxFrames);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GIF Exporter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxFrames;
        private System.Windows.Forms.CheckBox chkboxLoop;
        private System.Windows.Forms.CheckBox chkboxLoopInfinitely;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtboxLoopCount;
        private System.Windows.Forms.Label lblLoopCount;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblOutputName;
        private System.Windows.Forms.TextBox txtboxOutputName;
    }
}

