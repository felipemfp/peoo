using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, a, b, c, delta;
            Console.Write("\t\tTome por ex.: aX² + bX + c = 0\n\n\tInsira a; b; c;\n");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            //-b+-Vb^2-4ac/2a
            x1 = ((0 - b) + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            x2 = ((0 - b) - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.Write("\tRAÍZES: "+x1+"; "+x2+".\n");
        }
    }
}
