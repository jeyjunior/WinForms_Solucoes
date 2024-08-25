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
using WFBaseDados.Interfaces;
using WFGerenciadorDeGastos.Telas;

namespace WFGerenciadorDeGastos
{
    public partial class Principal : Form
    {
        #region Interfaces
        private readonly IWFTesteRepository wFTesteRepositorio;
        private readonly IWFCategoriaRepository wFCategoriaRepositorio;
        #endregion

        #region Construtor
        public Principal()
        {
            InitializeComponent();

            wFTesteRepositorio = BootstrapBase.Container.GetInstance<IWFTesteRepository>();
            wFCategoriaRepositorio = BootstrapBase.Container.GetInstance<IWFCategoriaRepository>();
        }
        #endregion

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        }
        private void btnAddPagamento_Click(object sender, EventArgs e)
        {

        }
        private void btnAddCategoria_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Métodos

        #endregion
    }
}
