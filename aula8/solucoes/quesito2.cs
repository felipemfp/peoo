using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            for (int i = (s.Length-1); i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
