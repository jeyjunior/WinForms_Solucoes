using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBase.Models
{
    internal class Config
    {
        public ConfigSistema Sistema { get; set; }
        public ConfigBaseDados BaseDados { get; set; }
        public ConfigPexels Pexels { get; set; }

        public class ConfigSistema
        {
            public string DiretorioPadrao { get; set; }
        }
        public class ConfigBaseDados
        {
            public string StringConexao { get; set; }
        }

        public class ConfigPexels
        {
            public string URL { get; set; }
            public string Key { get; set; }
        }
    }
}
