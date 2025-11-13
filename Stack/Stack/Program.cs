using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many words do you want to enter? ");
            int n = int.Parse(Console.ReadLine());
            Stack<string> words = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". -  ");
                words.Push(Console.ReadLine());
            }
            words.TrimExcess();
            Console.Write("What word do you want to check if it's in the stack? ");
            string word1 = Console.ReadLine();
            Console.WriteLine(words.Contains(word1));
            string a = "a";
            do
            {
                Console.Write("Do you want to pop the top word? (yes/no) ");
                a = Console.ReadLine();
                if (a == "yes" || a == "no")
                    break;
            }
            while (true);
            if (a == "yes")
            {
                Console.WriteLine(words.Pop());
                Console.WriteLine($"The top word is now {words.Peek()} and there are {words.Count()} words");
            }
            else
                Console.WriteLine("The top word is " + words.Peek());
            string b = "a";
            do
            {
                Console.Write("Do you want to sort the words? (yes/no) ");
                b = Console.ReadLine();
                if (b == "yes" || b == "no")
                    break;
            }
            while (true);
            if (b == "yes")
            {
                List<string> strings = words.ToList();
                strings.Sort();
                words.Clear();
                for (int i = 0;i < strings.Count;i++) 
                    words.Push(strings[i]);
                Console.WriteLine("The word in order:");
                while (words.Count != 0)
                    Console.WriteLine(words.Pop());
            }
            else
            {
                Console.WriteLine("The words as entered:");
                while (words.Count != 0)
                    Console.WriteLine(words.Pop());
            }
        }
    }
}
