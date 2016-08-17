using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[4, 4];
            Console.Write("\tInsira valores:\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\tElementos da "+(i+1)+"º linha:\n");
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.Clear();
            Console.Write("\tA soma da diagonal principal é: "+(m[0,0]+m[1,1]+m[2,2]+m[3,3])+".\n");
            Console.ReadKey();
        }
    }
}
