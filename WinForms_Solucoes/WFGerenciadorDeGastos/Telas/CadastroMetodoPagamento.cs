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
using WFBaseDados;
using WFBaseDados.Entidades;
using WFBaseDados.Interfaces;
using WFBaseDados.Repositorios;
using WFGerenciadorDeGastos.Telas;

namespace WFGerenciadorDeGastos.Telas
{
    public partial class CadastroMetodoPagamento : Form
    {
        #region Interfaces
        private readonly IWFMetodoPagamentoRepository wFMetodoPagamentoRepository;
        #endregion
        #region Propriedades
        private IEnumerable<WFMetodoPagamento> wFMetodoPagamentoCollection;
        private Operacao OperacaoAtual;
        #endregion

        #region Construtor
        public CadastroMetodoPagamento()
        {
            InitializeComponent();

            wFMetodoPagamentoRepository = Bootstrap.Container.GetInstance<IWFMetodoPagamentoRepository>();
        }
        #endregion

        #region Eventos
        private void CadastroMetodoPagamento_Load(object sender, EventArgs e)
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
                var nome = txtPagamento.Text.ObterValorOuPadrao("").Trim();

                wFMetodoPagamentoCollection = wFMetodoPagamentoRepository.ObterLista("Nome LIKE @Nome", new { Nome = $"%{nome}%" });

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
            var resultado = wFMetodoPagamentoCollection.Select(i => new
            {
                PK_WFMetodoPagamento = i.PK_WFMetodoPagamento,
                Nome = i.Nome,
                
            }).ToList();

            dtgPagamento.DataSource = resultado.ToList();

            if (dtgPagamento.Rows.Count > 0)
                dtgPagamento.Rows[0].Selected = true;
        }
        private void AtualizarQuantidade()
        {
            lblStatus.Text = "Total: " + dtgPagamento.RowCount.ToString("N0");
        }
        private void HabilitarOperacao(Operacao operacao)
        {
            OperacaoAtual = operacao;
            switch (operacao)
            {
                case Operacao.Visualizar:
                    this.btnPesquisar.Enabled = true;
                    this.btnExcluir.Enabled = (dtgPagamento.Rows.Count > 0);
                    this.btnAlterar.Enabled = (dtgPagamento.Rows.Count > 0);
                    this.btnSalvar.Enabled = true;

                    this.btnAlterar.Text = "Alterar";
                    break;
                case Operacao.Alterar:
                    this.btnExcluir.Enabled = false;
                    this.btnPesquisar.Enabled = false;
                    this.btnAlterar.Enabled = true;
                    this.btnSalvar.Enabled = true;

                    this.btnAlterar.Text = "Cancelar";
                    break;
                default:
                    break;
            }
        }
        private void Limpar()
        {
            txtPagamento.Text = "";
            txtPagamento.Focus();
        }
        #endregion
    }
}
