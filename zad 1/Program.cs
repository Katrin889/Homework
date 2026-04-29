using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    
    internal class Program
    {
        static List<int> elements = new List<int>();
        static void FillList(int n)
        {
            if (n > 1) FillList(n - 1);
            Console.Write("Enter num for element " + n + ": ");
            elements.Add(int.Parse(Console.ReadLine()));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n for elements: ");
            int n = int.Parse(Console.ReadLine());
            FillList(n);
            Console.WriteLine(string.Join(">> ", elements));
        }
    }
}
