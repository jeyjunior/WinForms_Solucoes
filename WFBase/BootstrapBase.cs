using SimpleInjector;
using WFBase.Interface;

namespace WFBase
{
    public static class BootstrapBase
    {
        public static Container Container { get; private set; }

        public static void Iniciar(Container container)
        {
            Container = container;

            Container.Register<IConfig, Config>(Lifestyle.Singleton);
        }
    }
}
