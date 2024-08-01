using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGerenciadorDeGastos.Telas;

namespace WFGerenciadorDeGastos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registroDespesas = new RegistroDespesas();
            registroDespesas.ShowDialog();
        }
    }
}
