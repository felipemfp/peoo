using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quesito2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            Console.WriteLine("\tInsira dez números:");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int menor = v[0];
            for (int i = 0; i < 10; i++)
            {
                if (v[i] < menor)
                {
                    menor = v[i];

                }
            }
            int maior = v[9];
            for (int i = 0; i < 10; i++)
            {

                if (v[i] > maior)
                {
                    maior = v[i];

                }
            }
            Console.WriteLine("O maior: "+maior);
            Console.WriteLine("O menor: " + menor);

        }
    }
}
