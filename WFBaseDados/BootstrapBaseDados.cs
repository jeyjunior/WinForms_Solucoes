using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;
using WFBase.Interface;
using WFBase;
using System.Data.Common;
using System.IO;
using WFBaseDados.Entidades.Config;
using SimpleInjector;
using WFBaseDados.Interfaces;
using WFBaseDados.Repositorios;

namespace WFBaseDados
{
    public static class BootstrapBaseDados
    {
        public static Container Container { get; private set; }

        public static void Iniciar(Container container)
        {
            Container = container;

            Container.Register<IConfiguracaoBancoDados, ConfiguracaoBancoDados>(Lifestyle.Singleton);
            Container.Register<IWFTesteRepository, WFTesteRepository>(Lifestyle.Singleton);
            Container.Register<IWFCategoriaRepository, WFCategoriaRepository>(Lifestyle.Singleton);
            Container.Register<IWFMetodoPagamentoRepository, WFMetodoPagamentoRepository>(Lifestyle.Singleton);
            Container.Register<IWFRegistroDebitosRepository, WFRegistroDebitosRepository>(Lifestyle.Singleton);
        }
    }
}
