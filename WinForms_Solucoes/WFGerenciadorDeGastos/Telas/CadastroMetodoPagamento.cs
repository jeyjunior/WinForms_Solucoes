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
        private int PK_WFMetodoPagamentoSelecionado;
        int index = 0;
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
                HabilitarOperacao(Operacao.Visualizar);

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

            if (resultado.Count == 0) 
            {
                var lista = resultado.Select(i => new
                {
                    PK_WFMetodoPagamento = -1,
                    Nome = "",
                })
                    .ToList();

                dtgPagamento.DataSource = lista.ToList();
            }
            else
            {
                dtgPagamento.DataSource = resultado.ToList();
            }

            if (dtgPagamento.Rows.Count > 0)
            {
                if(index > 0)
                    dtgPagamento.Rows[index].Selected = true;
            }

            index = -1;
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
                    this.btnLimpar.Enabled = true;

                    this.btnAlterar.Text = "Alterar";
                    break;
                case Operacao.Alterar:
                    this.btnExcluir.Enabled = false;
                    this.btnPesquisar.Enabled = false;
                    this.btnAlterar.Enabled = true;
                    this.btnSalvar.Enabled = true;
                    this.btnLimpar.Enabled = false;
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


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(OperacaoAtual != Operacao.Alterar)
                {
                    HabilitarOperacao(Operacao.Alterar);
                    ObterIDSelecionado();
                    txtPagamento.Text = dtgPagamento.Rows[index].Cells["colNome"].Value.ToString();
                }
                else
                {
                    Limpar();
                    HabilitarOperacao(Operacao.Visualizar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                HabilitarOperacao(Operacao.Visualizar);
            }
        }

        private void ObterIDSelecionado()
        {
            index = dtgPagamento.SelectedRows[0].Index;

            if (index < 0)
                return;

            PK_WFMetodoPagamentoSelecionado = dtgPagamento.Rows[index].Cells["colPK_WFMetodoPagamento"].Value.ToString().ObterValorOuPadrao(0);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ObterIDSelecionado();

                wFMetodoPagamentoRepository.Excluir(PK_WFMetodoPagamentoSelecionado);
                Limpar();
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            HabilitarOperacao(Operacao.Visualizar);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPagamento.Text.ObterValorOuPadrao("").Trim() == "")
                {
                    MessageBox.Show("Campo obrigatório.");
                    txtPagamento.Focus();
                    return;
                }

                WFMetodoPagamento wFMetodoPagamento = new WFMetodoPagamento
                {
                    Nome = txtPagamento.Text.ObterValorOuPadrao(""),
                };

                if(OperacaoAtual == Operacao.Alterar)
                {
                    wFMetodoPagamento.PK_WFMetodoPagamento = PK_WFMetodoPagamentoSelecionado;
                    var ret = wFMetodoPagamentoRepository.Atualizar(wFMetodoPagamento);
                }
                else
                {
                    var ret = wFMetodoPagamentoRepository.Adicionar(wFMetodoPagamento);
                }

                Limpar();
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
