using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBase;
using WFBase.Base;
using WFBaseDados.Entidades;
using WFBaseDados.Interfaces;

namespace WFGerenciadorDeGastos.Telas
{
    public partial class CadastroCategoria : Form
    {
        #region Interfaces
        private readonly IWFCategoriaRepository wFCategoriaRepository;
        #endregion

        #region Propriedades
        private IEnumerable<WFCategoria> wFCategoriasCollection;
        private Operacao OperacaoAtual;
        #endregion

        #region Construtor
        public CadastroCategoria()
        {
            InitializeComponent();

            wFCategoriaRepository = Bootstrap.Container.GetInstance<IWFCategoriaRepository>();
        }
        #endregion

        #region Eventos
        private void CadastroCategoria_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        #endregion

        #region Métodos
        private void Pesquisar()
        {
            try
            {
                var nome = txtCategoria.Text.ObterValorOuPadrao("").Trim();

                wFCategoriasCollection = wFCategoriaRepository
                    .ObterLista("Nome LIKE @Nome", new { Nome = $"%{nome}%"})
                    .ToList();

                BindPrincipal();
                AtualizarQuantidade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindPrincipal()
        {
            var resultado = wFCategoriasCollection.Select(i => new
            {
                PK_WFCategoria = i.PK_WFCategoria,
                Nome = i.Nome,

            }).ToList();

            dtgCategoria.DataSource = resultado.ToList();

            if (dtgCategoria.Rows.Count > 0)
                dtgCategoria.Rows[0].Selected = true;
        }
        private void AtualizarQuantidade()
        {
            lblStatus.Text = "Total: " + dtgCategoria.RowCount.ToString("N0");
        }
        private void Limpar()
        {
            txtCategoria.Text = "";
            txtCategoria.Focus();
        }
        #endregion
    }
}
