using System;

namespace TesteLogica
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
