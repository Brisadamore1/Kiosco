using KioscoInformaticoApp_.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp_.View;

public partial class AddEditProductoView : ContentPage
{
	public AddEditProductoView()
	{
		InitializeComponent();
	}
	public AddEditProductoView(Producto producto)
	{
        InitializeComponent();
		//asigno al viewmodel el producto que recibo con el bindingcontext que ya tiene definido
		var viewmodel = this.BindingContext as AddEditProductoViewModel;
        viewmodel.EditProduct = producto;



    }
}