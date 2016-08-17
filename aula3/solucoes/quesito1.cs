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
            float a, b;
            Console.Write("\tInsira os números:\n");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a == b)
                Console.Write("NUMÉROS IGUAIS;\n");
            else
            {
                if (a > b)
                    Console.Write(a + " É O MAIOR NÚMERO;\n");
                else
                    Console.Write(b + " É O MAIOR NÚMERO;\n");
            }
        }
    }
}
