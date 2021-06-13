using System;
using System.Windows.Forms;

abstract class GIFExporterException : Exception
{
	public GIFExporterException()
    {
    }

	public GIFExporterException(String message) : base(message)
	{
	}

	public GIFExporterException(String message, Exception inner) : base(message, inner)
    {
    }

	public static void ShowMessageBox(String message, String title)
	{
		MessageBox.Show
		(
			message,
			title,
			MessageBoxButtons.OK,
			MessageBoxIcon.Error
		);
	}
}

class InvalidFFMpegExecutableException : GIFExporterException
{
	public InvalidFFMpegExecutableException()
	{
		GIFExporterException.ShowMessageBox("An unknown error has occurred.", "Invalid FFMpeg Executable Path");
	}

	public InvalidFFMpegExecutableException(String message) : base(message)
	{
		GIFExporterException.ShowMessageBox(message, "Invalid FFMpeg Executable Path");

	}

	public InvalidFFMpegExecutableException(String message, Exception inner) : base(message, inner)
	{
		GIFExporterException.ShowMessageBox(message, "Invalid FFMpeg Executable Path");
	}
}

class InvalidOutputFileNameException : GIFExporterException
{
	public InvalidOutputFileNameException()
	{
		GIFExporterException.ShowMessageBox("An unknown error has occurred.", "Invalid Output File Name");
	}

	public InvalidOutputFileNameException(String message) : base(message)
	{
		GIFExporterException.ShowMessageBox(message, "Invalid Output File Name");
	}

	public InvalidOutputFileNameException(String message, Exception inner) : base(message, inner)
	{
		GIFExporterException.ShowMessageBox(message, "Invalid Output File Name");
	}
}

class InvalidDirectoryException : GIFExporterException
{
	public InvalidDirectoryException()
	{
		GIFExporterException.ShowMessageBox("An unknown error has occurred", "Invalid Directory");
	}

	public InvalidDirectoryException(String message) : base(message)
	{
		GIFExporterException.ShowMessageBox(message, "Invalid Directory");

	}

	public InvalidDirectoryException(String message, Exception inner) : base(message, inner)
	{
		GIFExporterException.ShowMessageBox(message, "Invalid Directory");

	}
}

class EmptyVideoFilesListException : GIFExporterException
{
	public EmptyVideoFilesListException()
	{
		GIFExporterException.ShowMessageBox("An unknown error has occurred", "Empty Videos List");
	}

	public EmptyVideoFilesListException(String message) : base(message)
	{
		GIFExporterException.ShowMessageBox(message, "Empty Videos List");

	}

	public EmptyVideoFilesListException(String message, Exception inner) : base(message, inner)
	{
		GIFExporterException.ShowMessageBox(message, "Empty Videos List");
	}
}

