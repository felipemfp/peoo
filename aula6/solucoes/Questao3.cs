using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct A
        {
            public int dia, mes, ano;
        };
        static void Main(string[] args)
        {
            A datas;
            string data;
            Console.WriteLine("\tInsira o dia, mes e ano - respectivamente - da data:\n[*] 0<DIA=<31\n[*] 0<MES=<12\n[**] PARA FEVEREIRO: 0<MES<=29\n[*] 0<ANO");
            datas.dia = int.Parse(Console.ReadLine());
            datas.mes = int.Parse(Console.ReadLine());
            datas.ano = int.Parse(Console.ReadLine());
            data = datas.dia + "/" + datas.mes + "/" + datas.ano;
            Console.WriteLine("\tA data é: "+data);
        }
    }
}
