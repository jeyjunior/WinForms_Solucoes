using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBaseDados.Entidades;

namespace WFBaseDados.Interfaces
{
    public interface IWFRegistroDebitoRepository : IRepository<WFRegistroDebito>
    {
        IEnumerable<WFRegistroDebito> ObterLista(WFRegistroDebitoRequest parametro, Validacao validacao = null);
    }
}
