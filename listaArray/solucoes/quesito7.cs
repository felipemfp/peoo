using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int maior = 0, menor = 0, ima=0, ime=0;
            Console.WriteLine("Digite os números desejado apertando enter entre eles: ");
            for (int i = 0; i < 10; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = v[0];
                    menor = v[0];
                }
                 else if(v[i] > maior)
                {
                    maior = v[i];
                    ima = i;
                }
                 else if (v[i] < menor)
                {
                    menor = v[i];
                    ime = i;
                }
            }
            Console.WriteLine("O maior elemento do vetor foi " + maior + ". Este número tem o índice "+ima+" \n O menor foi " + menor+". Este número etem o índice "+ime); 
        }
    }
}
