using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CalculoConsumo.Model;
using Newtonsoft.Json;

namespace CalculoConsumo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumoController : ControllerBase
    {
        static HttpClient httpClient = new HttpClient();
        static async Task RunAsync()
        {
            httpClient.BaseAddress = new Uri("https://localhost:5001");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public ConsumoController()
        {
            RunAsync();
        }
        public IEnumerable<Consumo> Get()
        {
            IEnumerable<Veiculo> listaVeiculos = null;
            HttpResponseMessage response = httpClient.GetAsync("/veiculo").Result;
            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
                listaVeiculos = JsonConvert.DeserializeObject<IEnumerable<Veiculo>>(dados.Result.ToString());
            }

            List<Consumo> listaConsumo = new List<Consumo>();

            if (listaVeiculos != null)
            {
                foreach (Veiculo aux in listaVeiculos)
                {
                    Consumo consumoVeiculo = new Consumo();

                    consumoVeiculo.veiculo = aux;

                    listaConsumo.Add(consumoVeiculo);
                }
            }

            return listaConsumo;
        }



        [HttpGet]
        public IEnumerable<Consumo> Consumo(Consumo dados)
        {
            List<Consumo> listaConsumo = new List<Consumo>();

            return listaConsumo;
        }
    }
}
