using SimpleInjector;

namespace WFBase
{
    public static class Bootstrap
    {
        public static Container Container { get; private set; }

        public static void Iniciar(Container container)
        {
            Container = container;

            Container.Verify();
        }
    }
}
