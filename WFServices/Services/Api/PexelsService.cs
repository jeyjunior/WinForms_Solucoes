using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WFBase;
using WFBase.Interface;
using WFServices.Interfaces;
using WFServices.Models;

namespace WFServices.Services
{
    public class PexelsService : IPexelsService
    {
        private readonly IConfig config;

        public PexelsService()
        {
            config = BootstrapServices.Container.GetInstance<IConfig>();
        }

        private HttpClient ObterClient()
        {
            var client = new HttpClient();

            string key = config.ObterPropriedade(ApiService.Pexels, ApiPropriedade.ApiKey);

            client.DefaultRequestHeaders.Add("Authorization", key);
           
            return client;
        }

        public IEnumerable<PexelsImagem> ObterFotos()
        {
            var fotos = new List<PexelsImagem>();

            using (var client = ObterClient())
            {
                string url = config.ObterPropriedade(ApiService.Pexels, ApiPropriedade.ApiURL);

                var resposta = client.GetAsync(new Uri(url + "curated?page=1&per_page=1"));
                var resultado = resposta.Result;
                var resultadoProcessado = ProcessResult<PexelsImagens>(resultado);

                if (resultadoProcessado.IsCompleted)
                {
                    fotos = resultadoProcessado.Result.Fotos.ToList();
                }
            }

            return fotos;
        }

        private async Task<T> ProcessResult<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
