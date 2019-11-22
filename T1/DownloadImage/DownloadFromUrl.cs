using System;
using System.IO;
using System.Net;

namespace DownloadImage
{
    public class DownloadFromUrl
    {

        public DownloadFromUrl()
        {
            CurrentDirectory = Directory.GetCurrentDirectory();
        }

        public string CurrentDirectory;
        public void DownloadImg(string url, string locationPath)
        {
            var destinationPath = Path.Combine(CurrentDirectory, "DownloadImage", "../../../", locationPath);
            var client = new WebClient();
            try
            {
                client.DownloadFile(url, destinationPath);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                ((IDisposable)client)?.Dispose();
                Console.WriteLine(File.Exists(destinationPath) ? "File was downloaded" : "The file is not downloaded");
            }
        }
    }
}