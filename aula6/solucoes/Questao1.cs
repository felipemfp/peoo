using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao1
{
    class Program
    {
        struct Estrutura {
                public double IMC, p, h;
             };
        static void Main(string[] args)
        {
            Estrutura MC;
            Console.Write("\tInsira seu peso:\n");
            MC.p = double.Parse(Console.ReadLine());
            Console.Write("\tInsira sua altura:\n");
            MC.h = double.Parse(Console.ReadLine());
            MC.IMC = MC.p / (MC.h * MC.h);
            Console.WriteLine("Seu IMC é: "+MC.IMC);
        }
    }
}
