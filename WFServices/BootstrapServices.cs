using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase;
using WFBase.Interface;
using WFServices.Interfaces;
using WFServices.Interfaces.Sistema;
using WFServices.Services;
using WFServices.Services.Sistema;

namespace WFServices
{
    public static class BootstrapServices
    {
        public static Container Container { get; private set; }

        public static void Iniciar(Container container)
        {
            Container = container;

            Container.Register<IConfig, Config>(Lifestyle.Singleton);
            Container.Register<IPexelsService, PexelsService>(Lifestyle.Singleton);
            Container.Register<IGerenciadorService, GerenciadorService>(Lifestyle.Singleton);
        }
    }
}
