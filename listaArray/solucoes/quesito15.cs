using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5];
            int[] a2 = new int[5];
            int x=0,aux; 
            Console.WriteLine("preencha seu vetor a1: ");
            for (int i = 0; i < 5; i++)
            {
                a1[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("\n \n \n preencha seu vetor a2: "); 
            for (int i = 0; i < 5; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        x++;
                    }
                }
            }
            int[] a3 = new int[x];
            int y=0; 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        a3[y] = a2[j];
                        y++; 
                    }
                }
            }
            Console.WriteLine("Os números repetidos nos dois vetores foram: "); 
            for (int i = 0; i <x; i++)
            {
                Console.Write(" " + a3[i] + " "); 
            }
        }
    }
}
