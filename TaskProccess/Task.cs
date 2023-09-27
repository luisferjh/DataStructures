using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProccess
{
    public class Task
    {
        public Task(string taskDescription)
        {
            Description = taskDescription;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Expiration { get; set; }
        public bool State { get; set; }

        public void ProccessTask(object state) 
        {
            Thread.Sleep(Expiration * 1000);
            Console.WriteLine($"Executing Task number {Id} description {Description}");
        }

        public void ProccessTask()
        {           
            Console.WriteLine($"Executing Task number {Id} description {Description}");
        }
    }
}
