using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosti_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do:");
            Console.WriteLine("1 - Enter number and get all prime numbers");
            Console.WriteLine("2 - Enter numbers and get only the prime ones");
            Console.WriteLine("3 - Get every prime number till 1000");
            Console.Write("Enter number: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (k)
            {
                case 1:
                    {
                        //1 вариант на задачата - да се намерят всички прости числа до числото n
                        Console.Write("Enter a number: ");
                        int n = int.Parse(Console.ReadLine());
                        List<int> list = new List<int>();
                        for (int i = 2; i <= n; i++)
                        {
                            bool a = false;
                            for (int j = 2; j < i - 1; j++)
                                if (i % j == 0)
                                    a = true;
                            if (a == false)
                                list.Add(i);
                        }
                        Console.WriteLine(string.Join(" ", list));
                        break;
                    }
                case 2:
                    {
                        //2 вариант на задачата - да се въведе масив от числа и да се изведат само простите
                        Console.Write("Enter numbers: ");
                        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                        List<int> list2 = new List<int>();
                        for (int i = 0; i < nums.Length; i++)
                        {
                            bool b = false;
                            for (int j = 2; j < nums[i] - 1; j++)
                                if (nums[i] % j == 0)
                                    b = true;
                            if (b == false)
                                list2.Add(nums[i]);
                        }
                        Console.WriteLine(string.Join(",", list2));
                        break;
                    }
                case 3:
                    {
                        //3 вариант на задачата - да се изведат всички прости числа до 1 000
                        Console.WriteLine("Every prime number till 1000");
                        int num = 2;
                        List<int> ints = new List<int>();
                        while (num != 1000)
                        {
                            bool c = false;
                            for (int i = 2; i < num - 1; i++)
                            {
                                if (num % i == 0)
                                    c = true;
                            }
                            if (c == false)
                                ints.Add(num);
                            num++;
                        }
                        Console.WriteLine(string.Join(" ", ints));
                        break;
                    }
                default: Console.WriteLine("That wasn't an option"); break;
            }
        }
    }
}
