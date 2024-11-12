﻿using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp_.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp_.ViewModels
{
    public class AddEditProductoViewModel : ObjectNotification
    {
        ProductoService productoService = new ProductoService();
        private Producto editProduct;

        public Producto EditProduct
        {
            get { return editProduct; }
            set { editProduct = value;
                OnPropertyChanged();
                SettingData(); }
        }

        private void SettingData()
        {
            if (editProduct == null)
            {
                Nombre = string.Empty;
                Precio = 0;
                Oferta = false;
            }
            else
            {
                Nombre = editProduct.Nombre;
                Precio = editProduct.Precio;
                Oferta = editProduct.Oferta;
            }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged();
            }
        }
        private bool oferta;
        public bool Oferta
        {
            get { return oferta; }
            set { oferta = value;
                OnPropertyChanged();
            }
        }

        public Command SaveProductCommand { get; }
        public AddEditProductoViewModel()
        {
            SaveProductCommand = new Command(async () => await SaveProducto());
        }

        private async Task SaveProducto()
        {

            if (EditProduct!= null)
            {
                EditProduct.Nombre = this.Nombre;
                EditProduct.Precio = this.Precio;
                EditProduct.Oferta = this.Oferta;

                await productoService.UpdateAsync(editProduct);

            }else
            {
                var producto = new Producto()
                {
                    Nombre = this.Nombre,
                    Precio = this.Precio,
                    Oferta = this.Oferta
                };
                await productoService.AddAsync(producto);
            }
            await Shell.Current.GoToAsync("//ListaProductos");
            //WeakReferenceMessenger.Default.Send(new Message("CerrarVentana"));
        }
    }
}
