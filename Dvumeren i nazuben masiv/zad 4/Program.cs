using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[3][];
            nums[0] = new int[2];
            nums[1] = new int[4];
            nums[2] = new int[1];
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write($"Number for {i}, {j}: ");
                    nums[i][j] = int.Parse(Console.ReadLine());
                }
            for (int i = 0;i < nums.Length; i++)
            {
                for (int j = 0;j < nums[i].Length; j++)
                    Console.Write(nums[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
