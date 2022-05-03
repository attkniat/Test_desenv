﻿namespace TesteLogica.Factory
{
    public class FactoryEngine
    {
        public static IFibonacci CreateFibonacciSequence()
        {
            return new Fibonacci();
        }

        public static ITriangulo ValidaTriangulo()
        {
            return new Triangulo();
        }
    }
}
