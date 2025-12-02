using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace produkti
{
    internal class Program
    {
        static void Main()
        {
            ArrayList products = new ArrayList { "Peper", "Tomatos", 2.20, 5, 2, 1.5, 3.40, "Eggplant", 100 };
            List<string> name = new List<string>();
            List<int> koli = new List<int>();
            List<double> price = new List<double>();
            foreach (var i in products)
            {
                    if (i is string)
                        name.Add(i.ToString());
                    if (i is int)
                        koli.Add(int.Parse(i.ToString()));
                    if (i is double)
                        price.Add(double.Parse(i.ToString()));
            }
            Console.WriteLine($"{"Products",1} |{"Quantity",15} |{"Price per product",25} |{"Price",19}");
            double smetka = 0;
            for (int i = 0; i < name.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{name[i],1} ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{koli[i],13} ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{price[i],20}lv. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{(koli[i] * (double)price[i]), 27}lv.");
                smetka += (koli[i] * (double)price[i]);
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{" ",64} Bill: {smetka}");
        }
    }
}
