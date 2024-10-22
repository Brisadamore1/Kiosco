using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoServices.Enums;
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
    public partial class VentasView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();
        GenericService<Venta> ventaService = new GenericService<Venta>();
        Venta venta = new Venta();

        public VentasView()
        {
            InitializeComponent();
            AjustePantalla();

        }

        private async void AjustePantalla()
        {

            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            await Task.WhenAll(
                Task.Run(async () => comboBoxClientes.DataSource = await clienteService.GetAllAsync()),
                Task.Run(async () => comboBoxProductos.DataSource = await productoService.GetAllAsync())
            );

            comboBoxClientes.DisplayMember = "Nombre";
            comboBoxClientes.ValueMember = "Id";

            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "Id";
            comboBoxProductos.SelectedIndex = -1;

            reloj.Stop();
            Debug.Print($"Tiempo de carga de combos: {reloj.ElapsedMilliseconds} ms");

            comboBoxFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            GridDetallesVenta.DataSource = venta.DetallesVenta.ToList();

        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboBoxProductos.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = comboBoxProductos.SelectedIndex != -1;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleVenta = new DetalleVenta
            {
                Producto = (Producto)comboBoxProductos.SelectedItem,
                ProductoId = (int)comboBoxProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };
            venta.DetallesVenta.Add(detalleVenta);
            GridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            comboBoxProductos.SelectedIndex = -1;
            comboBoxProductos.Focus();
            ActualizarTotalFactura();

        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = venta.DetallesVenta.Sum(dv => dv.Cantidad * dv.PrecioUnitario);
        }

        private void GridDetallesVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridDetallesVenta.OcultarColumnas(new string[] { "Id", "Venta", "VentaId", "ProductoId", "Eliminado" });
            btnQuitar.Enabled = GridDetallesVenta.Rows.Count > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (GridDetallesVenta.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var detallesVenta = (DetalleVenta)GridDetallesVenta.CurrentRow.DataBoundItem;
            venta.DetallesVenta.Remove(detallesVenta);
            GridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            ActualizarTotalFactura();
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            venta.ClienteId = (int)comboBoxClientes.SelectedValue;
            venta.FormaPago = (FormaDePagoEnum)comboBoxFormasDePago.SelectedValue;
            venta.Fecha = DateTime.Now;
            
            venta.Total = numericTotal.Value;
            venta.Iva = venta.Total * 0.21m;
            venta.Cliente = null;
            venta.DetallesVenta.ToList().ForEach(dv => dv.Producto = null);
           await ventaService.AddAsync(venta);
        }
    }
}
