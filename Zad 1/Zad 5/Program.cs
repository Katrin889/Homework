using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    internal class Program
    {
        static void Reverse(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>(queue);
            queue.Clear();
            while (stack.Count() > 0) 
                queue.Enqueue(stack.Pop());
        }
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter? ");
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write((i+1) + " num: ");
                q.Enqueue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("The numbers in reversed order:");
            Reverse(q);
            while (q.Count() > 0)
                Console.Write(q.Dequeue() + " ");
        }
    }
}
