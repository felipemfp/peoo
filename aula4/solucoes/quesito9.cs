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
            int s=0;
            for (int i = 10; i <= 100; i+=5)
            {
                if (i % 2 == 0)
                    s += i;
                else
                    s -= i;
            }
            Console.WriteLine(s);
        }
    }
}
