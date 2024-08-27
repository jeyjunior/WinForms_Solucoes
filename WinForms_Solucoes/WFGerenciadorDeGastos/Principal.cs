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
        private readonly IWFRegistroDebitosRepository wFRegistroDebitosRepository;
        #endregion

        #region Propriedades
        private IEnumerable<WFRegistroDebitos> wFRegistroDebitosCollection;
        #endregion

        #region Construtor
        public Principal()
        {
            InitializeComponent();

            wFCategoriaRepository = Bootstrap.Container.GetInstance<IWFCategoriaRepository>();
            wFMetodoPagamentoRepository = Bootstrap.Container.GetInstance<IWFMetodoPagamentoRepository>();
            wFRegistroDebitosRepository = Bootstrap.Container.GetInstance<IWFRegistroDebitosRepository>();
        }
        #endregion

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {
            CarregarDropDown();
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
                var wFRegistrarDespesa = new WFRegistroDebitos
                {
                    Nome = txtDespesa.Text.ObterValorOuPadrao("").Trim(),
                    FK_WFCategoria = (int)cboCategoria.SelectedValue > 0 ? (int)cboCategoria.SelectedValue : (int?)null,
                    FK_WFMetodoPagamento = (int)cboPagamento.SelectedValue > 0 ? (int)cboPagamento.SelectedValue : (int?)null,
                    Valor = txtValor.Text.ObterValorOuPadrao(0m),
                    DataDebito = DateTime.Today
                };

                // Validação

                var ret = wFRegistroDebitosRepository.Adicionar(wFRegistrarDespesa);

                BindPrincipal();
            }
            catch (Exception ex)
            {

            }
        }

        private void BindPrincipal()
        {
            var resultado = wFRegistroDebitosCollection.Select(i => new
            {
                PK_WFRegistroDebitos = i.PK_WFRegistroDebitos,
                Despesa = i.Nome,
                Categoria = "",
                Pagamento = "",
                DataDespesa = "",
                Valor = 0,
            }).ToList();

            dtgGastos.DataSource = resultado.ToList();
        }
        #endregion
    }
}
