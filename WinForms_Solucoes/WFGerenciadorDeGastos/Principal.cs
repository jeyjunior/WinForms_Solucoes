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

namespace WFGerenciadorDeGastos
{
    public partial class Principal : Form
    {
        #region Interfaces
        private readonly IWFCategoriaRepository wFCategoriaRepository;
        private readonly IWFMetodoPagamentoRepository wFMetodoPagamentoRepository;
        private readonly IWFRegistroDebitoRepository wFRegistroDebitosRepository;
        #endregion

        #region Propriedades
        private IEnumerable<WFRegistroDebito> wFRegistroDebitosCollection;
        private Operacao OperacaoAtual;

        private int PK_WFRegistroDebitoSelecionado;
        #endregion

        #region Construtor
        public Principal()
        {
            InitializeComponent();

            wFCategoriaRepository = Bootstrap.Container.GetInstance<IWFCategoriaRepository>();
            wFMetodoPagamentoRepository = Bootstrap.Container.GetInstance<IWFMetodoPagamentoRepository>();
            wFRegistroDebitosRepository = Bootstrap.Container.GetInstance<IWFRegistroDebitoRepository>();
        }
        #endregion

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {
            CarregarDropDown();
            Pesquisar();

            HabilitarOperacao(Operacao.Visualizar);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarDespesa();
        }
        private void btnAddPagamento_Click(object sender, EventArgs e)
        {

        }
        private void btnAddCategoria_Click(object sender, EventArgs e)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OperacaoAtual != Operacao.Alterar)
                {
                    HabilitarOperacao(Operacao.Alterar);

                    var wFRegistroDebitos = wFRegistroDebitosCollection
                        .Where(i => i.PK_WFRegistroDebito == PK_WFRegistroDebitoSelecionado)
                        .FirstOrDefault();

                    txtDespesa.Text = wFRegistroDebitos.Nome;
                    txtValor.Text = wFRegistroDebitos.Valor.ToString();
                    cboCategoria.SelectedValue = wFRegistroDebitos.FK_WFCategoria.GetValueOrDefault(-1);
                    cboPagamento.SelectedValue = wFRegistroDebitos.FK_WFMetodoPagamento.GetValueOrDefault(-1);
                }
                else
                {
                    Limpar();
                    HabilitarOperacao(Operacao.Visualizar);
                }
            }
            catch
            {
                HabilitarOperacao(Operacao.Visualizar);
            }
        }
        #endregion

        #region Métodos
        private void CarregarDropDown()
        {
            CarregarCategoria();
            CarregarMetodoPagamento();
        }
        private void CarregarCategoria()
        {
            var wFCategoria = wFCategoriaRepository.ObterLista().ToList();

            wFCategoria.Add(new WFCategoria { PK_WFCategoria = -1, Nome = "" });

            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "PK_WFCategoria";
            cboCategoria.DataSource = wFCategoria.OrderBy(i => i.Nome).ToList();
        }
        private void CarregarMetodoPagamento()
        {
            var wFMetodoPagamento = wFMetodoPagamentoRepository.ObterLista().ToList();

            wFMetodoPagamento.Add(new WFMetodoPagamento { PK_WFMetodoPagamento = -1, Nome = "" });

            cboPagamento.DisplayMember = "Nome";
            cboPagamento.ValueMember = "PK_WFMetodoPagamento";
            cboPagamento.DataSource = wFMetodoPagamento.OrderBy(i => i.Nome).ToList();
        }
        private void RegistrarDespesa()
        {
            try
            {
                var wFRegistrarDespesa = new WFRegistroDebito
                {
                    Nome = txtDespesa.Text.ObterValorOuPadrao("").Trim(),
                    FK_WFCategoria = (int)cboCategoria.SelectedValue > 0 ? (int)cboCategoria.SelectedValue : (int?)null,
                    FK_WFMetodoPagamento = (int)cboPagamento.SelectedValue > 0 ? (int)cboPagamento.SelectedValue : (int?)null,
                    Valor = txtValor.Text.ObterValorOuPadrao(0m),
                    DataDebito = DateTime.Today
                };

                // Validação

                var ret = wFRegistroDebitosRepository.Adicionar(wFRegistrarDespesa);

                Pesquisar();
            }
            catch (Exception ex)
            {

            }
        }
        private void Pesquisar()
        {
            var parametro = new WFRegistroDebitoRequest
            {
                Nome = txtDespesa.Text.ObterValorOuPadrao("").Trim(),
                Valor = txtValor.Text.ObterValorOuPadrao(-1),
                FK_WFCategoria = (int)cboCategoria.SelectedValue,
                FK_WFMetodoPagamento = (int)cboPagamento.SelectedValue,
            };

            wFRegistroDebitosCollection = wFRegistroDebitosRepository.ObterLista(parametro).ToList();

            BindPrincipal();
        }
        private void BindPrincipal()
        {
            var resultado = wFRegistroDebitosCollection.Select(i => new
            {
                PK_WFRegistroDebito = i.PK_WFRegistroDebito,
                Despesa = i.Nome,
                Categoria = cboCategoria.Items.OfType<WFCategoria>().Where(c => c.PK_WFCategoria == i.FK_WFCategoria.GetValueOrDefault(-1)).FirstOrDefault().Nome,
                Pagamento = cboPagamento.Items.OfType<WFMetodoPagamento>().Where(p => p.PK_WFMetodoPagamento == i.FK_WFMetodoPagamento.GetValueOrDefault(-1)).FirstOrDefault().Nome,
                DataDespesa = i.DataDebito,
                Valor = i.Valor,
            }).ToList();

            dtgGastos.DataSource = resultado.ToList();
        }
        private void HabilitarOperacao(Operacao operacao)
        {
            OperacaoAtual = operacao;
            switch (operacao)
            {
                case Operacao.Visualizar:
                    this.btnExcluir.Enabled = true;
                    this.btnPesquisar.Enabled = true;
                    this.btnAlterar.Enabled = true;
                    this.btnRegistrar.Enabled = true;

                    this.btnAlterar.Text = "Alterar";
                    break;
                case Operacao.Alterar:
                    this.btnExcluir.Enabled = false;
                    this.btnPesquisar.Enabled = false;
                    this.btnAlterar.Enabled = true;
                    this.btnRegistrar.Enabled = true;

                    this.btnAlterar.Text = "Cancelar";
                    break;
                default:
                    break;
            }
        }
        #endregion
        private void Limpar()
        {
            txtDespesa.Text = "";
            txtValor.Text = "";
            cboCategoria.SelectedValue = -1;
            cboPagamento.SelectedValue = -1;
        }
        private void dtgGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgGastos.Rows.Count <= 0)
                return;

            PK_WFRegistroDebitoSelecionado = dtgGastos
                .SelectedRows
                .OfType<DataGridViewRow>()
                .Select(i => i.Cells["colPK_WFRegistroDebito"].Value.ToString().ObterValorOuPadrao(0))
                .FirstOrDefault();  
        }
        private void dtgGastos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgGastos_CellContentClick(sender, e);
        }
    }
}
