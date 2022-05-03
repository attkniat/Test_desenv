using System.Collections.Generic;

namespace TesteLogica
{
    public class Casa
    {
        public string Endereco { get; set; }
        public string cor { get; set; }
        public int Metragem { get; set; }
        public List<Comodo> Comodos { get; set; }
    }
}