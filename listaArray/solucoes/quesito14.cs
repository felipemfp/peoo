using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];
            int dif = 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número");
                a1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (a1[i] == a1[j])
                    {
                        dif--;
                    }
                }
            }
            Console.WriteLine("Existem " + dif + " elementos diferentes.");
            
        }
    }
}
