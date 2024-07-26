using SimpleInjector;

namespace WFGerenciadorArquivosGrid
{
    public static class Bootstrap
    {
        public static Container Container { get; private set; }

        public static void Iniciar()
        {
            Container = new Container();

            WFBase.Bootstrap.Iniciar(Container);
        }
    }
}
