using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBase.Interface;
using WFServices.Interfaces.Sistema;
using WFServices.Models.Api;

namespace WFServices.Services.Sistema
{
    public class GerenciadorService : IGerenciadorService
    {
        private readonly IConfig config;
        private string diretorioPadrao;

        public GerenciadorService()
        {
            config = BootstrapServices.Container.GetInstance<IConfig>();

            diretorioPadrao = config.ObterPropriedade(WFBase.ConfigPropriedade.DiretorioPadrao);
        }

        public bool ObterImagem(ImagemDownloadRequest parametro)
        {
            bool ret = false;

            if (parametro == null)
                goto Sair;

            parametro.Validation = new ValidationResult();

            if (parametro.Url.ObterValorOuPadrao("").Trim() == "")
            {
                parametro.Validation.AddError("URL inválida.");
                goto Sair;
            }

            if (parametro.Nome.ObterValorOuPadrao("").Trim() == "")
            {
                parametro.Validation.AddError("Nome inválido.");
                goto Sair;
            }

            if (!ValidarExistenciaArquivo(parametro))
            {
                var imagemByte = BaixarImagem(parametro);

                if (!parametro.Validation.IsValid)
                    goto Sair;

                if (imagemByte.Length <= 0)
                {
                    parametro.Validation.AddError("Não foi possível obter a imagem através da url fornecida.");
                    goto Sair;
                }

                if (imagemByte != null)
                    parametro.data = imagemByte;

                SalvarImagem(parametro);

                if (!parametro.Validation.IsValid)
                    goto Sair;

                ret = ValidarExistenciaArquivo(parametro);
            }
            else
                ret = true;

            if (!parametro.Validation.IsValid)
                goto Sair;
        Sair:;
            return ret;
        }
        private string ObterDestinoArquivo(ImagemDownloadRequest parametro)
        {
            return @diretorioPadrao + "\\" + parametro.Nome + parametro.Formato;
        }
        private byte[] BaixarImagem(ImagemDownloadRequest parametro)
        {
            byte[] imagem = null;

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    var uri = new Uri(parametro.Url);
                    imagem = webClient.DownloadData(uri);
                }
            }
            catch (Exception ex)
            {
                if (parametro.Validation == null)
                    parametro.Validation = new ValidationResult();

                parametro.Validation.AddError(ex.Message);
            }

            return imagem;
        }
        private bool ValidarExistenciaArquivo(ImagemDownloadRequest parametro) 
        {
            bool ret = false;

            try
            {
                string destino = ObterDestinoArquivo(parametro);
                ret = File.Exists(destino);
            }
            catch (Exception ex)
            {
                if (parametro.Validation == null)
                    parametro.Validation = new ValidationResult();

                parametro.Validation.AddError(ex.Message);
            }

            return ret;
        }
        private void SalvarImagem(ImagemDownloadRequest parametro)
        {
            try
            {
                if (!parametro.IsValid())
                    goto Sair;

                if (!Directory.Exists(@diretorioPadrao))
                    Directory.CreateDirectory(@diretorioPadrao);

                string destino = ObterDestinoArquivo(parametro);

                File.WriteAllBytes(destino, parametro.data);
            }
            catch (Exception ex)
            {
                if (parametro.Validation == null)
                    parametro.Validation = new ValidationResult();

                parametro.Validation.AddError(ex.Message);
            }

        Sair:;
        }
    }
}
