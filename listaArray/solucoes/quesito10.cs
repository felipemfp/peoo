using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];
            int[] a2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número");
                a1[i] = int.Parse(Console.ReadLine());
                a2[i] = a1[i] * a1[i];
            }
            for (int i = 0; i <10 ; i++)
            {
                Console.WriteLine("Número = " + a1[i] + "\tNúmero² = " + a2[i]);
            }
        }
    }
}
