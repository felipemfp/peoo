using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.Write(s[0]);
            for (int i = 0; i <s.Length; i++)
            {
                if (s[i] == ' ')
                    Console.Write(s[i + 1]);
            }
            Console.ReadKey();
        }
    }
}
