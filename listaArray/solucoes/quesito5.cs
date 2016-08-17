using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] v = new double[30];
            double qt = 0, m=0;
            Console.WriteLine("Digite as notas dos 30 alunos apertando enter entre cada uma delas: ");
            for (int i = 0; i < 30; i++)
            {
                v[i] = double.Parse(Console.ReadLine());
                m += v[i]; 
            }
            Console.WriteLine("A média da turma foi " + (m / 30)); 
            Console.WriteLine ("A notas de todos os alunos acima da média foram: ");
            Console.Write("\n \n \n ");
            for (int i = 0; i < 30; i++)
            {
                if (v[i] > (m / 30)) Console.WriteLine("Aluno " + i + " nota " + v[i]);
                else continue; 
            }
        }
    }
}
