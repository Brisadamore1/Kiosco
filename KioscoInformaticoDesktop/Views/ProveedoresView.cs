using KioscoInformaticoServices.Enums;
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
    public partial class ProveedoresView : Form
    {
        IGenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListaProveedores = new BindingSource();
        List<Proveedor> ListaAFiltrar = new List<Proveedor>();
        Proveedor proveedorCurrent;

        public ProveedoresView()
        {
            InitializeComponent();
            dataGridProveedoresView.DataSource = ListaProveedores;
            CargarDatosAGrilla();
            CargaCombo();
            comboCondicionIva.DataSource = Enum.GetValues(typeof(CondicionIvaEnum));
        }

        private async Task CargaCombo()
        {
            comboCondicionIva.DataSource = await proveedorService.GetAllAsync();
            comboCondicionIva.DisplayMember = "Nombre";
            comboCondicionIva.ValueMember = "Id";
        }

        private async Task CargarDatosAGrilla()
        {
            ListaProveedores.DataSource = await proveedorService.GetAllAsync();
           // dataGridProveedoresView.Columns[6].Visible = false;
            //dataGridProveedoresView.Columns[7].Visible = false;
       
            ListaAFiltrar = (List<Proveedor>)ListaProveedores.DataSource;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del proveedor es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (proveedorCurrent != null)
            {
                proveedorCurrent.Nombre = txtNombre.Text;
                proveedorCurrent.Direccion = txtDireccion.Text;
                proveedorCurrent.Telefonos = txtTelefonos.Text;
                proveedorCurrent.Cbu = txtCbu.Text;
                proveedorCurrent.CondicionIva = (CondicionIvaEnum)comboCondicionIva.SelectedValue;

                await proveedorService.UpdateAsync(proveedorCurrent);
                proveedorCurrent = null;
            }
            else
            {
                var proveedor = new Proveedor()
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefonos.Text,
                    Cbu = txtCbu.Text,
                    CondicionIva = (CondicionIvaEnum)comboCondicionIva.SelectedValue

                };
                await proveedorService.AddAsync(proveedor);
            }
            await CargarDatosAGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtCbu.Text = string.Empty;
            comboCondicionIva.SelectedIndex = -1;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)ListaProveedores.Current;
            txtNombre.Text = proveedorCurrent.Nombre;
            txtDireccion.Text = proveedorCurrent.Direccion;
            txtTelefonos.Text = proveedorCurrent.Telefonos;
            txtCbu.Text = proveedorCurrent.Cbu;
            comboCondicionIva.SelectedValue = proveedorCurrent.CondicionIva;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)ListaProveedores.Current;

            var result = MessageBox.Show($"¿Está seguro que desea eliminar el proveedor {proveedorCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                proveedorCurrent = (Proveedor)ListaProveedores.Current;
                if (proveedorCurrent != null)
                {
                    await proveedorService.DeleteAsync(proveedorCurrent.Id);
                    await CargarDatosAGrilla();
                }
            }
            proveedorCurrent = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtCbu.Text = string.Empty;
            comboCondicionIva.SelectedIndex = -1;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void FiltrarProveedores()
        {
            var proveedoresFiltrados = ListaAFiltrar.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            ListaProveedores.DataSource = proveedoresFiltrados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }
    }
}
