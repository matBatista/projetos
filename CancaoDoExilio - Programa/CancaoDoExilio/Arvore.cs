using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public abstract class Arvore : Planta
    {
        public string Raiz;

        public abstract void Crescer();

        public virtual void Morrer()
        {
            Console.WriteLine("A Arvore Morreu");
        }

    }
}
