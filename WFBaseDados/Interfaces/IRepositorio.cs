using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFBaseDados.Interfaces
{
    public interface IRepositorio <T>
    {
        IEnumerable<T> ObterLista(Validacao validacao = null);
        IEnumerable<T> ObterLista(string where, object parametros, Validacao validacao = null);
    }
}
