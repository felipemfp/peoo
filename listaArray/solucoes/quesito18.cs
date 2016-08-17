using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int aux = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número.");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            Console.WriteLine("Ordem Crescente.");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(" " + vetor[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
