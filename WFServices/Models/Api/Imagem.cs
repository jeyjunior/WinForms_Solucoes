using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFServices.Models.Api
{
    public class Imagem
    {
        public int ID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
        public string Alt { get; set; }
    }


    public class ImagemDownloadRequest
    {
        public string Url { get; set; }
        public string Nome { get; set;}
        public string Formato { get; set; }
        public byte[] data { get; set; }

        public bool IsValid()
        {
            bool ret = true;

            if (Validation == null)
                Validation = new ValidationResult();

            if (Url.ObterValorOuPadrao("") == "")
            {
                Validation.AddError("É necessário fornecer uma url para download.");
                ret = false;
            }

            if (Nome.ObterValorOuPadrao("") == "")
            {
                Validation.AddError("É necessário fornecer um nome para a imagem.");
                ret = false;
            }

            if (Formato.ObterValorOuPadrao("") == "")
            {
                Validation.AddError("É necessário fornecer um formato para a imagem.");
                ret = false;
            }

            if (data == null)
            {
                Validation.AddError("É necessário fornecer o arquivo em bytes para salvar.");
                ret = false;
            }

            return ret;
        }

        public ValidationResult Validation { get; set; }
    }
}
