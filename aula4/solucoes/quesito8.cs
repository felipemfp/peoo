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
            int n1 = 1, n2 = 1, r = 1, j;
            Console.Write("Insira a quantidade: ");
            j = int.Parse(Console.ReadLine());
            Console.Write(n1+" ");
            for (int i=1; i < j; i++)
            {
                Console.Write(r+" ");
                n1 = n2;
                n2 = r;
                r = n1 + n2;

            }
        }
    }
}
