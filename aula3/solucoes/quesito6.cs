using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("\tInsira os três valores:\n");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if ((a < b) && (a < c))
            {
                if (b < c)
                    Console.Write(a+"; "+b+"; "+c+".\n");
                if (b > c)
                    Console.Write(a + "; " + c + "; " + b + ".\n");
            }
            if ((b < a) && (b < c))
            {
                if (a < c)
                    Console.Write(b + "; " + a + "; " + c + ".\n");
                if (a > c)
                    Console.Write(b + "; " + c + "; " + a + ".\n");
            }
            if ((c < a) && (c < b))
            {
                if (b < a)
                    Console.Write(c + "; " + b + "; " + a + ".\n");
                if (b > a)
                    Console.Write(c + "; " + a + "; " + b + ".\n");
            }
        }
    }
}
