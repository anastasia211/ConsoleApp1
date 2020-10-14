using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив: ");
            int size = 5;
            int[] mass = new int[size];
            Random n = new Random();
            for (int k = 0; k <= size - 1; k++)
            {
                mass[k] = n.Next(-100, 100);
                Console.Write(mass[k] + " ");
            }
            for (int i = 0; i <= size; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    for (int t = i; t < mass.Length - 1; t++)
                        mass[t] = mass[t + 1];
                    size--;
                    i--;
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Новый массив без четных чисел: ");
            for (int a = 0; a <= size; a++)
            {
                Console.Write(mass[a] + " ");
            }
            Console.ReadKey();
        }
    }
}
