﻿using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp_.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KioscoInformaticoApp_.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
        //El view model necesita tambien obtener los datos y es necesario instanciar el servicio.
		private ProductoService productoService = new ProductoService();
        private string filterProducts;

        //La propiedad es lo mismo pero con mayuscula. Propiedad armada para el cuadro de texto.
        public string FilterProducts
        {
            //Del entorno que tenemos almacena el fltro de productos, lo que escribimos.
            get { return filterProducts; }
			set { filterProducts = value;

                //Cuando se setea filterproduct se llama a OnPropertyChanged que dispara el evento PropertyChanged
                OnPropertyChanged();
             _ = FiltrarProducto();

            }
            //OnPropertyChanged: Este método se llama dentro del set de la propiedad, y dispara el evento PropertyChanged. Esto notifica a cualquier observador (como la UI) que la propiedad ha cambiado.
        }
        
        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
        
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }
       
        //Necesitamos almacenar la lista de productos original para poder filtrarla

        //Normalmente los observables collection son inmutables, es decir no le podemos hacer cambios. Por eso creamos una lista, este objeto contiene el where 

        private ObservableCollection<Producto> productos;

		public ObservableCollection<Producto> Productos
		{
			get { return productos; }
			set { productos = value;

                OnPropertyChanged();
            }
		}
        private List<Producto>? productosListToFilter;

        private Producto selectedProduct;

        public Producto SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value;

                OnPropertyChanged();
                EditarProductoCommand.ChangeCanExecute();
            }
        }


        public Command ObtenerProductosCommand { get; }
        public Command FiltrarProductosCommand { get; }

        public Command AgregarProductosCommand { get; }
        public Command EditarProductoCommand { get; }

        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FiltrarProducto());
            AgregarProductosCommand = new Command(async () => await AgregarProducto());
            EditarProductoCommand = new Command(async (obj) => await EditarProducto(), PermitirEditar);
            ObtenerProductos();
        }

        private bool PermitirEditar(object arg)
        {
            return SelectedProduct != null;
        }

        private async Task EditarProducto()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                {"ProductoEdit", SelectedProduct }
            };
            await Shell.Current.GoToAsync("//AgregarEditarProducto", navigationParameter);
            // WeakReferenceMessenger.Default.Send(new Message("EditarProducto") { ProductoAEditar= selectedProduct});
        }

        private async Task AgregarProducto()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                {"ProductoEdit", null}
            };
            await Shell.Current.GoToAsync("//AgregarEditarProducto", navigationParameter);
            // WeakReferenceMessenger.Default.Send(new Message("AgregarProducto"));
        }

        public async Task FiltrarProducto()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.ToUpper().Contains(filterProducts.ToUpper()));
            Productos = new ObservableCollection<Producto>(productosFiltrados);
            

            //productoslisttofilter es la lista original, siempre queda llena y productos siempre va cambiando. Es el resultado del filtro de la lista original.
        }

        public async Task ObtenerProductos()
        {
           FilterProducts = string.Empty;
           IsRefreshing = true;
           productosListToFilter = await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
           IsRefreshing = false;

            //Llega la lista y se almacena en productosListToFilter es una variable temporal.
        }
    }
}

//Productos view model hereda del object notification que es el que tiene el OnPropertyChanged (En propiedad cambiada)

//OnPropertyChanged es un método comúnmente utilizado en aplicaciones que implementan el patrón MVVM (Model-View-ViewModel) para notificar a la vista que una propiedad ha cambiado de valor. 

//Esto es crucial para la vinculación de datos (data binding), ya que permite que la interfaz de usuario se actualice automáticamente cuando los datos en el modelo cambian.

//"setear" se refiere a la acción de asignar o establecer un valor a una variable, propiedad, o configuración. 

//bug del activity indicator que queda corriendo todo el tiempo se soluciona con esto.