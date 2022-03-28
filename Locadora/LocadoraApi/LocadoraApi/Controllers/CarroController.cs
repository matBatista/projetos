using LocadoraApi.Data;
using LocadoraApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CarroController : ControllerBase
    {
        private AppDbContext _context;
        public CarroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _context.tb_carros;
        }

        [HttpGet("{id}")]
        public Carro Get(Guid id)
        {
            return _context.tb_carros.FirstOrDefault(c => c.id == id);
        }

        [HttpPost]
        public IActionResult Insert(Carro carro)
        {
            if (carro != null)
            {
                _context.tb_carros.Add(carro);
                _context.SaveChanges();

                return Ok("Carro Adicionado a Garagem");
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Carro dados)
        {
            var carro = _context.tb_carros.FirstOrDefault(c => c.id == id);

            if (carro != null)
            {
                carro.modelo = String.IsNullOrEmpty(dados.modelo) ? carro.modelo : dados.modelo;
                carro.ano = (dados.ano <= 0) ? carro.ano : dados.ano;
                carro.marca = String.IsNullOrEmpty(dados.marca) ? carro.marca : dados.marca;
                carro.placa = String.IsNullOrEmpty(dados.placa) ? carro.placa : dados.placa;
                carro.montadora = String.IsNullOrEmpty(dados.montadora) ? carro.montadora : dados.montadora;
                _context.tb_carros.Update(carro);
                _context.SaveChanges();

                return Ok("Carro Alterado com Sucesso");
            }
            return BadRequest("Carro Nao Localizado / Não Alterado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var carro = _context.tb_carros.FirstOrDefault(c => c.id == id);

            if (carro != null)
            {
                _context.tb_carros.Remove(carro);
                _context.SaveChanges();

                return Ok("Carro Removido");
            }

            return BadRequest("Carro Nao Existe");
        }
    }
}
