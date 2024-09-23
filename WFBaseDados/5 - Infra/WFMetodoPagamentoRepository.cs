using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBaseDados.Entidades;
using WFBaseDados.Interfaces;

namespace WFBaseDados.Repositorios
{
    public class WFMetodoPagamentoRepository : Repository<WFMetodoPagamento>, IWFMetodoPagamentoRepository
    {
        public override int Excluir(int id, Validacao validacao = null)
        {
            string sql = "";

            return base.Excluir(id, validacao);
        }
    }
}
