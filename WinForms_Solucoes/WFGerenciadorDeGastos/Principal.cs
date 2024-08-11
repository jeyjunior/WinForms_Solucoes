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
using WFBaseDados.Interfaces;
using WFGerenciadorDeGastos.Telas;

namespace WFGerenciadorDeGastos
{
    public partial class Principal : Form
    {
        private readonly IWFTesteRepositorio wFTesteRepositorio;
        public Principal()
        {
            InitializeComponent();

            wFTesteRepositorio = BootstrapBase.Container.GetInstance<IWFTesteRepositorio>();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var teste = wFTesteRepositorio.ObterLista();
        }
    }
}
