using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvumeren_i_nazuben_masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
              {1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum += matrix[i, j];
                Console.WriteLine($"The sum of row {i} is {sum}");
            }
        }
    }
}
