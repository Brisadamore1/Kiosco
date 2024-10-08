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
    public partial class ClientesView : Form
    {
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListaClientes = new BindingSource();
        List<Cliente> ListaAFiltrar = new List<Cliente>();
        Cliente clienteCurrent;

        public ClientesView()
        {
            InitializeComponent();
            dataGridClientesView.DataSource = ListaClientes;
            CargarGrilla();
            CargarCombo();
        }

        private async void CargarCombo()
        {
            cboLocalidades.DataSource =  await localidadService.GetAllAsync();
            cboLocalidades.DisplayMember = "Nombre";
            cboLocalidades.ValueMember = "Id";
        }

        private async Task CargarGrilla()
        {
            ListaClientes.DataSource = await clienteService.GetAllAsync();
            dataGridClientesView.Columns[5].Visible = false;
            dataGridClientesView.Columns["Id"].DefaultCellStyle.Format = "N0";
            ListaAFiltrar = (List<Cliente>)ListaClientes.DataSource;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListaClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            txtDireccion.Text = clienteCurrent.Direccion;
            txtTelefono.Text = clienteCurrent.Telefonos;
            cboLocalidades.SelectedValue = clienteCurrent.LocalidadId;
            dateTimeFechaNacimiento.Value = clienteCurrent.FechaNacimiento;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                clienteCurrent.Direccion = txtDireccion.Text;
                clienteCurrent.Telefonos = txtTelefono.Text;
                clienteCurrent.LocalidadId = (int)cboLocalidades.SelectedValue;
                clienteCurrent.FechaNacimiento = dateTimeFechaNacimiento.Value;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {
                var cliente = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    LocalidadId = (int)cboLocalidades.SelectedValue,
                    FechaNacimiento =dateTimeFechaNacimiento.Value
                };
                await clienteService.AddAsync(cliente);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cboLocalidades.SelectedIndex = 0;
            tabControl.SelectTab(tabPageLista);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListaClientes.Current;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar el cliente {clienteCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clienteCurrent = (Cliente)ListaClientes.Current;
                if (clienteCurrent != null)
                {
                    await clienteService.DeleteAsync(clienteCurrent.Id);
                    await CargarGrilla();
                }
            }
            clienteCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarCliente();
        }

        private void FiltrarCliente()
        {
            var clientesFiltrados = ListaAFiltrar.Where(c => c.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            ListaClientes.DataSource = clientesFiltrados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarCliente();
        }
    }
}