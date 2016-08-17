using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct dados
        {
            public string nom, end, tel;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tInsira o valor de N:");
            int n = int.Parse(Console.ReadLine());
            dados[] pessoa = new dados[n], aux = new dados[1] ;
            for (int i=0; i<pessoa.Length; i++)
            {
                Console.WriteLine("\t\tDados do "+(i+1)+"º contato:\n");
                Console.WriteLine("Nome?");
                pessoa[i].nom=Console.ReadLine();
                Console.WriteLine("Endereço?");
                pessoa[i].end = Console.ReadLine();
                Console.WriteLine("Telefone?");
                pessoa[i].tel = Console.ReadLine();
                Console.Clear();
            }
            for (int i = 0; i < pessoa.Length; i++)
            {
                for (int j = 0; j < pessoa.Length; j++)
                {
                    if (pessoa[i].nom[0] < pessoa[j].nom[0])
                    {
                        aux[0] = pessoa[i];
                        pessoa[i] = pessoa[j];
                        pessoa[j] = aux[0];
                    }
                }
            }
            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.WriteLine("\tNome: "+pessoa[i].nom);
                Console.WriteLine("\tEndereço: "+pessoa[i].end);
                Console.WriteLine("\tFone: "+pessoa[i].tel);
                Console.WriteLine("");
            }
        }
    }
}
