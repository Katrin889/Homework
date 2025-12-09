using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    internal class Program
    {
        static void Left(Queue<int> queue)
        {
            int firstnum = queue.Dequeue();
            Queue<int> q = new Queue<int>(queue);
            queue.Clear();
            while (q.Count > 0)
                queue.Enqueue(q.Dequeue());
            queue.Enqueue(firstnum);
        }
        static void Right(Queue<int> queue)
        {
            Queue<int> q = new Queue<int>(queue.Take(queue.Count - 1));
            while (queue.Count > 1)
                queue.Dequeue();
            int lastnum = queue.Dequeue();
            queue.Enqueue(lastnum);
            while (q.Count > 0)
                queue.Enqueue(q.Dequeue());
        }
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter? ");
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " num: ");
                q.Enqueue(int.Parse(Console.ReadLine()));
            }
            Console.Write("Left or right rotation? (left/1 or right/2) ");
            string ans = Console.ReadLine();
            if (ans == "left" || ans == "1")
                Left(q);
            else if (ans == "right" || ans == "2")
                Right(q);
            else throw new Exception();
            while(q.Count > 0)
                Console.Write(q.Dequeue() + " ");
        }
    }
}
