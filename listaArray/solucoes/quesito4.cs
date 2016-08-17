using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int qt = 0; 
            Console.WriteLine("Digite os números desejado apertando enter entre eles: ");
            for (int i = 0; i < 20; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % 2 == 0) qt++; 

            }
            Console.WriteLine(qt + " números são pares. São eles: "); 
            for (int i = 0; i < 20; i++)
            {
                if (v[i] % 2 == 0) Console.Write(" " + v[i] + " ");
                else continue; 
            }
        }
    }
}
