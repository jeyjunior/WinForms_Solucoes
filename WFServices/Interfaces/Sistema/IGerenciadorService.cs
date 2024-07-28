using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFServices.Interfaces.Sistema
{
    public interface IGerenciadorService
    {
        bool BaixarImagem(string url, EventArgs e = null);
    }
}
