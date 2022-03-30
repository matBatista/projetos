using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiusClean.Model
{
    public class Veiculo
    {
        public Guid id { get; set; }

        [Required]
        public string nome { get; set; }
        [Required]
        [StringLength(50)]
        public string marca { get; set; }
        
        [Required]
        [StringLength(50)]
        public string modelo { get; set; }
        
        [Required]
        public DateTime dataFabricacao { get; set; }
        
        [Required]
        public Double consumoCidade { get; set; }
        
        [Required]
        public Double consumoEstrada { get; set; }


        public Veiculo()
        {
            id = new Guid();
        }
    }
}
