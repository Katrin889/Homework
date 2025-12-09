using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Stack<int> sistem2 = new Stack<int>();
            while (num > 0)
            {
                sistem2.Push(num % 2);
                num /= 2;
            }
            while (sistem2.Count > 0)
                Console.Write(sistem2.Pop());
        }
    }
}
