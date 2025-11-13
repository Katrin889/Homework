using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] nums =
            {
                new int[] {1,2, 3, 4 },
                new int[] {2,9,0 },
                new int[] {9,6,1,3,4,6,7},
                new int[] {1,2,3,4,5,6}
            };
            int max = 0;
            for (int i = 0; i < nums.Length; i++) 
                if (nums[i].Length > max)
                    max = nums[i].Length;
            Console.WriteLine($"The row with max elments has {max} elements");
        }
    }
}
