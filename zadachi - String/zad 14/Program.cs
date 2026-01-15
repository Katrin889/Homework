using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word you want to code (only lowercase)");
            string word = Console.ReadLine();
            while (word != word.ToLower())
            {
                Console.WriteLine("There aren't only lowercase letters!");
                Console.Write("Enter again: ");
                word = Console.ReadLine();
            }
            //ne moje da ima poveche ot 100 simvola, nqma nujda ot proverka
            string code = "";
            for (int i = 0; i < word.Length; i++)
            {
                string copy = code;
                code = code.Insert(code.Length, word[i].ToString());
                code = code.Insert(code.Length, copy);
            }
            Console.WriteLine("The word coded is " + code);
        }
    }
}
