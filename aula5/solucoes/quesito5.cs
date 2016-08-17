using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = new int[4, 4];
            int[,] m2 = new int[4, 4];
            int[,] m3 = new int[4, 4];
            Console.Write("\tInsira valores para 1º matriz:\n\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\tElementos da " + (i + 1) + "º linha:\n");
                for (int j = 0; j < 4; j++)
                {
                    m1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.Write("\tInsira valores para 2º matriz:\n\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\tElementos da " + (i + 1) + "º linha:\n");
                for (int j = 0; j < 4; j++)
                {
                    m2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {                
                for (int j = 0; j < 4; j++)
                {
                    m3[i, j] = m1[i,j]+m2[i,j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m3[i, j] + " | ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
