using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter brackets");
            string bra = Console.ReadLine();
            Stack<char> bra1 = new Stack<char>();
            Stack<char> bra2 = new Stack<char>();
            Stack<char> bra3 = new Stack<char>();
            try
            {
                foreach (char b in bra)
                {
                    if (b == '(')
                        bra1.Push(b);
                    if (b == '[')
                        bra2.Push(b);
                    if (b == '{')
                        bra3.Push(b);
                    if (b == ')')
                        bra1.Pop();
                    if (b == ']')
                        bra2.Pop();
                    if (b == '}')
                        bra3.Pop();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not enough opening brackets");
                throw new ArgumentOutOfRangeException();
            }
            if (!bra1.Any() && !bra2.Any() && !bra3.Any())
                Console.WriteLine("Correctly entered brackets");
            if (bra1.Any())
                Console.WriteLine($"Too many {bra1.Pop()} brackts!");
            if (bra2.Any())
                Console.WriteLine($"Too many {bra2.Pop()} brackts!");
            if (bra3.Any())
                Console.WriteLine($"Too many {bra3.Pop()} brackts!");
        }
    }
}
