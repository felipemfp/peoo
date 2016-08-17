using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[10];
            int a = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número do 1° Vetor");
                vetor1[i] = int.Parse(Console.ReadLine());
                vetor3[i] = vetor1[i];
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número do 2° Vetor");
                vetor2[i] = int.Parse(Console.ReadLine());
                vetor3[(5 + i)] = vetor2[i];
            }
            
            for (int x = 0; x < 10 ; x++)
            {
                Console.Write(" " + vetor3[x] + " ");
            }
        }
    }
}
