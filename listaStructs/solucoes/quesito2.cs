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
            public string marca, cor;
            public int anoM, anoF;
            public double preco;
        }
        static void Main(string[] args)
        {
            dados[] p = new dados[20];
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("\t\tInsira os dados do " + (i + 1) + "º carro:\n");
                Console.WriteLine("Marca?");
                p[i].marca = Console.ReadLine();
                Console.WriteLine("Cor?");
                p[i].cor = Console.ReadLine();
                Console.WriteLine("Ano do modelo?");
                p[i].anoM = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano de fabricação?");
                p[i].anoF = int.Parse(Console.ReadLine());
                Console.WriteLine("Preço?");
                p[i].preco = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("\t\t" + (i + 1) + "º carro:\n");
                Console.WriteLine("\tMarca: " + p[i].marca);
                Console.WriteLine("\tCor: " + p[i].cor);
                Console.WriteLine("\tAno de fabricação: " + p[i].anoF);
                Console.WriteLine("\tAno do modelo: " + p[i].anoM);
                Console.WriteLine("\tPreço: R$ "+p[i].preco);
                Console.WriteLine("");
            }
        }
    }
}
