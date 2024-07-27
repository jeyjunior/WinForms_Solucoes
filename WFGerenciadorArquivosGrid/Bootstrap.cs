using SimpleInjector;

namespace WFGerenciadorArquivosGrid
{
    public static class Bootstrap
    {
        public static Container Container { get; private set; }

        public static void Iniciar()
        {
            Container = new Container();

            WFBase.BootstrapBase.Iniciar(Container);
            WFServices.BootstrapServices.Iniciar(Container);

            Container.Verify();
        }
    }
}
