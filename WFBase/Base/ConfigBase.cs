using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WFBase.Interface;
using WFBase.Models;

namespace WFBase
{
    public class ConfigBase : IConfigBase
    {
        private readonly string _configFilePath;
        private Config config = null;

        public ConfigBase()
        {
            var projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            _configFilePath = Path.Combine(projectRoot, "config.json");
        }

        private void ObterConfig()
        {
            try
            {
                if (File.Exists(_configFilePath))
                {
                    string json = File.ReadAllText(_configFilePath);
                    config = JsonConvert.DeserializeObject<Config>(json);
                }
            }
            catch
            {

            }
        }

        public string ObterPropriedade(ConfigSistema configSistema)
        {
            string ret = "";

            if (config == null)
                ObterConfig();

            switch (configSistema)
            {
                case ConfigSistema.DiretorioPadrao:
                    ret = config.Sistema.DiretorioPadrao;
                    break;
                default:
                    break;
            }

            return ret;
        }

        public string ObterPropriedade(ConfigApis configApis)
        {
            string ret = "";

            if(config == null)
                ObterConfig();

            switch (configApis)
            {
                case ConfigApis.PexelsURL:
                    ret = config.Pexels.URL;
                    break;
                case ConfigApis.PexelsKey:
                    ret = config.Pexels.Key;
                    break;
                default:
                    break;
            }

            return ret;
        }
    }
}
