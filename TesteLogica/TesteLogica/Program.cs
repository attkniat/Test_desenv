using System;
using TesteLogica;

namespace TesteLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int respostaOpcao = 0;

            Console.WriteLine("Selecione uma das opções");
            Console.WriteLine("\n\n(0) Desenvolva um código permitindo ao usuário digitar os 3 lados de um triângulo." +
                              " Baseado nos 3 valores digitados, deverá ser exibido se o triangulo é “inválido”," +
                              " “equilátero”, “isósceles” ou “escaleno”.");

            Console.WriteLine("\n\n(1) Desenvolva uma aplicação para exibir na tela, com o uso de " +
                              "recursividade, " +"os 30 primeiros resultados da “Sequência de Fibonacci”");

            Console.WriteLine("\n\n\n");
            respostaOpcao = Int16.Parse(Console.ReadLine());

            if (respostaOpcao == 0) 
            {
                float ladoA, ladoB, ladoC;

                Console.WriteLine("Insira o lado A do possível Triângulo");
                ladoA = float.Parse(Console.ReadLine());

                Console.WriteLine("Insira o lado B do possível Triângulo");
                ladoB = float.Parse(Console.ReadLine());

                Console.WriteLine("Insira o lado C do possível Triângulo");
                ladoC = float.Parse(Console.ReadLine());

                if (ladoC > ladoA + ladoB || ladoA > ladoB + ladoC || ladoB > ladoA + ladoC)
                {
                    Console.WriteLine("Dados não formam um triângulo perfeito");
                }
                else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                {
                    Console.WriteLine("Este é um Esacleno!");
                }
                else if (ladoA == ladoB && ladoA == ladoC)
                {
                    Console.WriteLine("Este é um Equilatero!");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Este é um Isosceles!");
                }
                else
                {
                    Console.WriteLine("Inválido!");
                }

                Console.ReadLine();
            }
            else if(respostaOpcao == 1)
            {
                IFibonacci fibonacci = Factory.FactoryEngine.CreateFibonacciSequence();
                fibonacci.FibonacciEngine();
            }

            Console.ReadLine();
        }
    }
}
