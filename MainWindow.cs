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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            chkboxLoop.Checked = FFMpeg.Configuration.Loop;
            chkboxLoopInfinitely.Checked = FFMpeg.Configuration.LoopInfinitely;
            txtboxOutputName.Text = FFMpeg.Configuration.OutputFileName;
            txtboxLoopCount.Text = FFMpeg.Configuration.NumLoops.ToString();
        }

        private void chkboxLoop_CheckedChanged(object sender, EventArgs e)
        {
            FFMpeg.Configuration.Loop = chkboxLoop.Checked;
            FFMpeg.SaveConfigFile();
            chkboxLoopInfinitely.Visible = chkboxLoop.Checked;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog
            {
                InitialDirectory = $"{FFMpeg.Configuration.InputFileDirectory}",
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
            FFMpeg.SaveConfigFile();
            lblLoopCount.Visible = !chkboxLoopInfinitely.Checked;
            txtboxLoopCount.Visible = !chkboxLoopInfinitely.Checked;
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

        private void txtboxOutputName_TextChanged(object sender, EventArgs e)
        {
            FFMpeg.Configuration.OutputFileName = txtboxOutputName.Text;
            FFMpeg.SaveConfigFile();
        }

        private void txtboxLoopCount_TextChanged(object sender, EventArgs e)
        {
            FFMpeg.Configuration.NumLoops = Convert.ToInt32(txtboxLoopCount.Text);
            FFMpeg.SaveConfigFile();
        }

        private void btnMoveTop_Click(object sender, EventArgs e)
        {
            if (listboxFrames.SelectedIndex > 0)
            {
                object item = listboxFrames.SelectedItem;
                listboxFrames.Items.RemoveAt(listboxFrames.SelectedIndex);
                listboxFrames.Items.Insert(0, item);
                listboxFrames.SelectedIndex = 0;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (listboxFrames.SelectedIndex > 0)
            {
                int index = listboxFrames.SelectedIndex;
                object item = listboxFrames.SelectedItem;
                listboxFrames.Items.RemoveAt(listboxFrames.SelectedIndex);
                listboxFrames.Items.Insert(index - 1, item);
                listboxFrames.SelectedIndex = index - 1;
            }

        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (listboxFrames.SelectedIndex < listboxFrames.Items.Count - 1)
            {
                int index = listboxFrames.SelectedIndex;
                object item = listboxFrames.SelectedItem;
                listboxFrames.Items.RemoveAt(listboxFrames.SelectedIndex);
                listboxFrames.Items.Insert(index + 1, item);
                listboxFrames.SelectedIndex = index + 1;
            }
        }

        private void btnMoveBottom_Click(object sender, EventArgs e)
        {
            if (listboxFrames.SelectedIndex < listboxFrames.Items.Count - 1)
            {
                object item = listboxFrames.SelectedItem;
                listboxFrames.Items.RemoveAt(listboxFrames.SelectedIndex);
                listboxFrames.Items.Add(item);
                listboxFrames.SelectedIndex = listboxFrames.Items.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listboxFrames.SelectedIndex >= 0)
            {
                int previousIdx = listboxFrames.SelectedIndex >= 0 ? 0 : listboxFrames.SelectedIndex - 1;
                listboxFrames.Items.RemoveAt(listboxFrames.SelectedIndex);
                if (listboxFrames.Items.Count > 0) listboxFrames.SelectedIndex = previousIdx;
            }
        }
    }
}