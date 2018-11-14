using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Ave
    {
        
        public string nome { get; set; }

        public string TipoAsas
        {
            get;
            set;
        }

        public int gorjeio;

        public void AlterarNome(string nome)
        {
            this.nome = nome;
        }

        public void AlterarTipoAsas(string tipoAsas)
        {
            this.TipoAsas = tipoAsas;
        }

        public int ObterGojeio()
        {
            return 100 / gorjeio;
        }
    }
}