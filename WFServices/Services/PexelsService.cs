using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

            string url = config.ObterPropriedade(ApiService.Pexels, ApiPropriedade.ApiURL);
            string timeOut = config.ObterPropriedade(ApiService.Pexels, ApiPropriedade.RequestTimeOutSec);
            string key = config.ObterPropriedade(ApiService.Pexels, ApiPropriedade.ApiKey);

            if (string.IsNullOrEmpty(url))
            {
                throw new InvalidOperationException("A URL da API não está configurada.");
            }

            if (string.IsNullOrEmpty(timeOut) || !double.TryParse(timeOut, out double timeoutSeconds))
            {
                throw new InvalidOperationException("Configuração de timeout inválida ou ausente.");
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new InvalidOperationException("A chave da API não está configurada.");
            }

            client.BaseAddress = new Uri(url);
            client.Timeout = TimeSpan.FromMinutes(10);
            client.DefaultRequestHeaders.Add("Authorization", key);

            return client;
        }

        public async Task<List<Foto>> BuscarFotosAsync(string query, int maxImages = 10)
        {
            using (var client = ObterClient())
            {
                List<Foto> allPhotos = new List<Foto>();
                int page = 1;
                int pageSize = 15;

                while (allPhotos.Count < maxImages)
                {
                    string requestUrl = $"v1/search?query={Uri.EscapeDataString(query)}&page={page}&per_page={pageSize}";
                    HttpResponseMessage response = await client.GetAsync(requestUrl);
                     
                    response.EnsureSuccessStatusCode();

                    var result = await ProcessResult<PaginaFoto>(response);

                    if (result.Fotos == null || result.Fotos.Count() == 0)
                    {
                        break; // Se não houver mais fotos, saia do loop
                    }

                    allPhotos.AddRange(result.Fotos);

                    if (result.Fotos.Count < pageSize)
                    {
                        break; // Se a última página tinha menos fotos do que o pageSize, saia do loop
                    }

                    page++;
                }

                // Retorne apenas a quantidade máxima de imagens desejadas
                return allPhotos.Take(maxImages).ToList();
            }
        }

        private async Task<T> ProcessResult<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
