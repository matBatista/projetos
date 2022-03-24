using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLocadora.Model
{
    public class Carro
    {
        public Guid id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string Link { get; set; }


        public Carro()
        {
            id = Guid.NewGuid();
        }

    }
}
