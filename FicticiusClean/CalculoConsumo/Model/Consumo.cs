using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoConsumo.Model
{
    public class Consumo
    {
        public Veiculo veiculo { get; set; }

        [Display(AutoGenerateField = false)]
        public Double precoGasolina { get; set; }

        [Display(AutoGenerateField = false)]
        public Double consumoKmEstrada { get; set; }

        [Display(AutoGenerateField = false)]
        public Double consumoKmCidade { get; set; }

    }
}
