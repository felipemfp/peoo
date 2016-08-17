using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        struct dados
        {
            public string nComponente;
            public double pComponente;
        }
        static void Main(string[] args)
        {
            dados[] v = new dados[3];
            double pTotal=0;
            Console.Write("\tComece a lista: \n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\nCOMPONENTE nº"+(i+1));
                Console.Write("\n\tNome? ");
                v[i].nComponente = Console.ReadLine();
                Console.Write("\tPreço? ");
                v[i].pComponente = double.Parse(Console.ReadLine());
                pTotal += v[i].pComponente;
            }
            Console.Clear();
            Console.Write("\t\t\tEsta é sua lista:\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(v[i].nComponente+" (R$ "+v[i].pComponente+")");
            }
            Console.WriteLine("\nPreço total: R$ " + pTotal);
        }
    }
}
