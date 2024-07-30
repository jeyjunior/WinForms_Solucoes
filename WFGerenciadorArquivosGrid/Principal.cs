using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBase.Interface;
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
        private readonly IRecursosBase recursosBase;

        private List<Imagem> imagens;
        public Principal()
        {
            InitializeComponent();

            pexelsService = Bootstrap.Container.GetInstance<IPexelsService>();
            gerenciadorService = Bootstrap.Container.GetInstance<IGerenciadorService>();
            recursosBase = Bootstrap.Container.GetInstance<IRecursosBase>();
        }

        private void BindGrid()
        {
            var resultado = imagens.Select(i => new
            {
                IDArquivo = i.ID,
                NomeArquivo = i.Nome,
                Icone = recursosBase.ObterRecurso(WFBase.Base.Recurso.download),
            }).ToList();

            if(resultado.Count <= 0)
            {
                var ret = new
                {
                    IDArquivo = 0,
                    NomeArquivo = "",
                    Icone = recursosBase.ObterRecurso(WFBase.Base.Recurso.download),
                };

                dtgArquivos.DataSource = ret;
            }
            else
            {
                dtgArquivos.DataSource = resultado;
            }
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text;
            imagens = pexelsService.PesquisarImagens(query).ToList();

            if (imagens.Count() <= 0)
                goto Sair;

            BindGrid();
            Sair:;
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            foreach (var img in imagens)
            {
                var ret = gerenciadorService.ObterImagem(img);
            }
        }
    }
}
