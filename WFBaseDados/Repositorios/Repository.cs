using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBaseDados.Interfaces;

namespace WFBaseDados.Repositorios
{
    public class Repository<T> : IRepository<T> 
    {
        protected readonly string conexao = Program.ObterConexao();

        protected T ExecutarConsultaUnica(string query, object parametros, Validacao validacao = null)
        {
            T entidade = default;

            using (SqlConnection connection = new SqlConnection(conexao))
            {
                entidade = connection.QuerySingleOrDefault<T>(query, parametros);
            }

            return entidade;
        }
        protected IEnumerable<T> ExecutarConsulta(string query, Validacao validacao = null)
        {
            var lista = new List<T>();

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    lista = connection.Query<T>(query).ToList();
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
        protected IEnumerable<T> ExecutarConsulta(string query, object parametros, Validacao validacao = null)
        {
            var lista = new List<T>();

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();
                    lista = connection.Query<T>(query, parametros).ToList();
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
        protected dynamic ExecutarComando(string query, object parametros, Validacao validacao = null)
        {
            int ret = 0;

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            ret = (int)connection.ExecuteScalar(query, parametros, transaction);

                            transaction.Commit();
                        }
                        catch (SqlException sqlEx)
                        {
                            transaction.Rollback();
                            validacao.AddErro(sqlEx.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                validacao.AddErro(ex.Message);
            }

            return ret;
        }
        public virtual T Obter(int id, Validacao validacao = null)
        {
            if (validacao == null)
                validacao = new Validacao();

            var tipo = typeof(T);

            var pkProperty = tipo.GetProperties().FirstOrDefault(p => p.GetCustomAttributes(typeof(KeyAttribute), false).Any());

            if (pkProperty == null)
                pkProperty = tipo.GetProperties().FirstOrDefault(p => p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase));

            if (pkProperty == null)
            {
                validacao.AddErro("Não foi possível encontrar a propriedade de chave primária.");
                return default;
            }

            var primaryKeyColumn = pkProperty.Name;
            var query = $"SELECT * FROM {tipo.Name} WHERE {primaryKeyColumn} = @Id";

            var parametros = new { Id = id };

            T entidade = default;

            try
            {
                entidade = ExecutarConsultaUnica(query, parametros, validacao);
            }
            catch (SqlException ex)
            {
                validacao.AddErro($"Erro ao buscar entidade: {ex.Message}");
            }

            return entidade;
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
        public virtual IEnumerable<T> ObterLista(object parametros, Validacao validacao = null)
        {
            string query = $"SELECT * FROM {typeof(T).Name} ";
            return ExecutarConsulta(query, parametros, validacao);
        }
        public virtual int Adicionar(T entidade, Validacao validacao = null)
        {
            int idInserido = 0;

            if (entidade == null)
            {
                validacao.AddErro("Obrigatório informar o tipo da entidade.");
                goto Sair;
            }

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                var tipo = typeof(T);
                var editableAttributeType = typeof(EditableAttribute);
                var keyAttributeType = typeof(KeyAttribute);

                var propriedades = tipo.GetProperties()
                    .Where(prop => !prop.GetCustomAttributes(editableAttributeType, true).Any() && !prop.GetCustomAttributes(keyAttributeType, true)
                    .OfType<EditableAttribute>()
                    .Any(att => att.AllowEdit))
                    .ToList();

                var pk_Coluna = tipo.GetProperties().Where(i => i.Name.StartsWith("PK")).FirstOrDefault().Name;
                var colunas = string.Join(", ", propriedades.Select(p => p.Name));
                var valores = string.Join(", ", propriedades.Select(p => "@" + p.Name));

                if (propriedades == null)
                {
                    validacao.AddErro("Nenhum propriedade encontrada.");
                    goto Sair;
                }
                else if(pk_Coluna == null)
                {
                    validacao.AddErro("Não foi possível encontrar a propriedade de chave primária.");
                    goto Sair;
                }
                else if(colunas.ObterValorOuPadrao("").Trim() == "" || valores.ObterValorOuPadrao("").Trim() == "")
                {
                    validacao.AddErro("Nenhuma coluna ou valor encontrado.");
                    goto Sair;
                }

                var query = $@"
                        INSERT INTO {tipo.Name} ({colunas}) 
                        OUTPUT INSERTED.{pk_Coluna}
                        VALUES ({valores})";

                var parametros = propriedades.ToDictionary(p => "@" + p.Name, p => p.GetValue(entidade));
                idInserido = ExecutarComando(query, parametros, validacao);
            }
            catch (Exception ex)
            {
                if (validacao == null)
                    validacao = new Validacao();

                validacao.AddErro(ex.Message);
            }

        Sair:;
            return idInserido;
        }
        public virtual int Atualizar(T entidade, Validacao validacao = null)
        {
            int linhasAfetadas = 0;

            if (entidade == null)
            {
                validacao?.AddErro("Obrigatório informar o tipo da entidade.");
                return 0;
            }

            try
            {
                if (validacao == null)
                    validacao = new Validacao();

                var tipo = typeof(T);
                var editableAttributeType = typeof(EditableAttribute);
                var keyAttributeType = typeof(KeyAttribute);

                var propriedades = tipo.GetProperties()
                    .Where(prop => !prop.GetCustomAttributes(editableAttributeType, true).Any() && !prop.GetCustomAttributes(keyAttributeType, true)
                    .OfType<EditableAttribute>()
                    .Any(att => att.AllowEdit))
                    .ToList();

                var pk_Coluna = tipo.GetProperties().Where(i => i.Name.StartsWith("PK")).FirstOrDefault();
                var colunas = string.Join(", ", propriedades.Select(p => p.Name + " = @" + p.Name));

                if (propriedades == null)
                {
                    validacao.AddErro("Nenhum propriedade encontrada.");
                    goto Sair;
                }
                else if (pk_Coluna == null)
                {
                    validacao.AddErro("Não foi possível encontrar a propriedade de chave primária.");
                    goto Sair;
                }
                else if (colunas.ObterValorOuPadrao("").Trim() == "")
                {
                    validacao.AddErro("Nenhuma coluna ou valor encontrado.");
                    goto Sair;
                }

                var query = $@"
                UPDATE {tipo.Name}
                SET {colunas} 
                WHERE {pk_Coluna.Name} = @{pk_Coluna.Name}";

                var parametros = propriedades.ToDictionary(p => "@" + p.Name, p => p.GetValue(entidade).ToString().ObterValorOuPadrao("").Trim());
                parametros.Add("@" + pk_Coluna.Name, pk_Coluna.GetValue(entidade).ToString().ObterValorOuPadrao("").Trim());

                linhasAfetadas = ExecutarComando(query, parametros, validacao);
            }
            catch (Exception ex)
            {
                validacao?.AddErro(ex.Message);
            }

        Sair:;
            return linhasAfetadas;
        }

    }
}
