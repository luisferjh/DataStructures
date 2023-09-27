namespace DownloadQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File
            {
                Id = 1,
                Name = "Document.pdf",
                Length = 1, // Tamaño en kilobytes
                DownloadTime = 5 // Tiempo de descarga en segundos
            };

            File file2 = new File
            {
                Id = 2,
                Name = "Image.jpg",
                Length = 2048, // Tamaño en kilobytes
                DownloadTime = 10 // Tiempo de descarga en segundos
            };

            File file3 = new File
            {
                Id = 3,
                Name = "Video.mp4",
                Length = 4, // Tamaño en kilobytes
                DownloadTime = 20 // Tiempo de descarga en segundos
            };

            File file4 = new File
            {
                Id = 4,
                Name = "Spreadsheet.xlsx",
                Length = 5, // Tamaño en kilobytes
                DownloadTime = 3 // Tiempo de descarga en segundos
            };

            DownloadManager downloadManager = new DownloadManager();

            downloadManager.EnqueueFile(file1);
            downloadManager.EnqueueFile(file2);
            downloadManager.EnqueueFile(file3);
            downloadManager.EnqueueFile(file4);

            downloadManager.DownloadFiles();
        }
    }
}