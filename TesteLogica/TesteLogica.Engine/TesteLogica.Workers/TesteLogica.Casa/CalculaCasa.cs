using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteLogica
{
    public class CalculaCasa : ICalculaCasa
    {
        public void RetornaCasaComNumeroParJanelasComodos()
        {
            #region Preenchendo_lista_Casa

            var casas = new List<Casa>
            {
                new Casa
                {
                    Endereco = "Rua Castro Alves 550",
                    Metragem = 10,
                    Comodos = new List<Comodo>{
                              new Comodo{
                                  Nome = "Quarto",
                                  Janelas = 3,
                                  Portas = 2
                              },
                              new Comodo
                              {
                                  Nome = "Sala",
                                  Janelas = 6,
                                  Portas = 4
                              },
                              new Comodo
                              {
                                  Nome = "Cozinha",
                                  Janelas = 4,
                                  Portas = 2
                              }
                            },

                    cor = "Amarela"
                },
                new Casa
                {
                    Endereco = "Rua Eudebar Junior 289",
                    Metragem = 1293,
                    Comodos = new List<Comodo>{
                              new Comodo{
                                  Nome = "Quarto",
                                  Janelas = 8,
                                  Portas = 6
                              },
                              new Comodo
                              {
                                  Nome = "Sala",
                                  Janelas = 1,
                                  Portas = 2
                              },
                              new Comodo
                              {
                                  Nome = "Cozinha",
                                  Janelas = 9,
                                  Portas = 4
                              }
                            },

                    cor = "Azul"
                },
                new Casa
                {
                    Endereco = "Alameda Jarimaldo Antônio 647",
                    Metragem = 34322,
                    Comodos = new List<Comodo>{
                              new Comodo{
                                  Nome = "Quarto",
                                  Janelas = 2,
                                  Portas = 1
                              },
                              new Comodo
                              {
                                  Nome = "Sala",
                                  Janelas = 8,
                                  Portas = 4
                              },
                              new Comodo
                              {
                                  Nome = "Cozinha",
                                  Janelas = 9,
                                  Portas = 4
                              }
                            },
                    cor = "Preto"
                }
            };
            #endregion

            var evenList = casas.Select((item, index) => new { isEven = index % 2 != 0, item })
                                .ToLookup(i => i.isEven, i => i.item);

            var even = evenList[false];
            even.ToList();

            foreach (var item in even)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("\n" + "Cor: " + item.cor);
                Console.WriteLine("\n" + "Endereço: " + item.Endereco);
                Console.WriteLine("\n" + "Metragem: " + item.Metragem + "m²");
                
                foreach (var itemComodos in item.Comodos)
                {
                    Console.WriteLine("\n|Comodos|");
                    Console.WriteLine("\n" + "Nome: " +itemComodos.Nome);
                    Console.WriteLine("\n" + "Portas: " +itemComodos.Portas);
                    Console.WriteLine("\n" + "Janelas: " +itemComodos.Janelas);
                    Console.WriteLine("\n========================================");
                }
            }
        }
    }
}
