using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nAnos, nCigarros, pCarteira;
            Console.Write("\tInsira há quantos anos você fuma:\n");
            nAnos = double.Parse(Console.ReadLine());
            Console.Write("\tInsira quantos cigarros você fuma por dia:\n");
            nCigarros = double.Parse(Console.ReadLine());
            Console.Write("\tQuanto é a carteira de cigarro?\n");
            pCarteira = double.Parse(Console.ReadLine());
            Console.Write("\n\n\tVocê gastou:" + (((nCigarros / 20) * (365*nAnos))) * pCarteira + " reais.\n");

        }
    }
}
