using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBaseDados.Interfaces;

namespace WFBaseDados.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> 
    {
        protected readonly string conexao = Program.ObterConexao();

        protected IEnumerable<T> ExecutarConsulta(string sql, Validacao validacao = null)
        {
            var lista = new List<T>();

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    lista = connection.Query<T>(sql).ToList();
                }
            }
            catch (SqlException sqlEx)
            {
                validacao.AddErro(sqlEx.Message);
            }
            catch (Exception ex)
            {
                validacao.AddErro(ex.Message);
            }

            return lista;
        }

        protected IEnumerable<T> ExecutarConsulta(string sql, object parametros, Validacao validacao = null)
        {
            var lista = new List<T>();

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    lista = connection.Query<T>(sql, parametros).ToList();
                }
            }
            catch (SqlException sqlEx)
            {
                validacao.AddErro(sqlEx.Message);
            }
            catch (Exception ex)
            {
                validacao.AddErro(ex.Message);
            }

            return lista;
        }

        public virtual IEnumerable<T> ObterLista(Validacao validacao = null)
        {
            string sql = $"SELECT * FROM {typeof(T).Name}\n";
            return ExecutarConsulta(sql, validacao);
        }

        public virtual IEnumerable<T> ObterLista(string where, object parametros, Validacao validacao = null)
        {
            string query = $"SELECT * FROM {typeof(T).Name} ";

            if (where.ObterValorOuPadrao("").Trim() != "")
                query += "WHERE " + where;

            return ExecutarConsulta(query, parametros, validacao);
        }
    }
}
