using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static int Step(int a, int n)
        {
            if (n < 1) return 1;
            return a * Step(a, n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("That's not a positive number!");
                Console.Write("Enter number again: ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter power: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 0 || n % 2 != 0)
            {
                Console.WriteLine("It need to be a positive and even number!");
                Console.Write("Enter power again: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 45));
            int result = Step(a, n);
            Console.WriteLine($"{a} to the {n} power -> {result}");
        }
    }
}
