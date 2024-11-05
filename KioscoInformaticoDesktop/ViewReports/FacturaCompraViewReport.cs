using KioscoInformaticoServices.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class FacturaCompraViewReport : Form
    {
        ReportViewer reporte;
        private Compra? nuevaCompra;
        public FacturaCompraViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        public FacturaCompraViewReport(Compra? nuevaCompra)
        {
            this.nuevaCompra = nuevaCompra;
            InitializeComponent();

            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        private void FacturaCompraViewReportcs_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaCompraReport.rdlc";


            List<object> compra = new List<object> { new {
                Id = nuevaCompra.Id,
                Fecha = nuevaCompra.Fecha,
                ProveedorNombre = nuevaCompra.Proveedor.Nombre,
                Total = nuevaCompra.Total,
                Iva = nuevaCompra.Iva,
                FormaPago = nuevaCompra.FormaDePago.ToString() } };

            var detallesCompra = nuevaCompra.DetallesCompra.Select(detalle => new
            {
                ProductoNombre = detalle.Producto.Nombre,
                PrecioUnitario = detalle.PrecioUnitario,
                Cantidad = detalle.Cantidad,
                Subtotal = detalle.Subtotal
            });

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCompras", compra));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesCompra", detallesCompra));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
