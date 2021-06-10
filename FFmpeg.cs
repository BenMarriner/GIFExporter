using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace GIFExporter
{
    static class FFMpeg
    {
        public static Config Configuration { get; set; } = Config.LoadConfigFile();
        private static String _concatFileName = "files.txt";
        private static String _concatFilePath { get; } = $"{Path.GetTempPath()}\\{_concatFileName}";
        public static String VideoExportCommand { get; } = $"-f concat -safe 0 -i \"{_concatFilePath}\" -c copy \"{Configuration.OutputFileDirectory}\\{Configuration.OutputFileName}.mp4\"";
        public static String GIFExportCommand { get; } = $"-i \"{Configuration.OutputFileName}.mp4\" {(Configuration.Loop ? $"-loop {(Configuration.LoopInfinitely ? "0" : $"{Configuration.NumLoops}")}" : "")} \"{Configuration.OutputFileDirectory}\\{Configuration.OutputFileName}.gif\"";

        private static Process _videoExportProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = $"{Configuration.ProgramPath}",
                Arguments = FFMpeg.VideoExportCommand
            }
        };

        private static Process _gifExportProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = $"{Configuration.ProgramPath}",
                Arguments = FFMpeg.GIFExportCommand
            }
        };

        public static void SaveConfigFile()
        {
            Config.SaveConfigFile(Configuration);
        }

        private static bool WriteConcatFile(String[] videoFilePaths)
        {
            try
            {
                if (videoFilePaths.Length == 0) throw new ArgumentException();

                using (StreamWriter sw = File.CreateText(_concatFilePath))
                {
                    foreach (String filePath in videoFilePaths)
                    {
                        if (!File.Exists(filePath)) throw new FileNotFoundException();

                        sw.WriteLine($"file '{filePath}'");
                    }
                }

                return true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show
                (
                    "The list of video files is empty. Please add at least one file.",
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show
                (
                    "A file in the list could not be accessed or found. Please check the list and try again.",
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        private static void DeleteConcatFile()
        {
            if (File.Exists(_concatFilePath)) File.Delete(_concatFilePath);
        }

        public static bool BeginExport(String[] videoFilePaths)
        {
            WriteConcatFile(videoFilePaths);
            _videoExportProcess.Start();
            _videoExportProcess.WaitForExit();
            _gifExportProcess.Start();
            _gifExportProcess.WaitForExit();
            DeleteConcatFile();

            return true;
        }
    }
}