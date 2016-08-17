using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, z = 1;
            while (z != 0)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    z = 0;
                }
                catch (FormatException erro)
                {
                    Console.WriteLine("Insira um número inteiro!");
                    Console.WriteLine(erro.Message);                    
                }
            }
        }
    }
}
