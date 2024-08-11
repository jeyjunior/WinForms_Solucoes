using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Dapper;
using WFBaseDados.Interfaces;

namespace WFBaseDados.Entidades.Config
{
    internal class ConfiguracaoBancoDados : IConfiguracaoBancoDados
    {
        private string caminhoArquivo = "";
        private Config config;

        private class Config
        {
            public string StringConexao { get; set; }
        }

        public ConfiguracaoBancoDados()
        {
            CarregarConfiguracao();
        }

        private  void CarregarConfiguracao()
        {
            try
            {
                var assemblyLocation = AppDomain.CurrentDomain.BaseDirectory;

                var projectRoot = Path.GetFullPath(Path.Combine(assemblyLocation, @"..\..\..\"));

                caminhoArquivo = Path.Combine(projectRoot, "configBaseDados.json");

                if (File.Exists(caminhoArquivo))
                {
                    var json = File.ReadAllText(caminhoArquivo);
                    config = JsonConvert.DeserializeObject<Config>(json);
                }
            }
            catch
            {

            }
        }

        public  string ObterStringConexao()
        {
            CarregarConfiguracao();
            return config.StringConexao;
        }
    }
}

