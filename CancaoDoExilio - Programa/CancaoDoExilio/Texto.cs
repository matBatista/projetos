using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace CancaoDoExilio
{
    public class Texto : ITexto
    {
        public int GerarTexto(string texto)
        {
            return Convert.ToInt32(Util.Util.GerarTexto());
        }

        string ITexto.GerarTexto(string texto)
        {
            throw new NotImplementedException();
        }
    }
}
