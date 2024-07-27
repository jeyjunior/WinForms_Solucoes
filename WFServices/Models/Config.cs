﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WFBase.Interface;
using WFServices;

namespace WFBase
{
    public class Config : IConfig
    {
        private readonly string _configFilePath;
        private JObject config = null;

        public Config()
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
                    var json = File.ReadAllText(_configFilePath);
                    this.config = JObject.Parse(json);
                }
            }
            catch
            {

            }
        }


        public string ObterPropriedade(ApiService apiService, ApiPropriedade apiPropriedade)
        {
            string ret = "";

            if(config == null)
                ObterConfig();

            if (config != null)
            {
                string parametro = apiService.ToString() + apiPropriedade.ToString();
                ret = config[parametro]?.ToString();
            }

            return ret;
        }
    }
}
