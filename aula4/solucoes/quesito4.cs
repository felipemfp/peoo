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
            int soma = 0;
            for (int i = 7; i <= 99; i += 2)
                soma += i;
            Console.Write("SOMA: "+soma+"\n");
        }
    }
}
