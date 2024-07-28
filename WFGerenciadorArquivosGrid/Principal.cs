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
using WFServices.Models;

namespace WFGerenciadorArquivosGrid
{
    public partial class Principal : Form
    {
        private readonly IPexelsService pexelsService;

        public Principal()
        {
            InitializeComponent();

            pexelsService = Bootstrap.Container.GetInstance<IPexelsService>();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ret = pexelsService.ObterFotos();
        }
    }
}
