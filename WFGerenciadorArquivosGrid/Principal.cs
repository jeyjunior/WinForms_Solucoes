using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFServices.Interfaces;
using WFServices.Interfaces.Sistema;
using WFServices.Models;
using WFServices.Models.Api;

namespace WFGerenciadorArquivosGrid
{
    public partial class Principal : Form
    {
        private readonly IPexelsService pexelsService;
        private readonly IGerenciadorService gerenciadorService;
        public Principal()
        {
            InitializeComponent();

            pexelsService = Bootstrap.Container.GetInstance<IPexelsService>();
            gerenciadorService = Bootstrap.Container.GetInstance<IGerenciadorService>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fotos = pexelsService.ObterFotos();

            if (fotos.Count() <= 0)
                goto Sair;

            foreach (var f in fotos)
            {
                var r1 = new ImagemDownloadRequest
                {
                    Url = f.source.landscape,
                    Formato = ".jpeg",
                    Nome = "Teste-landscape",
                };

                var r2 = new ImagemDownloadRequest
                {
                    Url = f.source.large,
                    Formato = ".jpeg",
                    Nome = "Teste-large",
                };

                var r3 = new ImagemDownloadRequest
                {
                    Url = f.source.large2x,
                    Formato = ".jpeg",
                    Nome = "Teste-large2x",
                };

                var r4 = new ImagemDownloadRequest
                {
                    Url = f.source.medium,
                    Formato = ".jpeg",
                    Nome = "Teste-medium",
                };

                var r5 = new ImagemDownloadRequest
                {
                    Url = f.source.original,
                    Formato = ".jpeg",
                    Nome = "Teste-original",
                };

                var r6 = new ImagemDownloadRequest
                {
                    Url = f.source.portrait,
                    Formato = ".jpeg",
                    Nome = "Teste-portrait",
                };

                var r7 = new ImagemDownloadRequest
                {
                    Url = f.source.small,
                    Formato = ".jpeg",
                    Nome = "Teste-small",
                };

                var r8 = new ImagemDownloadRequest
                {
                    Url = f.source.tiny,
                    Formato = ".jpeg",
                    Nome = "Teste-tiny",
                };

                var col = new List<ImagemDownloadRequest>()
                {
                    r1, r2, r3, r4, r5, r6, r7, r8,
                };

                foreach (var c in col)
                {
                    var ret = gerenciadorService.ObterImagem(c);
                }
            }

            Sair:;
        }

        private void BindGrid()
        {

        }
    }
}
