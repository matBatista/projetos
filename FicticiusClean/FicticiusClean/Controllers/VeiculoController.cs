using FicticiusClean.Data;
using FicticiusClean.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiusClean.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class VeiculoController : ControllerBase
    {
        private AppDbContext _context;
        public VeiculoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Veiculo> Get()
        {
            return _context.tb_veiculo;
        }

        [HttpGet("{id}")]
        public Veiculo Get(Guid id)
        {
            return _context.tb_veiculo.FirstOrDefault(c => c.id == id);
        }

        [HttpPost]
        public IActionResult Insert(Veiculo veiculo)
        {
            if (veiculo != null)
            {
                _context.tb_veiculo.Add(veiculo);
                _context.SaveChanges();

                return Ok("Veiculo Adicionado");
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Veiculo dados)
        {
            var veiculo = _context.tb_veiculo.FirstOrDefault(c => c.id == id);

            if (veiculo != null)
            {
                veiculo.nome = String.IsNullOrEmpty(dados.modelo) ? veiculo.modelo : dados.modelo;
                veiculo.marca = String.IsNullOrEmpty(dados.modelo) ? veiculo.modelo : dados.modelo;
                veiculo.modelo = String.IsNullOrEmpty(dados.modelo) ? veiculo.modelo : dados.modelo;
                veiculo.dataFabricacao = dados.dataFabricacao;
                veiculo.consumoCidade = (dados.consumoCidade < 0) ? veiculo.consumoCidade : dados.consumoCidade;
                veiculo.consumoEstrada = (dados.consumoEstrada < 0) ? veiculo.consumoEstrada : dados.consumoEstrada;

                _context.tb_veiculo.Update(veiculo);
                _context.SaveChanges();

                return Ok("Dados Alterados");
            }
            return BadRequest("Carro não Localizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var veiculo = _context.tb_veiculo.FirstOrDefault(c => c.id == id);

            if (veiculo != null)
            {
                _context.tb_veiculo.Remove(veiculo);
                _context.SaveChanges();

                return Ok("Removido com Sucesso.");
            }

            return BadRequest("Veiculo Não Encontrado.");
        }
    }
}
