using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GIFExporter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Configure file selector properties

        }

        private void chkboxLoop_CheckedChanged(object sender, EventArgs e)
        {
            chkboxLoopInfinitely.Visible = chkboxLoop.Checked;
        }

        private void listboxFrames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                RestoreDirectory = true,

                Title = "Select files to combine into GIF:",
                DefaultExt = "mp4",
                Filter = "Video Files (*.mp4)|*.mp4",

                CheckFileExists = true,
                CheckPathExists = true,

                Multiselect = true
            };

            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in fileSelect.FileNames)
                {
                    listboxFrames.Items.Add(fileName);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            String[] videoFilePaths = new String[listboxFrames.Items.Count];

            for (int i = 0; i < videoFilePaths.Length; i++)
            {
                videoFilePaths[i] = (listboxFrames.Items[i] as String);
            }

            FFMpeg.BeginExport(videoFilePaths);
        }

        private void chkboxLoopInfinitely_CheckedChanged(object sender, EventArgs e)
        {
            FFMpeg.Configuration.LoopInfinitely = chkboxLoopInfinitely.Checked;
            lblLoopCount.Visible = !chkboxLoopInfinitely.Checked;
            txtboxLoopCount.Visible = !chkboxLoopInfinitely.Checked;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form preferencesForm = new PreferencesWindow();
            preferencesForm.Show();
        }
    }
}