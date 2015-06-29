/// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
/// Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Collections.Generic;
using System.Net;

class DownFile
{
    static void Main(string[] args)
    {
        string readText = string.Empty;
        Console.WriteLine("Enter url address with the name of the file : ");
        string urlAddress = Console.ReadLine();

        Console.WriteLine("Enter the new file name/path: ");
        string name = Console.ReadLine();

        try
        {

            DownLoadFromURI(urlAddress, name);
            Console.WriteLine("Download Successful");
        }
        catch (Exception ex)
        {
            if (ex is ArgumentNullException ||          // The address parameter is null or The fileName parameter is null.  
                ex is WebException ||                   // The URI formed by combining BaseAddress and address is invalid or filename is null or Empty or The file does not exist or An error occurred while downloading data. 
                ex is NotSupportedException)          // The method has been called simultaneously on multiple threads.
            {
                Console.Error.WriteLine("Could not perform because an ERROR occurred:\n{0}", ex.Message);
            }
            else
            {
                throw;
            }
        }
    }

    static void DownLoadFromURI(string Uri, string fileName)
    {
        using (WebClient wc = new WebClient())
        {
            wc.DownloadFile(Uri, fileName);
        }
    }
}
