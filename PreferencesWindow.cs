using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIFExporter
{
    public partial class PreferencesWindow : Form
    {
        public PreferencesWindow()
        {
            InitializeComponent();
        }

        private void PreferencesWindow_Load(object sender, EventArgs e)
        {
            txtboxProgramPath.Text = FFMpeg.Configuration.ProgramPath;
            txtboxOutputDirectory.Text = FFMpeg.Configuration.OutputFileDirectory;
        }

        private void btnProgramBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelect = new FolderBrowserDialog();

            if (folderSelect.ShowDialog() == DialogResult.OK)
                txtboxProgramPath.Text = folderSelect.SelectedPath;
        }

        private void btnOutputDirectoryBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelect = new FolderBrowserDialog();

            if (folderSelect.ShowDialog() == DialogResult.OK)
                txtboxOutputDirectory.Text = folderSelect.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FFMpeg.Configuration.ProgramPath = txtboxProgramPath.Text;
            FFMpeg.Configuration.OutputFileDirectory = txtboxOutputDirectory.Text;
            FFMpeg.SaveConfigFile();
            Close();
        }
    }
}
