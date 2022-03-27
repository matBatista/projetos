using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Carro
    {
        public Guid id { get; set; }

        [Required]
        public String marca { get; set; }

        [Required]
        public string modelo { get; set; }

        [Required]
        public int ano { get; set; }

        public string montadora { get; set; }

        [Required]
        public string placa { get; set; }

        public Carro()
        {
            id = Guid.NewGuid();
        }
    }
}
