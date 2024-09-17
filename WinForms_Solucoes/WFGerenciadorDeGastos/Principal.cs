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
            try
            {
                wFRegistroDebitosRepository.Excluir(PK_WFRegistroDebitoSelecionado);
                Limpar();
                Pesquisar();
            }
            catch 
            {

            }
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
        private void dtgGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PK_WFRegistroDebitoSelecionado <= 0)
                return;
        }
        private void dtgGastos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgGastos_CellContentClick(sender, e);
        }
        private void dtgGastos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGastos.Rows.Count <= 0)
                return;

            PK_WFRegistroDebitoSelecionado = dtgGastos
                .SelectedRows
                .OfType<DataGridViewRow>()
                .Select(i => i.Cells["colPK_WFRegistroDebito"].Value.ToString().ObterValorOuPadrao(0))
                .FirstOrDefault();
        }
        #endregion

        #region Métodos
        private void CarregarDropDown()
        {
            try
            {
                CarregarCategoria();
                CarregarMetodoPagamento();
            }
            catch (Exception ex)
            {

            }
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
                    DataDebito = DateTime.Today,
                };

                // Validação
                if(OperacaoAtual == Operacao.Alterar)
                {
                    wFRegistrarDespesa.PK_WFRegistroDebito = PK_WFRegistroDebitoSelecionado;
                    var ret = wFRegistroDebitosRepository.Atualizar(wFRegistrarDespesa);
                }
                else
                {
                    var ret = wFRegistroDebitosRepository.Adicionar(wFRegistrarDespesa);
                }

                Limpar();
                Pesquisar();
            }
            catch (Exception ex)
            {

            }
        }
        private void Pesquisar()
        {
            try
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
                HabilitarOperacao(Operacao.Visualizar);
            }
            catch (Exception ex)
            {

            }
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

            if(dtgGastos.Rows.Count > 0)
                dtgGastos.Rows[0].Selected = true;
        }
        private void HabilitarOperacao(Operacao operacao)
        {
            OperacaoAtual = operacao;
            switch (operacao)
            {
                case Operacao.Visualizar:
                    this.btnPesquisar.Enabled = true;
                    this.btnExcluir.Enabled = (dtgGastos.Rows.Count > 0);
                    this.btnAlterar.Enabled = (dtgGastos.Rows.Count > 0);
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
        private void Limpar()
        {
            txtDespesa.Text = "";
            txtValor.Text = "";
            cboCategoria.SelectedValue = -1;
            cboPagamento.SelectedValue = -1;

            txtDespesa.Focus();
        }
        #endregion
    }
}
