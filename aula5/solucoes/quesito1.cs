using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            Console.Write("\tInsira os dez números:\n");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\tOrdem natural:\n");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.Write("\tOrdem inversa:\n");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
