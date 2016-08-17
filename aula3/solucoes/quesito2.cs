using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("\tInsira os números:\n");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (b == 0)
                Console.Write("\t!DIVISÃO POR ZERO!\n");
            else
                Console.Write("\t"+a+"/"+b+"="+a/b+"\n");
        }
    }
}
