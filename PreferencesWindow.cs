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
            txtboxImportDirectory.Text = FFMpeg.Configuration.InputFileDirectory;
        }

        private void btnProgramBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog
            {
                InitialDirectory = $"{FFMpeg.Configuration.InputFileDirectory}",
                RestoreDirectory = true,

                Title = "Set the path of ffmpeg.exe",
                DefaultExt = "exe",
                Filter = "ffmpeg.exe (*.exe)|*.exe",

                CheckFileExists = true,
                CheckPathExists = true,

                Multiselect = false
            };

            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                txtboxProgramPath.Text = fileSelect.FileName;
            }
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
            FFMpeg.Configuration.InputFileDirectory = txtboxImportDirectory.Text;
            FFMpeg.SaveConfigFile();
            Close();
        }

        private void btnImportDirectoryBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelect = new FolderBrowserDialog();

            if (folderSelect.ShowDialog() == DialogResult.OK)
                txtboxImportDirectory.Text = folderSelect.SelectedPath;
        }
    }
}
