using Consumo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Consumo.Controllers
{
    public class ConsumoController : Controller
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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CalculoConsumo([Bind("kmPercorridoCidade,kmPercorridoEstrada,precoGasolina")]CalculoConsumo dados)
        {
            List<Veiculo> listaVeiculos = GetVeiculos();

            List<CalculoConsumo> listaConsumos = new List<CalculoConsumo>();

            if (listaVeiculos != null)
            {
                foreach (Veiculo aux in listaVeiculos)
                {
                    CalculoConsumo consumoVeiculo = new CalculoConsumo();
                    
                    consumoVeiculo.kmPercorridoCidade = dados.kmPercorridoCidade;
                    consumoVeiculo.kmPercorridoEstrada = dados.kmPercorridoEstrada;
                    consumoVeiculo.precoGasolina = dados.precoGasolina;

                    consumoVeiculo.veiculo = aux;

                    Calcular(ref consumoVeiculo);

                    listaConsumos.Add(consumoVeiculo);
                }
            }

            listaConsumos = GerarListaOrdenada(listaConsumos);

            return View(listaConsumos);
        }
        public List<Veiculo> GetVeiculos()
        {
            List<Veiculo> listaVeiculos = null;
            HttpResponseMessage response = httpClient.GetAsync("/veiculo").Result;
            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
                listaVeiculos = JsonConvert.DeserializeObject<List<Veiculo>>(dados.Result.ToString());
            }

            return listaVeiculos;
        }

        public void Calcular(ref CalculoConsumo dados)
        {
            double consumoCidade = dados.kmPercorridoCidade / dados.veiculo.consumoCidade;
            double consumoEstrada = dados.kmPercorridoEstrada / dados.veiculo.consumoEstrada;

            double consumoTotal = Math.Round(consumoCidade + consumoEstrada, 2);
            double gastoTotalGasolina = Math.Round(consumoTotal * (double)dados.precoGasolina,2);

            dados.gastoTotalCombustivel = consumoTotal;
            dados.gastoTotalValor = gastoTotalGasolina;
        }

        public List<CalculoConsumo> GerarListaOrdenada(List<CalculoConsumo> dados)
        {
            List<CalculoConsumo> listaTemp = dados.OrderBy(x => x.gastoTotalCombustivel).ToList();

            int posicao = 1;

            foreach(CalculoConsumo calc in listaTemp)
            {
                calc.posicao = posicao++;
            }

            return listaTemp;
        }
    }
}
