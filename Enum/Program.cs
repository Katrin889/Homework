using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum TaskPriority
    {
        Low = 3,
        Medium = 2,
        High = 1
    }
    public class Task
    {
        public string Name { get; set; }   
        public TaskPriority Priority { get; set; }
        public Task(string name, TaskPriority priority)
        {
            Name = name;
            Priority = priority;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            Console.Write("How many tasks do you have? - ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Task: ");
                string task = Console.ReadLine();
                Console.Write("And what priority is the task? (1, 2 or 3) - ");
                int prio = int.Parse(Console.ReadLine());
                tasks.Add(new Task(task, (TaskPriority)prio));
            }
            tasks.FindAll(x => x.Priority == TaskPriority.High).ToList().ForEach(x => Console.WriteLine($"{x.Name} -> {x.Priority}"));
            tasks.FindAll(x => x.Priority == TaskPriority.Medium).ToList().ForEach(x => Console.WriteLine($"{x.Name} -> {x.Priority}"));
            tasks.FindAll(x => x.Priority == TaskPriority.Low).ToList().ForEach(x => Console.WriteLine($"{x.Name} -> {x.Priority}"));
        }
    }
}
