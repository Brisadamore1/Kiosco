using KioscoInformaticoApp_.View;

namespace KioscoInformaticoApp_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IniciarSesionView();
        }
    }
}
