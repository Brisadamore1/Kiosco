using KioscoInformaticoApp_.ViewModels;

namespace KioscoInformaticoApp_.View;

public partial class ProductosEnOfertaView : ContentPage
{
	public ProductosEnOfertaView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ProductosEnOfertaViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.ObtenerProductos();

        //}
    }

}