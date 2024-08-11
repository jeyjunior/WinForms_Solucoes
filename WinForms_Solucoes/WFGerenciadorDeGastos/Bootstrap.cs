using SimpleInjector;

namespace WFGerenciadorDeGastos
{
    public static class Bootstrap
    {
        public static Container Container { get; private set; }

        public static void Iniciar()
        {
            Container = new Container();

            WFBase.BootstrapBase.Iniciar(Container);
            WFServices.BootstrapServices.Iniciar(Container);
            WFBaseDados.BootstrapBaseDados.Iniciar(Container);

            Container.Verify();
        }
    }
}
