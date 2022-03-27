﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLocadora.Model
{
    public class Carro
    {
        public Guid id { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string marca { get; set; }
        public string placa{ get; set; }
        public string montadora { get; set; }
        public string link { get; set; }


        public Carro()
        {
            id = Guid.NewGuid();
        }

    }
}
