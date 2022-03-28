using LocadoraApi.Data;
using LocadoraApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApi.Tools
{
    public class MockCarro
    {
        private readonly AppDbContext _context;

        public MockCarro(AppDbContext context)
        {
            _context = context;
        }
        public void AddCarrosIniciais()
        {
            List<Carro> Locadora = new List<Carro>
            {
                new Carro { marca = "Volvo", modelo = "ESL 3000", ano = 2000, placa = "E779323",montadora = "GM"},
                new Carro { marca = "BMW", modelo = "A3", ano= 2020, placa = "382782DSA", montadora = "China"},
                new Carro { marca = "Mitsubish", modelo = "Lancer", ano = 2015,  placa = "PLC2015", montadora = "Japon"},
                new Carro { marca = "Honda", modelo = "Civic", ano = 2022, placa = "MAT07", montadora = "Honda"}
            };

            _context.tb_carros.AddRange(Locadora);
            _context.SaveChanges();
        }
    }
}
