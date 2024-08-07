using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using WFBase;
using WFBase.Interface;
using WFServices.Interfaces;
using WFServices.Models;
using WFServices.Models.Api;

namespace WFServices.Services
{
    public class PexelsService : IPexelsService
    {
        private readonly IConfigBase config;

        public PexelsService()
        {
            config = BootstrapServices.Container.GetInstance<IConfigBase>();
        }
        private HttpClient ObterClient()
        {
            var client = new HttpClient();

            string key = config.ObterPropriedade(ConfigApis.PexelsKey);

            client.DefaultRequestHeaders.Add("Authorization", key);
           
            return client;
        }
        public IEnumerable<Imagem> PesquisarImagens(string query)
        {
            var imagens = new List<Imagem>();

            using (var client = ObterClient())
            {
                string url = config.ObterPropriedade(ConfigApis.PexelsURL);

                int perPage = new Random().Next(10, 30);
                var resposta = client.GetAsync(new Uri(url + $"search?query={query}&per_page={perPage}"));
                var resultado = resposta.Result;
                var resultadoProcessado = ProcessResult<PexelsImagens>(resultado);

                if (resultadoProcessado.IsCompleted)
                {
                    var pexelsImagens = resultadoProcessado.Result.Fotos.ToList();
                    imagens = ConverterParaImagem(pexelsImagens).ToList();
                }
            }

            return imagens;
        }
        private IEnumerable<Imagem> ConverterParaImagem(List<PexelsImagem> pexelsImagem)
        {
            var imagens = new List<Imagem>();

            try
            {
                if (pexelsImagem == null)
                    goto Sair;

                if (pexelsImagem.Count <= 0)
                    goto Sair;

                imagens = pexelsImagem.Select(p => new Imagem
                {
                    ID = p.id,
                    Alt = p.alt,
                    Autor = p.photographer,
                    AutorID = p.photographerId,
                    AutorURL = p.photographerUrl,
                    Url = p.source.original,
                    Height = p.height,
                    Width = p.width,
                    Formato = ".jpg",
                    Data = null,
                    Nome = p.url.Replace("https://www.pexels.com/photo/", ""),

                }).ToList();
            }
            catch
            {
                
            }

        Sair:;

            return imagens;
        }
        private async Task<T> ProcessResult<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
