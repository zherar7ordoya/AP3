using System;
using static System.Console;

namespace Eventos0
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDownloader fileDownloader = new FileDownloader("How to win a lottery");
            Reader clientA = new Reader(fileDownloader);
            fileDownloader.StartFileDownload();
            ReadKey();
        }
    }

    public class DownloadCompleteEventArgs : EventArgs
    {
        public DownloadCompleteEventArgs(string fileName) { FileName = fileName; }
        public string FileName { get; }
    }

    public class FileDownloader
    {
        private readonly string _fileName;
        public event EventHandler<DownloadCompleteEventArgs> FileDownloaded;
        public FileDownloader(string fileName) { _fileName = fileName; }
        public void StartFileDownload() { RaiseFileDownloadedEvent(new DownloadCompleteEventArgs(_fileName)); }
        protected virtual void RaiseFileDownloadedEvent(DownloadCompleteEventArgs eventArgs) { FileDownloaded?.Invoke(this, eventArgs); }
    }

    public class Reader
    {
        public Reader(FileDownloader fileDownloader) { fileDownloader.FileDownloaded += OnFileDownloaded; }
        private void OnFileDownloaded(object sender, DownloadCompleteEventArgs e) { Console.WriteLine("\nThe book '" + e.FileName + "' has been read by Reader A"); }
    }
}
