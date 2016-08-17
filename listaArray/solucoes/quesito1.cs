using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            Console.WriteLine("Digite os números desejado apertando enter entre eles: ");
            for (int i = 0; i < 10; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
