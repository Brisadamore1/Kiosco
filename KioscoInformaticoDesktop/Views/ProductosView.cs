using KioscoInformaticoDesktop.DataContext;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();
        BindingSource ListaProductos = new BindingSource();
        List<Producto> ListaAFiltrar = new List<Producto>();
        Producto productoCurrent;

        public ProductosView()
        {
            InitializeComponent();
            dataGridProductosView.DataSource = ListaProductos;
            CargarDatosAGrilla();
        }

        private async Task CargarDatosAGrilla()
        {
            ListaProductos.DataSource = await productoService.GetAllAsync();
            dataGridProductosView.Columns[3].Visible = false;
            dataGridProductosView.Columns[4].Visible = false;
            dataGridProductosView.Columns["Id"].DefaultCellStyle.Format = "N0";
            ListaAFiltrar = (List<Producto>)ListaProductos.DataSource;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericUpDownPrecio.Value == 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (productoCurrent != null)
            {
                productoCurrent.Nombre = txtNombre.Text;
                productoCurrent.Precio = (decimal)numericUpDownPrecio.Value;

                await productoService.UpdateAsync(productoCurrent);
                productoCurrent = null;
            }
            else
            {
                var producto = new Producto()
                {
                    Nombre = txtNombre.Text,
                    Precio = (decimal)numericUpDownPrecio.Value
                };
                await productoService.AddAsync(producto);
            }
            await CargarDatosAGrilla();
            txtNombre.Text = string.Empty;
            numericUpDownPrecio.Value = 0;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)ListaProductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            numericUpDownPrecio.Value = productoCurrent.Precio;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)ListaProductos.Current;

            var result = MessageBox.Show($"¿Está seguro que desea eliminar el producto {productoCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productoCurrent = (Producto)ListaProductos.Current;
                if(productoCurrent != null)
                {
                    await productoService.DeleteAsync(productoCurrent.Id);
                    await CargarDatosAGrilla();
                }
                
            }
            productoCurrent = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            var productosFiltrados = ListaAFiltrar.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            ListaProductos.DataSource = productosFiltrados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
           FiltrarProductos();
        }
    }
}   
