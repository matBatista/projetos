﻿using Locadora.Data;
using Locadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Locadora.Controllers
{
    public class CarrosController : Controller
    {
        static HttpClient httpCarro = new HttpClient();
        static async Task RunAsync()
        {
            httpCarro.BaseAddress = new Uri("https://localhost:44394");
            httpCarro.DefaultRequestHeaders.Accept.Clear();
            httpCarro.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public CarrosController()
        {
            RunAsync();
        }

        public IActionResult Index()
        {
            IEnumerable<Carro> listCarros = null;
            HttpResponseMessage response = httpCarro.GetAsync("/carros").Result;
            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
                listCarros = JsonConvert.DeserializeObject<IEnumerable<Carro>>(dados.Result.ToString());
            }
            return View(listCarros);
        }
        public IActionResult Detalhes(Guid id)
        {
            Carro carro = null;
            HttpResponseMessage response = httpCarro.GetAsync("/carros/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
                carro = JsonConvert.DeserializeObject<Carro>(dados.Result.ToString());
            }
            return View(carro);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public async Task<IActionResult> Insert(Carro carro)
        {
            if (carro != null)
            {
                var content = carro;
                HttpResponseMessage response = httpCarro.PostAsJsonAsync("/carros", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var dados = response.Content.ReadAsStringAsync();
                }
                return RedirectToAction(nameof(Index)); ;
            }

            return RedirectToAction(nameof(Index)); ;
        }

        public IActionResult Editar(Guid id)
        {
            Carro carro = null;
            HttpResponseMessage response = httpCarro.GetAsync("/carros/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
                carro = JsonConvert.DeserializeObject<Carro>(dados.Result.ToString());
            }
            return View(carro);
        }
        
        public async Task<IActionResult> Update([Bind("id,marca,modelo,ano,montadora,placa")] Carro carro)
        {
            if (carro != null)
            {
                var jsonContent = JsonConvert.SerializeObject(carro);

                var stringContent = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                HttpContent content = stringContent;
                HttpResponseMessage response = httpCarro.PutAsync("/carros/" + carro.id, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var dados = response.Content.ReadAsStringAsync();
                }
                return RedirectToAction(nameof(Index)); ;
            }

            return RedirectToAction(nameof(Index)); ;
        }

        public IActionResult Delete(Guid id)
        {
            Carro carro = null;
            HttpResponseMessage response = httpCarro.DeleteAsync("/carros/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var dados = response.Content.ReadAsStringAsync();
            }
            return RedirectToAction(nameof(Index)); ;

        }


    }
}
