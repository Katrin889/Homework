using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static long Pnum(int n)
        {
            if (n == 1) return 1;
            else return n * Pnum(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {Pnum(n)}");
        }
    }
}
