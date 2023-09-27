using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskThread = System.Threading.Tasks;

namespace TaskProccess
{
    public class QueueTaskManager
    {        
        private List<Task> _TaskToProccess;
        private List<Queue<Task>> _batchTasks = new List<Queue<Task>>();
        private List<int> expirationList = new List<int>();

        public QueueTaskManager()
        {           
            _TaskToProccess = new List<Task>();
        }

        public void AddTaskToProccess(Task task) => _TaskToProccess.Add(task);
        public void AddTasksToProccess(List<Task> tasks) => _TaskToProccess.AddRange(tasks);
                       

        private void ProccessQueueThreadpool(Queue<Task> queueTasks) 
        {           
            while (queueTasks.Count > 0)
            {
                var task = queueTasks.Dequeue();
                task.State = true;
                ThreadPool.QueueUserWorkItem(task.ProccessTask);              
            }           
        }

        private void ProccessQueueWithTask(Queue<Task> queueTasks)
        {
            List<TaskThread.Task> taskThreads = new List<TaskThread.Task>();
            while (queueTasks.Count > 0)
            {
                var task = queueTasks.Dequeue();
                task.State = true;

                taskThreads.Add(System.Threading.Tasks.Task.Run(() => task.ProccessTask()));                
            }

            TaskThread.Task.WhenAll().Wait();
        }

        private void ProccessQueue(Queue<Task> queueTasks)
        {
            while (queueTasks.Count > 0)
            {
                var task = queueTasks.Dequeue();
                task.State = true;
                Thread.Sleep(task.Expiration * 1000);
                task.ProccessTask();
            }
        }

        private void BuildTaskBatch() 
        {
            expirationList = _TaskToProccess
                .GroupBy(item => new { item.Expiration })
                .Select(s => s.Key.Expiration)
                .ToList();

            // distinct
            var distintList = _TaskToProccess.Select(s => s.Expiration).Distinct().ToList();

            expirationList.ForEach(f => 
            {
                Queue<Task> queueTasks = new Queue<Task>();
                var listTasks = _TaskToProccess.Where(w => w.Expiration == f).ToList();
                listTasks.ForEach(f => 
                {
                    queueTasks.Enqueue(f);
                });
                _batchTasks.Add(queueTasks);
            });

        }

        public void ProccessTaskBatch() 
        {
            BuildTaskBatch();          

            _batchTasks.ForEach(f => 
            {
                //ProccessQueue(f);                
                //ProccessQueueThreadpool(f);                
                ProccessQueueWithTask(f);
            });

            _batchTasks = new List<Queue<Task>>();
        }

    }
}
