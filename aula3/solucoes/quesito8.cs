using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nMes;
            Console.Write("\tInsira o número do mês:\n");
            nMes = int.Parse(Console.ReadLine());
            if ((nMes>=1)&&(nMes<=3))
                Console.Write("Este mês está incluido no primeiro trimestre;\n");
            if ((nMes >= 4) && (nMes <= 6))
                Console.Write("Este mês está incluido no segundo trimestre;\n");
            if ((nMes >= 7) && (nMes <= 9))
                Console.Write("Este mês está incluido no terceiro trimestre;\n");
            if ((nMes >= 10) && (nMes <= 12))
                Console.Write("Este mês está incluido no quarto trimestre;\n");
        }
    }
}
