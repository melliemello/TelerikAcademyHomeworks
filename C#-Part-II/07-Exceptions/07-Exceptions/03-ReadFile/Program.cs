/// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
/// Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

class ReadFile
{
    static void Main(string[] args)
    {
        string readText = string.Empty;
        Console.WriteLine("Enter path to the file: ");
        string path = Console.ReadLine();

        try
        {
            readText = ReadFromFile(path);
        }
        catch (Exception ex)
        {
            if (ex is ArgumentNullException ||          // path is null. 
                ex is ArgumentException ||              // path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.
                ex is PathTooLongException ||           // The specified path, file name, or both exceed the system-defined maximum length. 
                ex is DirectoryNotFoundException ||     // The specified path is invalid (for example, it is on an unmapped drive).
                ex is FileNotFoundException ||          // The file specified in path was not found. 
                ex is NotSupportedException ||          // path is in an invalid format. 
                ex is IOException ||                    // An I/O error occurred while opening the file.
                ex is UnauthorizedAccessException ||    // read it from http://msdn.microsoft.com/en-us/library/ms143368.aspx
                ex is SecurityException)                // The caller does not have the required permission. 
            {
                Console.Error.WriteLine("Could not perform because an ERROR occurred:\n{0}", ex.Message);
            }
            else
            {
                throw;
            }
        }

        Console.WriteLine(readText);
    }

    static string ReadFromFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        return content;
    }
}
