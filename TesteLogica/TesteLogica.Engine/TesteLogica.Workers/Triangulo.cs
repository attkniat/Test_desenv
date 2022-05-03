using System;

namespace TesteLogica
{
    public class Triangulo : ITriangulo
    {
        public void ValidaTriangulo(float ladoA, float ladoB, float ladoC)
        {
            if (ladoC > ladoA + ladoB || ladoA > ladoB + ladoC || ladoB > ladoA + ladoC)
            {
                Console.WriteLine("\nDados não formam um triângulo perfeito");
            }
            else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
            {
                Console.WriteLine("\nEste é um Esacleno!");
            }
            else if (ladoA == ladoB && ladoA == ladoC)
            {
                Console.WriteLine("\nEste é um Equilatero!");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("\nEste é um Isosceles!");
            }
            else
            {
                Console.WriteLine("\nInválido!");
            }

            Console.ReadLine();
        }
    }
}