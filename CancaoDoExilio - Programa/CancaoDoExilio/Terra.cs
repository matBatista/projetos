using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Terra
    {
        public int QuantidadePalmeirasAvistadas = 7;
        public string sabiaCanta = "Sim";

        public Palmeira[] palmeiras;

        public List<Ave> aves;


        public Terra()
        {
            palmeiras = new Palmeira[QuantidadePalmeirasAvistadas];
            aves = new List<Ave>();

            Ave aux = new Ave();
            aux.gorjeio = 100;
            aux.nome = "Sabia";
            aux.TipoAsas = "Normais";

            aves.Add(aux);
        }
        
        public bool Terminou { get; set; }


        public double ObterQuantidadeCoisas()
        {
            double teste = 1.5;
            for (int i = 0; i < 20; i++)
            {
                teste = teste + 1.54;
            }

            return teste;
        }

        public bool ObterPrimores()
        {
            int x = 10;
            int y = 20;

            return y == 20 && x == 10;
        }
    }
}
