using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFServices.Models.Api
{
    public class Imagem
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Formato { get; set; }
        public string Nome { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Alt { get; set; }
        public string Autor { get; set; }
        public string AutorID { get; set; }
        public string AutorURL { get; set; }
        public byte[] Data { get; set; }
        public bool ImagemBaixada { get; set; }

        public Validacao Validacao { get; set; }

        public bool IsValid()
        {
            return Validacao.ehValido;
        }
        public bool ValidarTodasPropriedades()
        {
            if (Validacao == null)
                Validacao = new Validacao();

            if (ID <= 0)
                Validacao.Erros.Add("ID Inválido.");

            if(Url.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("ID Inválido.");

            if (Formato.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("Formato Inválido.");
            
            if(Nome.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("Nome Inválido.");

            if (Alt.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("Alt Inválido.");

            if (Autor.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("Autor Inválido.");

            if (AutorURL.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("URL Autor Inválido.");

            if(Data == null)
                Validacao.Erros.Add("Arquivo Inválido.");

            return Validacao.Erros.Count() <= 0;
        }
        public bool ValidarFormatoNome()
        {
            if (Validacao == null)
                Validacao = new Validacao();

            if (Formato.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("Formato Inválido.");

            if (Nome.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("Nome Inválido.");
            
            return Validacao.Erros.Count() <= 0;
        }
        public bool ValidarUrl()
        {
            if (Validacao == null)
                Validacao = new Validacao();

            if (Url.ObterValorOuPadrao("").Trim() == "")
                Validacao.Erros.Add("ID Inválido.");

            return Validacao.Erros.Count() <= 0;
        }
    }
}
