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
            int a, b, c, d, sPares=0, sImpares=0;
            Console.Write("\tInsira os quatro números:\n");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                sPares += a;
            else
                sImpares += a;
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
                sPares += b;
            else
                sImpares += b;
            c = int.Parse(Console.ReadLine());
            if (c % 2 == 0)
                sPares += c;
            else
                sImpares += c;
            d = int.Parse(Console.ReadLine());
            if (d % 2 == 0)
                sPares += d;
            else
                sImpares += d;
            Console.Write("\t\nSOMA DOS PARES: "+sPares+";\nSOMA DOS IMPARES: "+sImpares+";\n");

        }
    }
}
