using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFServices;

namespace WFBase.Interface
{
    public interface IConfig
    {
        string ObterPropriedade(ApiService apiService, ApiPropriedade apiPropriedade);
    }
}
