using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static int Smallest(int[] num, int index)
        {
            if (index == num.Length - 1) return num[index];
            int min = Smallest(num, index + 1);
            if (num[index] < min) return num[index];
            else return min;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("The smallest number is " + Smallest(nums, 0));
        }
    }
}
