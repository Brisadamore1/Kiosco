using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp_.Class;
using KioscoInformaticoApp_.ViewModels;

namespace KioscoInformaticoApp_.View;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
        //////C�DIGO QUE para preparar la recepci�n de mensajes y la llamada al m�todo RecibirMensaje
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "AbrirProductos")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AbrirOfertas")
        {
            await Navigation.PushAsync(new ProductosEnOfertaView());
        }
        if (mensaje.Value == "AgregarProducto")
        {
            await Navigation.PushAsync(new AddEditProductoView());
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