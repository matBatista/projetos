using ApiLocadora.Data;
using ApiLocadora.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLocadora.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CarrosController : ControllerBase
    {
        private ApplicationDBContext _context;
        public CarrosController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _context.Carros;
        }


        [HttpPost]
        public IActionResult Post(Carro carro)
        {
            if (carro != null)
            {
                _context.Carros.Add(carro);
                _context.SaveChanges();

                return Ok("Carro Adicionado a Garagem");
            }

            return BadRequest();
        }
    }
}
