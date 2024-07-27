using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFServices.Models
{
    internal class PaginaFoto
    {
        [JsonProperty("photos")]
        public List<Foto> Fotos { get; set; }
    }
}
