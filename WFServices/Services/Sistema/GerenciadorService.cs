﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WFBase;
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

        private Thread Thread;

        public GerenciadorService()
        {
            config = BootstrapServices.Container.GetInstance<IConfigBase>();
            diretorioPadrao = config.ObterPropriedade(ConfigSistema.DiretorioPadrao);
        }

        public void ObterImagensAsync(List<Imagem> parametros, EventHandler e, SynchronizationContext synchronizationContext)
        {
            if (Thread == null || !Thread.IsAlive)
            {
                Thread = new Thread(() =>
                {
                    var imagens = new Queue<Imagem>();
                    parametros = parametros.OrderBy(i => i.Nome).ToList();
                    parametros.ForEach(i => imagens.Enqueue(i));

                    while (imagens.Count > 0) 
                    {
                        var img = imagens.Dequeue();

                        var ret = ObterImagem(img);

                        if (ret)
                        {
                            if (e != null)
                            {
                                synchronizationContext.Post(_ => e.Invoke(img, null), null);
                            }
                        }
                    }
                });

                Thread.Start();
            }
        }

        public bool ObterImagem(Imagem parametro)
        {
            bool ret = false;

            if (parametro == null)
                goto Sair;

            parametro.Validacao = new Validacao();

            if (!ValidarExistenciaArquivo(parametro))
            {
                var imagemByte = BaixarImagem(parametro);

                if (!parametro.Validacao.ehValido)
                    goto Sair;

                if (imagemByte.Length <= 0)
                {
                    parametro.Validacao.AddErro("Não foi possível obter a imagem através da url fornecida.");
                    goto Sair;
                }

                if (imagemByte != null)
                    parametro.Data = imagemByte;

                SalvarImagem(parametro);

                if (!parametro.Validacao.ehValido)
                    goto Sair;

                ret = ValidarExistenciaArquivo(parametro);
            }
            else
                ret = true;

            if (!parametro.Validacao.ehValido)
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
                if (parametro.Validacao == null)
                    parametro.Validacao = new Validacao();

                parametro.Validacao.AddErro(ex.Message);
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
                if (parametro.Validacao == null)
                    parametro.Validacao = new Validacao();

                parametro.Validacao.AddErro(ex.Message);
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
                if (parametro.Validacao == null)
                    parametro.Validacao = new Validacao();

                parametro.Validacao.AddErro(ex.Message);
            }

        Sair:;
        }
    }
}
