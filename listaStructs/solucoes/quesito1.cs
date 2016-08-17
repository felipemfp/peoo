using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct data
        {
            public int d, m, a;
        }
        struct dados
        {
            public string n;
            public double h, p;
            public data nsc;
        }
        static void Main(string[] args)
        {
            dados[] p = new dados[50];
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("\t\tInsira os dados da "+(i+1)+"ª pessoa:\n");
                Console.WriteLine("Nome?");
                p[i].n = Console.ReadLine();
                Console.WriteLine("Altura?");
                p[i].h = double.Parse(Console.ReadLine());
                Console.WriteLine("Peso?");
                p[i].p = double.Parse(Console.ReadLine());
                Console.WriteLine("Dia de nascimento?");
                p[i].nsc.d = int.Parse(Console.ReadLine());
                Console.WriteLine("Mês de nascimento?");
                p[i].nsc.m = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano de nascimento?");
                p[i].nsc.a = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("\t\t"+(i+1)+"ª pessoa:\n");
                Console.WriteLine("\tNome: "+p[i].n);
                Console.WriteLine("\tAltura: "+p[i].h);
                Console.WriteLine("\tPeso: "+p[i].p);
                Console.WriteLine("\tNascimento: "+p[i].nsc.d+"/"+p[i].nsc.m+"/"+p[i].nsc.a);
                Console.WriteLine("");
            }
        }
    }
}
