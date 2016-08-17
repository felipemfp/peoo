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
            int n100, n50, n20, n10, n5, n2, n1, nquantia;
            Console.Write("\tInsira a quantia:\n");
            double q = double.Parse(Console.ReadLine());
            nquantia=(int) q;
            if (q > nquantia)
                nquantia += 1;
            n100 = nquantia / 100;
            nquantia = nquantia - n100 * 100;
            Console.Write(n100+" cédulas de 100.\n");
            n50 = nquantia / 50;
            nquantia = nquantia - n50 * 50;
            Console.Write(n50 + " cédulas de 50.\n");
            n20 = nquantia / 20;
            nquantia = nquantia - n20 * 20;
            Console.Write(n20 + " cédulas de 20.\n");
            n10 = nquantia / 10;
            nquantia = nquantia - n10 * 10;
            Console.Write(n10 + " cédulas de 10.\n");
            n5 = nquantia / 5;
            nquantia = nquantia - n5 * 5;
            Console.Write(n5 + " cédulas de 5.\n");
            n2 = nquantia / 2;
            nquantia = nquantia - n2 * 2;
            Console.Write(n2 + " cédulas de 2.\n");
            n1 = nquantia / 1;
            nquantia = nquantia - n1 * 1;
            Console.Write(n1 + " cédulas de 1.\n");
            
        }
    }
}
