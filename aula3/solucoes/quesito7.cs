using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int uNumero;
            Console.Write("\tINSIRA O ULTIMO NUMERO DA PLACA:\n");
            uNumero = int.Parse(Console.ReadLine());
            if (uNumero == 1)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Janeiro\".\n");
            if (uNumero == 2)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Fevereiro\".\n");
            if (uNumero == 3)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Março\".\n");
            if (uNumero == 4)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Abril\".\n");
            if (uNumero == 5)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Maio\".\n");
            if (uNumero == 6)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Junho\".\n");
            if (uNumero == 7)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Julho\".\n");
            if (uNumero == 8)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Agosto\".\n");
            if (uNumero == 9)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Setembro\".\n");
            if (uNumero == 0)
                Console.Write("\tO mês do pagamento de seu IPVA é \"Outubro\".\n");
        }
    }
}
