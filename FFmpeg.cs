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
        public static String VideoExportArguments { get; } = $"-y -f concat -safe 0 -i \"{_concatFilePath}\" -c copy \"{Configuration.OutputFileDirectory}\\{Configuration.OutputFileName}.mp4\"";
        public static String GIFExportArguments { get; } = $"-y -i \"{Configuration.OutputFileDirectory}\\{Configuration.OutputFileName}.mp4\" \"{Configuration.OutputFileDirectory}\\{Configuration.OutputFileName}.gif\" {(Configuration.Loop ? $"-loop {(Configuration.LoopInfinitely ? "0" : $"{Configuration.NumLoops}")}" : "")}";

        private static Process _videoExportProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = $"{Configuration.ProgramPath}",
                Arguments = FFMpeg.VideoExportArguments
            }
        };

        private static Process _gifExportProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = $"{Configuration.ProgramPath}",
                Arguments = FFMpeg.GIFExportArguments
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
            catch (FileNotFoundException)
            {
                GIFExporterException.ShowMessageBox("A file in the list could not be accessed or found. Please check the list and try again.", "Export Error");
                return false;
            }
        }

        private static void DeleteConcatFile()
        {
            if (File.Exists(_concatFilePath)) File.Delete(_concatFilePath);
        }

        public static bool BeginExport(String[] videoFilePaths)
        {
            try
            {
                if (videoFilePaths.Length == 0) throw new EmptyVideoFilesListException("The list of video files is empty. Please click Add File(s) to add videos");
                if (Configuration.OutputFileName == "") throw new InvalidOutputFileNameException("Please enter a name for your GIF and try again");
                if (Configuration.OutputFileDirectory == "") throw new InvalidDirectoryException("Please specify the output directory to export your GIF to in Preferences and try again");
                if (Configuration.ProgramPath == "") throw new InvalidFFMpegExecutableException("Please specify the location of your ffmpeg.exe file");
                
                if (!Directory.Exists(Configuration.OutputFileDirectory)) throw new InvalidDirectoryException("GIF Exporter could not find your output directory. Please change the location in Preferences.");
                if (!File.Exists(Configuration.ProgramPath)) throw new InvalidFFMpegExecutableException("GIF Exporter could not find ffmpeg.exe. Please change the location of the file in Preferences.");

                WriteConcatFile(videoFilePaths);
                _videoExportProcess.Start();
                _videoExportProcess.WaitForExit();
                _gifExportProcess.Start();
                _gifExportProcess.WaitForExit();
                DeleteConcatFile();

                return true;
            }
            catch (EmptyVideoFilesListException)
            {
                return false;
            }
            catch (InvalidOutputFileNameException)
            {
                return false;
            }
            catch (InvalidDirectoryException)
            {
                return false;
            }
            catch (InvalidFFMpegExecutableException)
            {
                return false;
            }
        }
    }
}