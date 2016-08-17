using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int aux;
            Console.WriteLine("Digite os números desejado apertando enter entre eles: ");
            for (int i = 0; i < 20; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            { 
                aux=v[(19-i)];
                v[(19 - i)] = v[i];
                v[i] = aux; 
                
            }
            Console.Write("\n \n \n "); 
                for (int i = 0; i < 20; i++)
			{
                Console.WriteLine(v[i]); 
			}
        }
    }
}
