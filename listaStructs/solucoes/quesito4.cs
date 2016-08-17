using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct alunos
        {
            public string mat, nom;
            public int n1, n2, m;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tQuantos alunos tem na sala?");
            int n = int.Parse(Console.ReadLine());
            alunos[] aluno = new alunos[n];
            int Mn1=0,Mm=0,mm=0;
            Console.Clear();
            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine("\t\tDados do "+(i+1)+"º aluno\n");
                Console.WriteLine("Nome?");
                aluno[i].nom = Console.ReadLine();
                Console.WriteLine("Matricula?");
                aluno[i].mat = Console.ReadLine();
                Console.WriteLine("Nota da primeira prova?");
                aluno[i].n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Nota da segunda prova?");
                aluno[i].n2 = int.Parse(Console.ReadLine());
                aluno[i].m = (aluno[i].n1 + aluno[i].n2) / 2;
                Console.Clear();
            }
            for (int i = 0; i < aluno.Length; i++)
            {
                if (aluno[i].n1 > aluno[Mn1].n1)
                    Mn1 = i;
                if (aluno[i].m > aluno[Mm].m)
                    Mm = i;
                if (aluno[i].m < aluno[mm].m)
                    mm = i;
            }
            Console.WriteLine("\tO aluno com maior nota na primeira prova foi: "+aluno[Mn1].nom);
            Console.WriteLine("\tO aluno com maior média foi: "+aluno[Mm].nom);
            Console.WriteLine("\tO aluno com menor média foi: "+aluno[mm].nom);
        }
    }
}
