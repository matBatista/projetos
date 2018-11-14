using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Palmeira : Arvore
    {
        public sealed override void Crescer() {

            Console.WriteLine("Palmeira Cresceu!");

        }
        public string folha;

    }
}
