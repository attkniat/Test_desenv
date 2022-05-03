using System;
using System.Collections.Generic;
using System.Text;
using TesteLogica;

namespace TesteLogica
{
    public class Fibonacci : IFibonacci
    {
        public void FibonacciEngine()
        {
            int tamanhoSequencia = 30;

            Console.WriteLine("\n");
            Console.WriteLine($"\n\nRESULTADO DE {tamanhoSequencia} primeiros números:");

            for (int a = 0; a <= tamanhoSequencia; a++)
            {
                Console.Write(" " + FibonacciSeq(a + 1));
            }
            Console.ReadKey();

            static int FibonacciSeq(int n)
            {
                if (n == 1 || n == 0)
                {
                    return 1;
                }
                else
                {
                    return FibonacciSeq(n - 1) + FibonacciSeq(n - 2);
                }
            }
        }
    }
}
