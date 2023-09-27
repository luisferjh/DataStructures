using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadQueue
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int DownloadTime { get; set; }

        public void DownloadFile() 
        {
            Console.WriteLine($"Downloading {Name} file. Please wait {DownloadTime} seconds");
        }
    }
}
