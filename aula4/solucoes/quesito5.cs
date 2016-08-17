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
            int qtdPar = 0, qtdImpar = 0;
            for (int i=1; ;i++)
            {
                Console.Write("\tInsira o "+i+"º número:\n\t::Insira 0 para sair::\n");
                int j = int.Parse(Console.ReadLine());
                if (j == 0)
                    break;
                if (j % 2 == 0)
                    qtdPar++;
                else
                    qtdImpar++;
            }
            Console.WriteLine("Quantidade de pares: "+qtdPar+"\nQuantitade de impares: "+qtdImpar);
        }
    }
}
