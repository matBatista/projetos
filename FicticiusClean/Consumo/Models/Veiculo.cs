using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consumo.Models
{
    public class Veiculo
    {
        public Guid id { get; set; }
        public string nome { get; set; }       
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime dataFabricacao { get; set; }
        public Double consumoCidade { get; set; }
        public Double consumoEstrada { get; set; }

    }
}
