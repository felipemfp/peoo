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
            bool primo = true;
            Console.Write("\tInsira o número: \n");
            int n = int.Parse(Console.ReadLine());
            for (int i = n-1; i > 1; i--)
            {
                if (n % i == 0)
                    primo = false;
            }
            if (primo == true)
                Console.Write("Este número é primo.\n");
            else
                Console.Write("Este número não é primo.\n");
        }
    }
}
