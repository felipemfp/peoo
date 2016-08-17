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
            int mmc, mdc, n1, n2, c=1, i;
            Console.WriteLine("Insira os dois números em sequência:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            for (; ;)
            {
                if ((c % n1 == 0) && (c % n2 == 0))
                {
                    mmc = c;
                    break;
                }
                c++;
            }
            if (n1 > n2)
                i = n1;
            else
                i = n2;
            for (; ;)
            {
                if ((n1 % i == 0) && (n2 % i == 0))
                {
                    mdc = i;
                    break;
                }
                i--;
            }
            Console.WriteLine("O MMC é: "+mmc);
            Console.WriteLine("O MDC é: "+mdc);
        }
    }
}
