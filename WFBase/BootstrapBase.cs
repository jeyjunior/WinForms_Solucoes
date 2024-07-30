using SimpleInjector;
using WFBase.Base;
using WFBase.Interface;

namespace WFBase
{
    public static class BootstrapBase
    {
        public static Container Container { get; private set; }

        public static void Iniciar(Container container)
        {
            Container = container;

            Container.Register<IConfigBase, ConfigBase>(Lifestyle.Singleton);
            Container.Register<IRecursosBase, RecursosBase>(Lifestyle.Singleton);
        }
    }
}
