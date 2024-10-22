using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp_.Class;
using KioscoInformaticoApp_.View;

namespace KioscoInformaticoApp_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IniciarSesionView());
            //MainPage = new ProductosEnOfertaView();

        }

    }
}
