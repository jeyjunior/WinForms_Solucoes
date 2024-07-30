using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFServices.Models.Api;

namespace WFServices.Interfaces.Sistema
{
    public interface IGerenciadorService
    {
        bool ObterImagem(Imagem parametro);
    }
}
