using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consumo.Models
{
    public class CalculoConsumo
    {
        public int posicao { get; set; }
        public Veiculo veiculo { get; set; }
        public Decimal precoGasolina { get; set; }
        public Double kmPercorridoEstrada { get; set; }
        public Double kmPercorridoCidade { get; set; }
        public Double gastoTotalCombustivel { get; set; }
        public Double gastoTotalValor { get; set; }
    }
}
