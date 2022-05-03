using System;

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
                IMenuDadosTrianguloCalculo menuDadosTriangulo = Factory.FactoryEngine.ObtemDadosCalculoTriangulo();
                var dadosObtidosTriangulo  = menuDadosTriangulo.ObtemDadosTriangulo();

                ITriangulo triangulo = Factory.FactoryEngine.ValidaTriangulo();
                triangulo.ValidaTriangulo(dadosObtidosTriangulo.tLadoA, 
                                          dadosObtidosTriangulo.tLadoB,
                                          dadosObtidosTriangulo.tLadoC);
            }
            else if(respostaOpcao == 1)
            {
                IFibonacci fibonacci = Factory.FactoryEngine.CreateFibonacciSequence();
                fibonacci.FibonacciEngine();
            }
            else if (respostaOpcao == 2)
            {
                ICalculaCasa calculaCasa = Factory.FactoryEngine.RetornaCasaComParQdtJanelasComodos();
                calculaCasa.RetornaCasaComNumeroParJanelasComodos();
            }

            Console.ReadLine();
        }
    }
}
