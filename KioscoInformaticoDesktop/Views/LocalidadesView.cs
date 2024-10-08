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
    public partial class LocalidadesView : Form
    {
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListaLocalidades = new BindingSource();
        Localidad localidadCurrent;
        public LocalidadesView()
        {
            InitializeComponent();
            dataGridLocalidadesView.DataSource = ListaLocalidades;
            CargarDatosAGrilla();
        }

        private async Task CargarDatosAGrilla()
        {
            ListaLocalidades.DataSource = await localidadService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (localidadCurrent != null)
            {
                localidadCurrent.Nombre = txtNombre.Text;
                await localidadService.UpdateAsync(localidadCurrent);
                localidadCurrent = null;
            }
            else
            {
                var localidad = new Localidad()
                {
                    Nombre = txtNombre.Text
                };
                await localidadService.AddAsync(localidad);
            }
            await CargarDatosAGrilla();
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Localidad hace una conversion de tipos.Se almacena en localidad current la localidad que estamos editando. En la segunda línea pusimos la localidad que se seleccionó actualmente y la mandamos al txt. En tercera línea nos pasamos al otro lado de agragar y editar.
            localidadCurrent = (Localidad)ListaLocalidades.Current;
            txtNombre.Text = localidadCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)ListaLocalidades.Current;

            var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad {localidadCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await localidadService.DeleteAsync(localidadCurrent.Id);
                await CargarDatosAGrilla();
            }
            localidadCurrent = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            localidadCurrent = null;
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        private async void FiltrarLocalidades()
        {
            ListaLocalidades.DataSource = await localidadService.GetAllAsync(txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
