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
            double soma=0, i=1, j=1;
            while (i <= 50)
            {
                soma += (j / i);
                i++;
                j += 2;
            }
            Console.Write("\tSOMA: " + soma+"\n");
        }
    }
}
