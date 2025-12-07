using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mat_uravnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an eqation (every sign or number has to have spase between them): ");
            List<string> ur = Console.ReadLine().Split().ToList();
            Stack<string> skob = new Stack<string>();
            int br1 = 0;
            double num = 0;
            //проверка дали уравнението е вярно (с еднакакъв брой скоби)
            for (int i = 0; i < ur.Count; i++) 
            {
                if (ur[i] == "(")
                {
                    skob.Push(ur[i]);
                    br1++;
                }
                if (ur[i] == ")")
                {
                    try
                    {
                        skob.Pop();
                    }
                    catch (Exception)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }
            }
            if (skob.Any())
                throw new ArrayTypeMismatchException();
            Console.WriteLine(new string('-', 30));
            //смятане на изразите в скобите с приоритет на умножението и делението
            for (int i = 0; i < br1; i++)
            {
                List<string> list = new List<string>();
                int br2 = 0;
                int index = ur.LastIndexOf("(");
                while (ur[index] != ")")
                {
                    if (ur[index] != ")" && ur[index] != "(")
                        list.Add(ur[index]);
                    if (ur[index] == "*" || ur[index] == "/")
                        br2++;
                    index++;
                }
                int a = ur.LastIndexOf("(");
                int range = index - a;
                ur.RemoveRange(a, range + 1);
                if (br2 != 0)
                {
                    while (br2 != 0)
                    {
                        int n = 0;
                        if (list.Contains("*"))
                        {
                            n = list.IndexOf("*") - 1;
                            num = (double.Parse(list[n])) * (double.Parse(list[n + 2]));
                        }
                        else if (list.Contains("/"))
                        {
                            n = list.IndexOf("/") - 1;
                            num = double.Parse(list[n]) / double.Parse(list[n + 2]);
                        }
                        list.RemoveRange(n, 3);
                        list.Insert(n, num.ToString());
                        br2--;
                    }
                    Queue<string> q = new Queue<string>(list);
                    while (q.Count > 0)
                    {
                        num = double.Parse(q.Dequeue());    
                        if (!q.Any())
                            break;                  
                        if (q.Peek() == "+")
                        {
                            q.Dequeue();
                            num += double.Parse(q.Dequeue());
                        }
                        else if (q.Peek() == "-")
                        {
                            q.Dequeue();
                            num -= double.Parse(q.Dequeue());
                        }
                        //else
                            //throw new ExecutionEngineException();
                    }
                }
                else
                {
                    Queue<string> q = new Queue<string>(list);
                    while (q.Count > 0)
                    {
                        num = double.Parse(q.Dequeue());
                        if (q.Peek() == "+")
                        {
                            q.Dequeue();
                            num += double.Parse(q.Dequeue());
                        }
                        else if (q.Peek() == "-")
                        {
                            q.Dequeue();
                            num -= double.Parse(q.Dequeue());
                        }
                        else
                            throw new ExecutionEngineException();
                    }

                }                
                try
                {
                    if (ur[a - 1] == "-" && num < 0)
                    {
                        ur[a - 1] = "+";
                        ur.Insert(a, Math.Abs(num).ToString());

                    }
                    else if (ur[a - 1] == "+" && num < 0)
                    {
                        ur[a - 1] = "-";
                        ur.Insert(a, Math.Abs(num).ToString());
                    }
                }
                catch (Exception) { }
                if (ur[a] != Math.Abs(num).ToString())
                     ur.Insert(a, num.ToString());               
                foreach (var item in ur)
                    Console.Write(item + " ");
                Console.WriteLine();
                list.Clear();
                //( 5 - 7 * 2 ) / 9 - ( 2 * 3 - ( 8 + 2 ) )
            }
            //решаване на уравнението след разкриване на скобите с приоритет умножение и деление
            double sum = 0;
            int br3 = 0;
            for (int i = 0; i < ur.Count; i++)
                if (ur[i] == "*" || ur[i] == "/")
                    br3++;
            if (br3 != 0)
            {
                while(br3 != 0)
                {
                    int n = 0;
                    if (ur.Contains("*"))
                    {
                        n = ur.IndexOf("*") - 1;
                        num = (double.Parse(ur[n])) * (double.Parse(ur[n + 2]));
                    }
                    if (ur.Contains("/"))
                    {
                        n = ur.IndexOf("/") - 1;
                        num = double.Parse(ur[n]) / double.Parse(ur[n + 2]);
                    }
                    ur.RemoveRange(n, 3);
                    ur.Insert(n, num.ToString());
                    br3--;
                }
                Queue<string> urav = new Queue<string>(ur);
                while (urav.Count > 0)
                {                
                    sum = double.Parse(urav.Dequeue());
                    if (!urav.Any())
                        break;
                    if (urav.Peek() == "+")
                    {
                        urav.Dequeue();
                        sum += double.Parse(urav.Dequeue());
                    }
                    else if (urav.Peek() == "-")
                    {
                        urav.Dequeue();
                        sum -= double.Parse(urav.Dequeue());
                    }
                    //else
                        //throw new ExecutionEngineException();
                }
            }
            else
            {
                Queue<string> urav = new Queue<string>(ur);
                while (urav.Count != 0)
                {
                    sum = double.Parse(urav.Dequeue());
                    if (!urav.Any())
                        break;
                    if (urav.Peek() == "+")
                    {
                        urav.Dequeue();
                        sum += double.Parse(urav.Dequeue());
                    }
                    else if (urav.Peek() == "-")
                    {
                        urav.Dequeue();
                        sum -= double.Parse(urav.Dequeue());
                    }
                    else
                        throw new ExecutionEngineException();
                }
            }
            Console.WriteLine("The answer to the equation is " + sum);
        }
    }
}
