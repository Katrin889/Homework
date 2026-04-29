using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static int N_numIntr(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            int pre2 = 1;
            int pre1 = 2;
            int curent = 0;
            for (int i = 3; i <= n; i++)
            {
                curent = 3 * pre1 - pre2;
                pre2 = pre1;
                pre1 = curent;
            }
            return curent;
        }
        static int N_num(int n)
        {
            if (n > 2)
            {
                return 3 * N_num(n - 1) - N_num(n - 2);
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter num for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Resut interative: " + N_numIntr(n));
            Console.WriteLine("Result recursion: " + N_num(n));
        }
    }
}
