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
    public class HomeController : Controller
    {
        static HttpClient httpClient = new HttpClient();
        static async Task RunAsync()
        {
            httpClient.BaseAddress = new Uri("https://localhost:5001");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        public HomeController()
        {
            RunAsync();
        }
        public IActionResult Index()
        {
            List<Veiculo> listaVeiculos = null;
            HttpResponseMessage response = httpClient.GetAsync("/veiculo").Result;
            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
                listaVeiculos = JsonConvert.DeserializeObject<List<Veiculo>>(dados.Result.ToString());
            }

            return View(listaVeiculos);
        }

    }
}
