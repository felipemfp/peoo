using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("\tInsira os 16 números:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());                    
                }                
            }
            int M = a[0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > M)
                        M = a[i, j];
                }
            }
            int m = a[0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] < m)
                        m = a[i, j];
                }
            }
            Console.WriteLine("\tA soma do maior e menor é: "+(M+m));
        }
    }
}
