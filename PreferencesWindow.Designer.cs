
namespace GIFExporter
{
    partial class PreferencesWindow
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
            this.txtboxProgramPath = new System.Windows.Forms.TextBox();
            this.lblProgramPath = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.txtboxOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnProgramBrowse = new System.Windows.Forms.Button();
            this.btnOutputDirectoryBrowse = new System.Windows.Forms.Button();
            this.btnImportDirectoryBrowse = new System.Windows.Forms.Button();
            this.lblImportDirectory = new System.Windows.Forms.Label();
            this.txtboxImportDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxProgramPath
            // 
            this.txtboxProgramPath.Location = new System.Drawing.Point(12, 27);
            this.txtboxProgramPath.Name = "txtboxProgramPath";
            this.txtboxProgramPath.Size = new System.Drawing.Size(229, 23);
            this.txtboxProgramPath.TabIndex = 0;
            // 
            // lblProgramPath
            // 
            this.lblProgramPath.AutoSize = true;
            this.lblProgramPath.Location = new System.Drawing.Point(12, 9);
            this.lblProgramPath.Name = "lblProgramPath";
            this.lblProgramPath.Size = new System.Drawing.Size(110, 15);
            this.lblProgramPath.TabIndex = 1;
            this.lblProgramPath.Text = "FFMpeg Executable";
            this.lblProgramPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(12, 97);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(81, 15);
            this.lblOutputDirectory.TabIndex = 3;
            this.lblOutputDirectory.Text = "Output Folder";
            this.lblOutputDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxOutputDirectory
            // 
            this.txtboxOutputDirectory.Location = new System.Drawing.Point(12, 115);
            this.txtboxOutputDirectory.Name = "txtboxOutputDirectory";
            this.txtboxOutputDirectory.Size = new System.Drawing.Size(229, 23);
            this.txtboxOutputDirectory.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnProgramBrowse
            // 
            this.btnProgramBrowse.Location = new System.Drawing.Point(252, 26);
            this.btnProgramBrowse.Name = "btnProgramBrowse";
            this.btnProgramBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnProgramBrowse.TabIndex = 5;
            this.btnProgramBrowse.Text = "Browse";
            this.btnProgramBrowse.UseVisualStyleBackColor = true;
            this.btnProgramBrowse.Click += new System.EventHandler(this.btnProgramBrowse_Click);
            // 
            // btnOutputDirectoryBrowse
            // 
            this.btnOutputDirectoryBrowse.Location = new System.Drawing.Point(252, 115);
            this.btnOutputDirectoryBrowse.Name = "btnOutputDirectoryBrowse";
            this.btnOutputDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOutputDirectoryBrowse.TabIndex = 6;
            this.btnOutputDirectoryBrowse.Text = "Browse";
            this.btnOutputDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnOutputDirectoryBrowse.Click += new System.EventHandler(this.btnOutputDirectoryBrowse_Click);
            // 
            // btnImportDirectoryBrowse
            // 
            this.btnImportDirectoryBrowse.Location = new System.Drawing.Point(252, 71);
            this.btnImportDirectoryBrowse.Name = "btnImportDirectoryBrowse";
            this.btnImportDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnImportDirectoryBrowse.TabIndex = 9;
            this.btnImportDirectoryBrowse.Text = "Browse";
            this.btnImportDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnImportDirectoryBrowse.Click += new System.EventHandler(this.btnImportDirectoryBrowse_Click);
            // 
            // lblImportDirectory
            // 
            this.lblImportDirectory.AutoSize = true;
            this.lblImportDirectory.Location = new System.Drawing.Point(12, 53);
            this.lblImportDirectory.Name = "lblImportDirectory";
            this.lblImportDirectory.Size = new System.Drawing.Size(120, 15);
            this.lblImportDirectory.TabIndex = 8;
            this.lblImportDirectory.Text = "Default Import Folder";
            this.lblImportDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxImportDirectory
            // 
            this.txtboxImportDirectory.Location = new System.Drawing.Point(12, 71);
            this.txtboxImportDirectory.Name = "txtboxImportDirectory";
            this.txtboxImportDirectory.Size = new System.Drawing.Size(229, 23);
            this.txtboxImportDirectory.TabIndex = 7;
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 195);
            this.Controls.Add(this.btnImportDirectoryBrowse);
            this.Controls.Add(this.lblImportDirectory);
            this.Controls.Add(this.txtboxImportDirectory);
            this.Controls.Add(this.btnOutputDirectoryBrowse);
            this.Controls.Add(this.btnProgramBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.txtboxOutputDirectory);
            this.Controls.Add(this.lblProgramPath);
            this.Controls.Add(this.txtboxProgramPath);
            this.Name = "PreferencesWindow";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferencesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxProgramPath;
        private System.Windows.Forms.Label lblProgramPath;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.TextBox txtboxOutputDirectory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnProgramBrowse;
        private System.Windows.Forms.Button btnOutputDirectoryBrowse;
        private System.Windows.Forms.Button btnImportDirectoryBrowse;
        private System.Windows.Forms.Label lblImportDirectory;
        private System.Windows.Forms.TextBox txtboxImportDirectory;
    }
}