using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WFBase.Base;
using WFBase.Interface;
using WFServices.Interfaces.Sistema;
using WFServices.Models.Api;

namespace WFServices.Services.Sistema
{
    public class GerenciadorService : IGerenciadorService
    {
        private readonly IConfigBase config;
        private string diretorioPadrao;

        private Queue<Imagem> imagens;
        private Thread Thread;

        public GerenciadorService()
        {
            config = BootstrapServices.Container.GetInstance<IConfigBase>();

            diretorioPadrao = config.ObterPropriedade(WFBase.ConfigPropriedade.DiretorioPadrao);
        }

        public void ObterImagensAsync(List<Imagem> parametros, EventHandler e, SynchronizationContext synchronizationContext)
        {
            if (imagens == null)
                imagens = new Queue<Imagem>();

            parametros.ForEach(i => imagens.Enqueue(i));

            if (Thread == null || !Thread.IsAlive)
            {
                Thread = new Thread(() =>
                {
                ProximaImagem:;

                    if (imagens.Count <= 0)
                        goto Sair;

                    var img = imagens.Dequeue();

                    var ret = ObterImagem(img);

                    if (ret)
                    {
                        if (e != null)
                        {
                            synchronizationContext.Post(_ => e.Invoke(img, null), null);
                        }
                    }

                    goto ProximaImagem;

                Sair:;
                });

                Thread.Start();
            }
        }

        public bool ObterImagem(Imagem parametro)
        {
            bool ret = false;

            if (parametro == null)
                goto Sair;

            parametro.ValidationResult = new ValidationResult();

            if (!ValidarExistenciaArquivo(parametro))
            {
                var imagemByte = BaixarImagem(parametro);

                if (!parametro.ValidationResult.IsValid)
                    goto Sair;

                if (imagemByte.Length <= 0)
                {
                    parametro.ValidationResult.AddError("Não foi possível obter a imagem através da url fornecida.");
                    goto Sair;
                }

                if (imagemByte != null)
                    parametro.Data = imagemByte;

                SalvarImagem(parametro);

                if (!parametro.ValidationResult.IsValid)
                    goto Sair;

                ret = ValidarExistenciaArquivo(parametro);
            }
            else
                ret = true;

            if (!parametro.ValidationResult.IsValid)
                goto Sair;
        Sair:;
            return ret;
        }
        private string ObterDestinoArquivo(Imagem parametro)
        {
            if (!parametro.ValidarFormatoNome())
                return "";

            if(parametro.Nome.EndsWith("/"))
                parametro.Nome = parametro.Nome.Substring(0, parametro.Nome.Length - 1);

            return @diretorioPadrao + "\\" + parametro.Nome + parametro.Formato;
        }
        private byte[] BaixarImagem(Imagem parametro)
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
                if (parametro.ValidationResult == null)
                    parametro.ValidationResult = new ValidationResult();

                parametro.ValidationResult.AddError(ex.Message);
            }

            return imagem;
        }
        private bool ValidarExistenciaArquivo(Imagem parametro) 
        {
            bool ret = false;

            try
            {
                string destino = ObterDestinoArquivo(parametro);
                ret = File.Exists(destino);
            }
            catch (Exception ex)
            {
                if (parametro.ValidationResult == null)
                    parametro.ValidationResult = new ValidationResult();

                parametro.ValidationResult.AddError(ex.Message);
            }

            return ret;
        }
        private void SalvarImagem(Imagem parametro)
        {
            try
            {
                if (!parametro.IsValid())
                    goto Sair;

                if (!Directory.Exists(@diretorioPadrao))
                    Directory.CreateDirectory(@diretorioPadrao);

                string destino = ObterDestinoArquivo(parametro);

                File.WriteAllBytes(destino, parametro.Data);
            }
            catch (Exception ex)
            {
                if (parametro.ValidationResult == null)
                    parametro.ValidationResult = new ValidationResult();

                parametro.ValidationResult.AddError(ex.Message);
            }

        Sair:;
        }
    }
}
