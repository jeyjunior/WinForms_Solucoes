using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBaseDados.Interfaces
{
    public interface IRepositorio <T>
    {
        IEnumerable<T> ObterLista();
    }
}
