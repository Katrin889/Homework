using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first niz S1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second niz S2: ");
            string s2 = Console.ReadLine();
            int br = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[0])
                {
                    bool ans = true;
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (s1[i] != s2[j])
                        {
                            ans = false;
                            break;
                        }
                        if (i != s1.Length - 1)
                            i++;
                    }
                    if (ans == true)
                        br++;
                    i--;
                }
            }
            Console.WriteLine($"Niz S2 repeats {br} in S1");
        }
    }
}
