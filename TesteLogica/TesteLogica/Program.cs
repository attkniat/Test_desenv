using System;
using TesteLogica;

namespace TesteLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenuInicialOpcoes menuInicialOpcoes = Factory.FactoryEngine.CriaMenuOpcoesIniciais();
            var respostaOpcao = menuInicialOpcoes.CriaMenuResposta();

            if (respostaOpcao == 0) 
            {
                float ladoA, ladoB, ladoC;

                Console.WriteLine("Insira o lado A do possível Triângulo");
                ladoA = float.Parse(Console.ReadLine());

                Console.WriteLine("Insira o lado B do possível Triângulo");
                ladoB = float.Parse(Console.ReadLine());

                Console.WriteLine("Insira o lado C do possível Triângulo");
                ladoC = float.Parse(Console.ReadLine());

                ITriangulo triangulo = Factory.FactoryEngine.ValidaTriangulo();
                triangulo.ValidaTriangulo(ladoA, ladoB, ladoC);

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
