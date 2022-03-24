using ApiLocadora.Data;
using ApiLocadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLocadora.Tools
{
    public class MockCarros
    {

        private readonly ApplicationDBContext _context;

        public MockCarros(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddCarrosIniciais()
        {

            List<Carro> Garagem = new List<Carro>
            {
                new Carro { Marca = "Volvo", Modelo = "ESL 3000", Ano = 2000, Link = "" },
                new Carro { Marca = "BMW", Modelo = "A3", Ano= 2020, Link = "" },
                new Carro { Marca = "Mitsubish", Modelo = "Lancer", Ano = 2015, Link  =""},
                new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2022, Link  = "" }
            };

            _context.Carros.AddRange(Garagem);
            _context.SaveChanges();

        }
    }
}
