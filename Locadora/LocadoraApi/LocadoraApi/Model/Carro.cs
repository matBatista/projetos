using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApi.Model
{
    public class Carro
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string marca { get; set; }

        [Required]
        [StringLength(50)]
        public string modelo { get; set; }

        [Required]
        public int ano { get; set; }
        
        [StringLength(50)]
        public string montadora { get; set; }

        [Required]
        [StringLength(10)]
        public string placa { get; set; }

        public Carro()
        {
            id = Guid.NewGuid();
        }
    }
}
