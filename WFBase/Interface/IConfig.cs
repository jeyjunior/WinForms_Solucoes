using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBase.Interface
{
    public interface IConfig
    {
        string ObterPropriedade(ConfigPropriedade configPropriedade);
        string ObterPropriedade(ApiService apiService, ApiPropriedade apiPropriedade);
    }
}
