using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadQueue
{
    public class DownloadManager
    {
        private readonly Queue<File> _files;
        public DownloadManager()
        {
            _files = new Queue<File>();
        }

        public void EnqueueFile(File file)
        {
            _files.Enqueue(file);
        }

        private File DequeueFile()
        {
            return _files.Dequeue();
        }

        public void DownloadFiles()
        {
            while (_files.Count > 0)
            {
                var file = DequeueFile();
                Thread.Sleep(file.DownloadTime * 1000);
                file.DownloadFile();
            }
           
            Console.WriteLine("There is no files to download");
           
        }
    }
}
