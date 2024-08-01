using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGerenciadorDeGastos.Telas
{
    public partial class RegistroDespesas : Form
    {
        public RegistroDespesas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var cadastrarDespesa = new CadastrarDespesa();
            cadastrarDespesa.ShowDialog();
        }
    }
}
