using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    internal class Program
    {
        static int GeoProg(int N)
        {
            if (N <= 1) return 2;
            else
            {
                return GeoProg(N - 1) * 3;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wywedi do koj element shte stiga geometrichnata progresiq:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Elementite v progresiqta: ");
            for (int i = 1; i <= n; i++) 
                 Console.Write(GeoProg(i) + " ");
        }
    }
}
