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
            int[] x = new int[10];
            try
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = i;
                } // laço para preencher o array
                for (int i = 0; i <= x.Length; i++)
                {
                    Console.WriteLine(x[i]);
                } // laço para mostrar o array
            }
            catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine("O laço para mostrar o array vai até o índice 10.");
                Console.WriteLine(erro.Message);
            }
        }
    }
}
