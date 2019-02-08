using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ap, pe, soma;
            Console.Write("Insira os n primeiros números de Fibonacci: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{");
            ap = pe = 0;
            for (int i = 1; i<=n; i++)
            {
                if (i == 1 || i == 2)
                {
                    pe = ap = 1;
                    Console.Write(1);
                }
                else
                {
                    soma = pe + ap;
                    Console.Write(soma);
                    ap = pe;
                    pe = soma;
                }

                if( n!=i )
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
            Console.ReadKey();
        }
    }
}
