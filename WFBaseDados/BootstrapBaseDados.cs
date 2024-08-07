using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBase.Interface;
using WFBase;
using System.Data.Common;
using System.IO;
namespace WFBaseDados
{
    public static class BootstrapBaseDados
    {
        public static Container Container { get; private set; }

        public static void Iniciar(Container container)
        {
            Container = container;



            Program.IniciarBaseDados();
        }
    }
}
