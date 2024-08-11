using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBaseDados.Interfaces;

namespace WFBaseDados.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> 
    {
        protected readonly string conexao = Program.ObterConexao();

        protected IEnumerable<T> ExecutarConsulta(string sql)
        {
            var lista = new List<T>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    lista = connection.Query<T>(sql).ToList();
                }
            }
            catch
            {

            }

            return lista;
        }

        protected IEnumerable<T> ExecutarConsulta(string sql, object parametros)
        {
            var lista = new List<T>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    lista = connection.Query<T>(sql, parametros).ToList();
                }
            }
            catch
            {
            }

            return lista;
        }

        public virtual IEnumerable<T> ObterLista()
        {
            string sql = $"SELECT * FROM {typeof(T).Name}";
            return ExecutarConsulta(sql);
        }
    }
}
