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
            public int dia, mes, ano;
        }
        static void Main(string[] args)
        {
            data[] dt = new data[2];
            int qd=0, qm=0, qa=0;
            for (int i = 0; i < dt.Length; i++)
            {
                Console.WriteLine("\t\t"+(i+1)+" DATA\n");
                Console.WriteLine("Dia?");
                dt[i].dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Mes?");
                dt[i].mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano?");
                dt[i].ano = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (dt[0].ano>dt[1].ano)
                qa=(dt[0].ano-dt[1].ano)*365;
            if (dt[0].ano < dt[1].ano)
                qa = (dt[1].ano - dt[0].ano) * 365;

            if (dt[0].mes>dt[1].mes)
            {
                qm=(dt[0].mes-dt[1].mes)*30;
            }
            if (dt[0].mes>dt[1].mes)
            {
                qm = (dt[1].mes - dt[0].mes) * 30;
            }
            if (dt[0].dia>dt[1].dia)
                qd = (dt[0].dia - dt[1].dia);
            if (dt[0].dia < dt[1].dia)
                qd = (dt[1].dia - dt[0].dia);
            Console.WriteLine("\t\tQuantidade de dias: "+(qd+qm+qa));
        }
    }
}
