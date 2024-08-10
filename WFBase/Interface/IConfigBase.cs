using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBase.Interface
{
    public interface IConfigBase
    {
        string ObterPropriedade(ConfigSistema configSistema);
        string ObterPropriedade(ConfigApis configApis);
    }
}
