using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int ind=0, d = 0; 
            Console.WriteLine("preencha seu vetor : ");
            for (int i = 0; i < 20; i++)
            {
                v[i] = int.Parse(Console.ReadLine()); 
                if (i!=0) 
                {
                    if ((v[i]-v[(i-1)]>d))
                    {
                        ind=i; 
                    }
                }
            }
            Console.WriteLine("A maior diferença entre dois números consecultivos foi: " + ((v[ind] - v[(ind - 1)])) + " com os índices " + ind + " e " + (ind - 1)); 
        }
    }
}
