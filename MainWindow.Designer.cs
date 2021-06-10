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
            this.listboxFrames = new System.Windows.Forms.ListBox();
            this.chkboxLoop = new System.Windows.Forms.CheckBox();
            this.chkboxLoopInfinitely = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxFrames
            // 
            this.listboxFrames.FormattingEnabled = true;
            this.listboxFrames.ItemHeight = 15;
            this.listboxFrames.Location = new System.Drawing.Point(13, 13);
            this.listboxFrames.Name = "listboxFrames";
            this.listboxFrames.Size = new System.Drawing.Size(157, 94);
            this.listboxFrames.TabIndex = 0;
            // 
            // chkboxLoop
            // 
            this.chkboxLoop.AutoSize = true;
            this.chkboxLoop.Location = new System.Drawing.Point(176, 38);
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
            this.chkboxLoopInfinitely.Location = new System.Drawing.Point(176, 63);
            this.chkboxLoopInfinitely.Name = "chkboxLoopInfinitely";
            this.chkboxLoopInfinitely.Size = new System.Drawing.Size(102, 19);
            this.chkboxLoopInfinitely.TabIndex = 2;
            this.chkboxLoopInfinitely.Text = "Loop Infinitely";
            this.chkboxLoopInfinitely.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(217, 126);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 114);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 4;
            this.btnAddFile.Text = "Add File(s)";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(95, 114);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
            this.btnAddFolder.TabIndex = 5;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chkboxLoopInfinitely);
            this.Controls.Add(this.chkboxLoop);
            this.Controls.Add(this.listboxFrames);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 200);
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "MainWindow";
            this.Text = "GIF Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxFrames;
        private System.Windows.Forms.CheckBox chkboxLoop;
        private System.Windows.Forms.CheckBox chkboxLoopInfinitely;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnAddFolder;
    }
}

