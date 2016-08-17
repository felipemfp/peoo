using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    struct disciplina
    {
        public int semestre;
        public double media;
        public string nome, situacao;
    }
    class Program
    {
        static void Main(string[] args)
        {
            disciplina[] v = new disciplina[5];
            double maior = 0, menor = 101, media2 = 0, nAprov = 0;
            int M=-1, m=-1;
            Console.Write("\tInsira os dados:\n");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Nome da disciplina?");
                v[i].nome = Console.ReadLine();
                Console.WriteLine("Semestre?");
                v[i].semestre = int.Parse(Console.ReadLine());
                Console.WriteLine("Média? (0~100)");
                v[i].media = double.Parse(Console.ReadLine());
                if (v[i].media>59) 
                    v[i].situacao="Aprovado";
                else
                    v[i].situacao="Reprovado";
                Console.WriteLine("");
            }
            Console.Clear();
            Console.WriteLine("\tLista de disciplinas:");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(v[i].nome);
            }
            for (int i = 0; i < 50; i++)
            {
                if (v[i].media >= maior)
                {
                    maior = v[i].media;
                    M = i;
                }
                if (v[i].media <= maior)
                {
                    menor = v[i].media;
                    m = i;
                }
                if (v[i].situacao == "Aprovado")
                {
                    media2 += v[i].media;
                    nAprov++;
                }
            }
            Console.WriteLine("\n\tA disciplina com maior média é: "+v[M].nome+"\n\tE com a menor: "+v[m].nome);
            Console.WriteLine("\n\tA média das médias é: "+(media2/nAprov));
            Console.ReadKey();
        }
    }
}
