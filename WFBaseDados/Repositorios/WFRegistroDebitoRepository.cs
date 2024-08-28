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
    public class WFRegistroDebitoRepository : Repository<WFRegistroDebito>, IWFRegistroDebitoRepository
    {
        private string SQLBase = "";

        private string SQL = "";

        public WFRegistroDebitoRepository()
        {
            SQLBase = "SELECT WFRegistroDebito.* FROM WFRegistroDebito";

            SQL = " " +
                "SELECT WFRegistroDebito.* " +
                "FROM   WFRegistroDebito " +
                "LEFT   JOIN    WFCategoria " +
                "       ON      WFCategoria.PK_WFCategoria = WFRegistroDebito.FK_WFCategoria " +
                "LEFT   JOIN    WFMetodoPagamento " +
                "       ON      WFMetodoPagamento.PK_WFMetodoPagamento = WFRegistroDebito.FK_WFMetodoPagamento ";
        }

        public IEnumerable<WFRegistroDebito> ObterLista(WFRegistroDebitoRequest parametro, Validacao validacao = null)
        {
            var wFRegistroDebitoCollection = new List<WFRegistroDebito>();

            string where = "";

            if(parametro == null)
                goto Pesquisar;

            if (parametro.Nome.ObterValorOuPadrao("").Trim() != "")
                where += "WFRegistroDebito.Nome LIKE '%" + parametro.Nome + "%' COLLATE DATABASE_DEFAULT";

            //if (parametro.DataDebito != null)
            //    where += ((where.Length > 0) ? "AND " : "") + "WFRegistroDebito.DataDebito = @DataDebito ";

            if(parametro.Valor >= 0)
                where += ((where.Length > 0) ? "AND " : "") + "WFRegistroDebito.Valor = @Valor ";

            if (parametro.FK_WFCategoria > 0)
                where += ((where.Length > 0) ? "AND " : "") + "WFCategoria.PK_WFCategoria = @FK_WFCategoria ";

            if (parametro.FK_WFMetodoPagamento > 0)
                where += ((where.Length > 0) ? "AND " : "") + "WFMetodoPagamento.PK_WFMetodoPagamento = @FK_WFMetodoPagamento ";

            Pesquisar:;
            string sql = SQL + ((where.Length > 0) ? " WHERE " : "") + where;

            wFRegistroDebitoCollection = this.ExecutarConsulta(sql, parametro, validacao).ToList();

            return wFRegistroDebitoCollection;
        }
    }
}
