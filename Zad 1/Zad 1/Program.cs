using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Cherry");
            foreach (var item in stack) 
                stack.Pop();
        }
    }
}
