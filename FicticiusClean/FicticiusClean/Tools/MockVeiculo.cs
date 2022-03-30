using FicticiusClean.Data;
using FicticiusClean.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiusClean.Tools
{
    public class MockVeiculo
    {
        private readonly AppDbContext _context;

        public MockVeiculo(AppDbContext context)
        {
            _context = context;
        }

        public void AddVeiculosIniciais()
        {
            if (_context.tb_veiculo.Count() == 0)
            {
                List<Veiculo> Locadora = new List<Veiculo>
                {
                new Veiculo { nome = "Panda", marca = "Cintroen", modelo = "Air Cross", dataFabricacao = Convert.ToDateTime("2018-05-02"), consumoCidade = 8.75, consumoEstrada = 12},
                new Veiculo { nome = "Lancera", marca = "Mitsubish", modelo = "Lancer", dataFabricacao = Convert.ToDateTime("2022-10-11"), consumoCidade = 5, consumoEstrada = 10},
                new Veiculo { nome = "Jac", marca = "Jac Mottors", modelo = "J3 Turin", dataFabricacao = Convert.ToDateTime("2014-01-01"), consumoCidade = 10, consumoEstrada = 15},
                new Veiculo { nome = "Civicao", marca = "Honda", modelo = "Civic M", dataFabricacao = Convert.ToDateTime("2021-01-01"), consumoCidade = 5, consumoEstrada = 11.3},
                };

                _context.tb_veiculo.AddRange(Locadora);
                _context.SaveChanges();
            }
        }
    }
}
