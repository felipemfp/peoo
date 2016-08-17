using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while(s.IndexOf("  ") >= 0)
                s = s.Replace("  ", " ");
            Console.WriteLine(s);
        }
    }
}
