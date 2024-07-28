using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFServices.Models
{
    public class PexelsImagens
    {
        [JsonProperty("photos")]
        public List<PexelsImagem> Fotos { get; set; }
    }

    public class PexelsImagem
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("photographer")]
        public string photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string photographerUrl { get; set; }

        [JsonProperty("photographer_id")]
        public string photographerId { get; set; }

        [JsonProperty("src")]
        public PexelsSource source { get; set; }

        [JsonProperty("liked")]
        public bool liked { get; set; }

        [JsonProperty("avg_color")]
        public string avgColor { get; set; }

        [JsonProperty("alt")]
        public string alt { get; set; }
    }

    public class PexelsSource
    {
        [JsonProperty("original")]
        public string original { get; set; }

        [JsonProperty("large")]
        public string large { get; set; }

        [JsonProperty("large2x")]
        public string large2x { get; set; }

        [JsonProperty("medium")]
        public string medium { get; set; }

        [JsonProperty("small")]
        public string small { get; set; }

        [JsonProperty("portrait")]
        public string portrait { get; set; }

        [JsonProperty("landscape")]
        public string landscape { get; set; }

        [JsonProperty("tiny")]
        public string tiny { get; set; }
    }
}
