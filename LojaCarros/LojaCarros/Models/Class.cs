using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCarros.Models
{
    public class Carro
    {
        public Guid id { get; set; }
        
        [Required]
        public String Marca { get; set; }

        [Required]
        public string modelo { get; set; }
        
        [Required]
        public string ano { get; set; }


        public Carro()
        {
            id = Guid.NewGuid();
        }

    }
}
