
using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp_.Class;

namespace KioscoInformaticoApp_
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            //////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
            WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
            {
                OnReceiveMessage(mensaje);
            });
        }

        private async void OnReceiveMessage(Message mensaje)
        {
            if (mensaje.Value == "AbrirProductos")
            {
                //await Navigation.PushAsync(new ProductosView());
            }
            if (mensaje.Value == "AbrirOfertas")
            {
               // await Navigation.PushAsync(new ProductosEnOfertaView());
            }
            if (mensaje.Value == "AgregarProducto")
            {
               // await Navigation.PushAsync(new AddEditProductoView());
            }
            if (mensaje.Value == "EditarProducto")
            {
                await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
            }
            if (mensaje.Value == "CerrarVentana")
            {
                await Navigation.PopAsync();
            }
            if (mensaje.Value == "AbrirAppShell")
            {
                await Navigation.PushAsync(new KioscoShell());
            }
        }
    }
}
