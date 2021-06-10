using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

static class FFMpeg
{
    private static String _concatFileName = "files.txt";
    public static String ConcatFilePath { get; } = $"{Environment.CurrentDirectory}\\{_concatFileName}";
    public static String ProgramPath { get; set; } = "D:\\Game Engines\\Tools\\FFmpeg\\bin\\ffmpeg.exe";
    public static String OutputFileName { get; set; } = "Output";
    public static String OutputFileDirectory { get; set; } = $"{Environment.CurrentDirectory}";
    public static bool Loop { get; set; } = false;
    public static bool LoopInfinitely { get; set; } = true;
    public static int numLoops { get; set; } = 1;
    public static String VideoExportCommand { get; } = $"-f concat -safe 0 -i \"{ConcatFilePath}\" -c copy \"{OutputFileDirectory}\\{OutputFileName}.mp4\"";
    public static String GIFExportCommand { get; } = $"-i \"{OutputFileName}.mp4\" {(Loop ? $"-loop {(LoopInfinitely ? "0" : $"{numLoops}")}" : "")} \"{OutputFileDirectory}\\{OutputFileName}.gif\"";


    private static Process _videoExportProcess = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = $"{FFMpeg.ProgramPath}",
            Arguments = FFMpeg.VideoExportCommand
        }
    };

    private static Process _gifExportProcess = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = $"{FFMpeg.ProgramPath}",
            Arguments = FFMpeg.GIFExportCommand
        }
    };

    private static bool WriteConcatFile(String[] videoFilePaths)
    {
        try
        {
            if (videoFilePaths.Length == 0) throw new ArgumentException();
            
            using (StreamWriter sw = File.CreateText(ConcatFilePath))
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
        if (File.Exists(ConcatFilePath)) File.Delete(ConcatFilePath);
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
