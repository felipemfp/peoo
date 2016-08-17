using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fTriangulo = false;
            double a, b, c;
            Console.Write("\tInsira os três valores:\n");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if ((a < b + c) && (b < a + c) && (c < a + b))
                fTriangulo = true;
            if (fTriangulo == true)
            {
                if ((a == b) && (b == c))
                    Console.Write("FORMAM UM TRIÂNGULO EQUILÁTERO!\n");
                else
                {
                    if ((a == b) || (b == c) || (c == a))
                        Console.Write("FORMAM UM TRIÂNGULO ISÓSCELES!\n");
                    else
                        Console.Write("FORMAM UM TRIÂNGULO ESCALENO!\n");
                }
            }
            else
                Console.Write("Não formam um triângulo.\n");
        }
    }
}
