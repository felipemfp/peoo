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
            double b, h;
            Console.WriteLine("\tInsira a base, e logo após a altura;");
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            Console.Write("\nÁREA: " + b * h + "\nPERÍMETRO: " + (b + b + h + h) + "\nDIAGONAL:" + Math.Sqrt(((b * b) + (h * h))) + "\n");

        }
    }
}
