using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questão20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mat = new int[10];
            int[] nota = new int[10];
            int aux = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "° matrícula");
                mat[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (mat[i] < mat[j])
                    {
                        aux = mat[i];
                        mat[i] = mat[j];
                        mat[j] = aux;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a nota da matrícula "+mat[i]);
                nota[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Matrícula " + mat[i] + "\tNota " + nota[i]);
            }
        }
    }
}
