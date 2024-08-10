using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace WFBaseDados
{
    internal class Base
    {
        private readonly string _connectionString;

        public Base(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<T> Query<T>(string query, object parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<T>(query, parameters);
            }
        }
    }
}
