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

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            return ValidationResult.IsValid;
        }
        public bool ValidarTodasPropriedades()
        {
            if (ValidationResult == null)
                ValidationResult = new ValidationResult();

            if (ID <= 0)
                ValidationResult.Errors.Add("ID Inválido.");

            if(Url.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("ID Inválido.");

            if (Formato.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("Formato Inválido.");
            
            if(Nome.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("Nome Inválido.");

            if (Alt.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("Alt Inválido.");

            if (Autor.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("Autor Inválido.");

            if (AutorURL.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("URL Autor Inválido.");

            if(Data == null)
                ValidationResult.Errors.Add("Arquivo Inválido.");

            return ValidationResult.Errors.Count() <= 0;
        }
        public bool ValidarFormatoNome()
        {
            if (ValidationResult == null)
                ValidationResult = new ValidationResult();

            if (Formato.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("Formato Inválido.");

            if (Nome.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("Nome Inválido.");
            
            return ValidationResult.Errors.Count() <= 0;
        }
        public bool ValidarUrl()
        {
            if (ValidationResult == null)
                ValidationResult = new ValidationResult();

            if (Url.ObterValorOuPadrao("").Trim() == "")
                ValidationResult.Errors.Add("ID Inválido.");

            return ValidationResult.Errors.Count() <= 0;
        }
    }
}
