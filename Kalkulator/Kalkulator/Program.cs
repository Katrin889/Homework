using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] math = Console.ReadLine().Split(' ').ToArray();
            Stack<string> math2 = new Stack<string>(math.Reverse());
            int ans = int.Parse(math2.Pop());
            string a;
            while (math2.Count > 0)
            {
                string b = math2.Pop();
                switch(b)
                {
                    case ("+"):
                        {
                            a = math2.Pop();
                            ans += int.Parse(a);
                            break;
                        }
                    case ("-"):
                        {
                            a = math2.Pop();
                            ans -= int.Parse(a); 
                            break;
                        }
                    default:
                        Console.WriteLine("Not a simple math equation"); break;
                }
            }
            Console.WriteLine("The answer is " + ans);
        }
    }
}
