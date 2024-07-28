using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFServices.Interfaces;
using WFServices.Interfaces.Sistema;
using WFServices.Models;

namespace WFGerenciadorArquivosGrid
{
    public partial class Principal : Form
    {
        private readonly IPexelsService pexelsService;
        private readonly IGerenciadorService gerenciadorService;
        public Principal()
        {
            InitializeComponent();

            pexelsService = Bootstrap.Container.GetInstance<IPexelsService>();
            gerenciadorService = Bootstrap.Container.GetInstance<IGerenciadorService>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = gerenciadorService.BaixarImagem("", null);
            var ret = pexelsService.ObterFotos();
        }
    }
}
