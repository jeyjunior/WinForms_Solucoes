using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFBaseDados.Interfaces
{
    public interface IRepository <T>
    {
        T Obter(int id, Validacao validacao = null);
        IEnumerable<T> ObterLista(Validacao validacao = null);
        IEnumerable<T> ObterLista(string where, object parametros, Validacao validacao = null);
        int Adicionar(T entidade, Validacao validacao = null);
        int Atualizar(T entidade, Validacao validacao = null);
    }
}
