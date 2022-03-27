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

            List<Carro> Locadora = new List<Carro>
            {
                new Carro { marca = "Volvo", modelo = "ESL 3000", ano = 2000, link = "", placa = "E779323",montadora = "GM"},
                new Carro { marca = "BMW", modelo = "A3", ano= 2020, link = "" ,placa = "382782DSA", montadora = "China"},
                new Carro { marca = "Mitsubish", modelo = "Lancer", ano = 2015, link  ="", placa = "PLC2015", montadora = "Japon"},
                new Carro { marca = "Honda", modelo = "Civic", ano = 2022, link  = "", placa = "MAT07", montadora = "Honda"}
            };

            _context.Carros.AddRange(Locadora);
            _context.SaveChanges();

        }
    }
}
