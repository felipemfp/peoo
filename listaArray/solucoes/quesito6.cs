using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int maior = 0, ind = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    ind = (i);
                }
            }
            Console.WriteLine("O maior número é " + maior);
            Console.WriteLine("Seu indíce é " + (ind+1));
        }
    }
}
