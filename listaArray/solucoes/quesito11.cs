using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[8];
            int[] v1 = new int[8];
            int aux; 
            Console.WriteLine("Preencha a primeira matriz: ");
            for (int i = 0; i < 8; i++)
            {
                v[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("\n \n \n Preencha a segunda matriz: ");
            for (int i = 0; i < 8; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n \n \n  Ao efetuar as trocas as matrizes passarão a ser as seguintes: "); 
            for (int i = 0; i < 8; i++)
            {
                aux=v[i]; 
                v[i]=v1[i]; 
                v1[i]=aux; 
            }
           for (int i = 0; i < 8; i++)
			{
			 Console.Write(" "+v[i]+"   "+v1[i]+" \n"); 
			}
        }
    }
}
