namespace TaskProccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task> 
            {
                new Task("Process file") {Id = 1, Expiration = 4, State = false },
                new Task("Send email") {Id = 2, Expiration = 6, State = false },
                new Task("Generate report") {Id = 3, Expiration = 4, State = false },
                new Task("Export report") {Id = 4, Expiration = 3, State = false },
                new Task("Save file") {Id = 5, Expiration = 4, State = false },
                new Task("Backup files") {Id = 6, Expiration = 3, State = false },
                new Task("Execute job") {Id = 7, Expiration = 6, State = false },
            };           

            QueueTaskManager taskManager = new QueueTaskManager();
            taskManager.AddTasksToProccess(tasks);

            taskManager.ProccessTaskBatch();            

            Console.ReadLine();
        }
    }
}