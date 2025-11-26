using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir___klasaciq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many players are there? ");
            int pl = int.Parse(Console.ReadLine());
            string[] names = new string[pl];
            Console.Write("How many games are there? ");
            int gm = int.Parse(Console.ReadLine());
            int[,] points = new int[pl, gm];
            Console.WriteLine();
            for (int i = 0; i < pl; i++)
            {
                Console.Write("What's the name of the player? ");
                names[i] = Console.ReadLine();
                for (int j = 0; j < gm; j++)
                {
                    Console.Write($"Enter poits for {j + 1} game: ");
                    points[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int win = 0;
            int id = 0;
            for (int i = 0;i < pl; i++)
            {
                int player = 0;
                for (int j = 0;j < gm; j++)
                    player += points[i, j];
                Console.WriteLine($"{names[i]} has {player} points");
                if (player > win)
                {
                    win = player;
                    id = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The winner is {names[id]} with a total of {win} points");
        }
    }
}
