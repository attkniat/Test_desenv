using System;

namespace TesteLogica
{
    public class MenuDadosTrianguloCalculo : IMenuDadosTrianguloCalculo
    {
        public (float tLadoA, float tLadoB, float tLadoC) ObtemDadosTriangulo()
        {
            float ladoA, ladoB, ladoC;

            Console.WriteLine("Insira o lado A do possível Triângulo");
            ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B do possível Triângulo");
            ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado C do possível Triângulo");
            ladoC = float.Parse(Console.ReadLine());

            return (ladoA, ladoB, ladoC);
        }
    }
}
