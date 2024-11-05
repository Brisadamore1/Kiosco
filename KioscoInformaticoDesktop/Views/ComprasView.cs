using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ComprasView : Form
    {
        GenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        ProductoService productoService = new ProductoService();
        GenericService<Compra> compraService = new GenericService<Compra>();
        Compra compra = new Compra();
        public ComprasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            #region cargar combos 
            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            await Task.WhenAll(
                Task.Run(async () => comboBoxProveedores.DataSource = await proveedorService.GetAllAsync()),
                Task.Run(async () => comboBoxProductos.DataSource = await
                productoService.GetAllAsync())
            );

            comboBoxProveedores.DisplayMember = "Nombre";
            comboBoxProveedores.ValueMember = "Id";

            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "Id";
            comboBoxProductos.SelectedIndex = -1;

            reloj.Stop();
            Debug.Print($"Tiempo de carga de combos: {reloj.ElapsedMilliseconds} ms");

            comboBoxFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));
            #endregion
            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            GridDetallesCompra.DataSource = compra.DetallesCompra.ToList();
        }
        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = comboBoxProductos.SelectedIndex != -1;

        }
        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
            btnAgregar.Enabled = numericPrecio.Value > 0;
        }

        private void numericSubtotal_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleCompra = new DetalleCompra
            {
                Producto = (Producto)comboBoxProductos.SelectedItem,
                ProductoId = (int)comboBoxProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };
            compra.DetallesCompra.Add(detalleCompra);
            GridDetallesCompra.DataSource = compra.DetallesCompra.ToList();
            comboBoxProductos.SelectedIndex = -1;
            comboBoxProductos.Focus();
            ActualizarTotalFactura();
        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = compra.DetallesCompra.Sum(dv => dv.Cantidad * dv.PrecioUnitario);
        }

        private void GridDetallesCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridDetallesCompra.OcultarColumnas(new string[] { "Id", "Compra", "CompraId", "ProductoId", "Eliminado" });
            btnQuitar.Enabled = GridDetallesCompra.Rows.Count > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (GridDetallesCompra.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var detallesCompra = (DetalleCompra)GridDetallesCompra.CurrentRow.DataBoundItem;
            compra.DetallesCompra.Remove(detallesCompra);
            GridDetallesCompra.DataSource = compra.DetallesCompra.ToList();
            ActualizarTotalFactura();
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            compra.ProveedorId = (int)comboBoxProveedores.SelectedValue;
            compra.Proveedor = (Proveedor)comboBoxProveedores.SelectedItem;
            compra.FormaDePago = (FormaDePagoEnum)comboBoxFormasDePago.SelectedValue;
            compra.Fecha = DateTime.Now;

            compra.Total = numericTotal.Value;
            compra.Iva = compra.Total * 0.21m;

            var nuevaCompra = await compraService.AddAsync(compra);
            var facturaCompraViewReport = new FacturaCompraViewReport(nuevaCompra);
            facturaCompraViewReport.ShowDialog();
        }
    }
}
