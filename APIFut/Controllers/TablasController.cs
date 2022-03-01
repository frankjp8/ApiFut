using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using APIFut.Models;
using Newtonsoft.Json;

namespace APIFut.Controllers
{
    [ApiController]
    [Route("api/tablas/[action]")]
    public class TablasController : Controller
    {
        readonly string url = "https://api.football-data.org/v2/";
        Root tabla = new Root();
        [HttpGet]
        public async Task<Root> LaLiga()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Auth-Token", "d4412d78f58e49e597864a451a38bc6e");
               
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("competitions/PD/standings");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    tabla = JsonConvert.DeserializeObject<Root>(response);
                }
                return tabla;
            }
        }
        [HttpGet]
        public async Task<Root> Premier()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Auth-Token", "d4412d78f58e49e597864a451a38bc6e");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("competitions/PL/standings");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    tabla = JsonConvert.DeserializeObject<Root>(response);
                }
                return tabla;
            }
        }
        [HttpGet]
        public async Task<Root> Bundes()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Auth-Token", "d4412d78f58e49e597864a451a38bc6e");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("competitions/BL1/standings");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    tabla = JsonConvert.DeserializeObject<Root>(response);
                }
                return tabla;
            }
        }
        [HttpGet]
        public async Task<Root> Ligue1()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Auth-Token", "d4412d78f58e49e597864a451a38bc6e");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("competitions/FL1/standings");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    tabla = JsonConvert.DeserializeObject<Root>(response);
                }
                return tabla;
            }
        }
        [HttpGet]
        public async Task<Root> SerieA()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Auth-Token", "d4412d78f58e49e597864a451a38bc6e");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("competitions/SA/standings");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    tabla = JsonConvert.DeserializeObject<Root>(response);
                }
                return tabla;
            }
        }
    }
}
