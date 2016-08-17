using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];
            int[] a2 = new int[10];
            int[] a3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número do 1° Vetor");
                a1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número do 2° Vetor");
                a2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                a3[i] = a1[i] * a2[i];
                Console.WriteLine("Número1 = " + a1[i] + "\tNúmero2 = " + a2[i] + "\tProduto = "+a3[i]);
            }
        }
    }
}
