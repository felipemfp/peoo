using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        struct Q
        {
           public int num, den;
        };
        static void Main(string[] args)
        {
            Q a, b, c;
            Console.Write("\tEntre com o numerador e denominador em sequência do primeiro número:\n");
            a.num = int.Parse(Console.ReadLine());
            a.den = int.Parse(Console.ReadLine());
            Console.Write("\tEntre com o numerador e denominador em sequência do segundo número:\n");
            b.num = int.Parse(Console.ReadLine());
            b.den = int.Parse(Console.ReadLine());
            Console.Write("\tDefina a operação: \"+\"; \"-\";\"*\";\"/\";\n");
            string op = Console.ReadLine();
            if (op == "+")
            {
                if (a.den == b.den)
                {
                    c.num = a.num + b.num;
                    c.den = a.den;
                }
                else
                {
                    c.den = a.den * b.den;
                    c.num = (c.den / a.den) * a.num + (c.den / b.den) * a.num;
                }
                Console.Write("\tA soma é: "+c.num+"/"+c.den+"\n");
            }
            if (op == "-")
            {
                if (a.den == b.den)
                {
                    c.num = a.num - b.num;
                    c.den = a.den;
                }
                else
                {
                    c.den = a.den * b.den;
                    c.num = (c.den / a.den) * a.num - (c.den / b.den) * a.num;
                }
                Console.Write("\tA subtração é: " + c.num + "/" + c.den + "\n");
            }
            if (op == "*")
            {
                c.num = a.num * b.num;
                c.den = a.den * b.den;
                Console.Write("\tO produto é: "+c.num+"/"+c.den+"\n");
            }
            if (op == "/")
            {
                c.num = a.num * b.den;
                c.den = a.den * b.num;
                Console.Write("\tO quociente é: " + c.num + "/" + c.den + "\n");
            }
        }
    }
}
