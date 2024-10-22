namespace KioscoInformaticoDesktop.Views
{
    partial class VentasView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimeFecha = new DateTimePicker();
            label1 = new Label();
            comboBoxFormasDePago = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxClientes = new ComboBox();
            label4 = new Label();
            comboBoxProductos = new ComboBox();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            numericSubtotal = new NumericUpDown();
            label6 = new Label();
            numericCantidad = new NumericUpDown();
            label5 = new Label();
            numericPrecio = new NumericUpDown();
            GridDetallesVenta = new DataGridView();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotal = new NumericUpDown();
            btnFinalizar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridDetallesVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(634, 30);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(113, 28);
            dateTimeFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(564, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // comboBoxFormasDePago
            // 
            comboBoxFormasDePago.FormattingEnabled = true;
            comboBoxFormasDePago.Location = new Point(152, 89);
            comboBoxFormasDePago.Name = "comboBoxFormasDePago";
            comboBoxFormasDePago.Size = new Size(121, 23);
            comboBoxFormasDePago.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 92);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 3;
            label2.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(321, 92);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(416, 92);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(121, 23);
            comboBoxClientes.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PeachPuff;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 131);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 7;
            label4.Text = "Producto:";
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(17, 166);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(202, 23);
            comboBoxProductos.TabIndex = 6;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericPrecio);
            panel1.Location = new Point(12, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 92);
            panel1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(661, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 31);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PeachPuff;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(535, 8);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 13;
            label7.Text = "Subtotal:";
            // 
            // numericSubtotal
            // 
            numericSubtotal.DecimalPlaces = 2;
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(519, 43);
            numericSubtotal.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.Size = new Size(120, 23);
            numericSubtotal.TabIndex = 12;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PeachPuff;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(390, 8);
            label6.Name = "label6";
            label6.Size = new Size(77, 22);
            label6.TabIndex = 11;
            label6.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            numericCantidad.DecimalPlaces = 2;
            numericCantidad.Location = new Point(374, 43);
            numericCantidad.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(120, 23);
            numericCantidad.TabIndex = 10;
            numericCantidad.TextAlign = HorizontalAlignment.Right;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PeachPuff;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(249, 8);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 9;
            label5.Text = "Precio:";
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(233, 43);
            numericPrecio.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(120, 23);
            numericPrecio.TabIndex = 0;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // GridDetallesVenta
            // 
            GridDetallesVenta.AllowUserToAddRows = false;
            GridDetallesVenta.AllowUserToDeleteRows = false;
            GridDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GridDetallesVenta.DefaultCellStyle = dataGridViewCellStyle2;
            GridDetallesVenta.Location = new Point(42, 219);
            GridDetallesVenta.Name = "GridDetallesVenta";
            GridDetallesVenta.ReadOnly = true;
            GridDetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridDetallesVenta.Size = new Size(632, 141);
            GridDetallesVenta.TabIndex = 9;
            GridDetallesVenta.DataBindingComplete += GridDetallesVenta_DataBindingComplete;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            btnQuitar.IconColor = Color.Black;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 24;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(680, 271);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(108, 28);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "&Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PeachPuff;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(356, 397);
            label8.Name = "label8";
            label8.Size = new Size(107, 22);
            label8.TabIndex = 16;
            label8.Text = "Total Factura";
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(356, 440);
            numericTotal.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(120, 23);
            numericTotal.TabIndex = 15;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinalizar.IconColor = Color.Black;
            btnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizar.IconSize = 24;
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.Location = new Point(634, 410);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(108, 31);
            btnFinalizar.TabIndex = 17;
            btnFinalizar.Text = "&Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 475);
            Controls.Add(btnFinalizar);
            Controls.Add(label8);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(GridDetallesVenta);
            Controls.Add(label4);
            Controls.Add(comboBoxProductos);
            Controls.Add(label3);
            Controls.Add(comboBoxClientes);
            Controls.Add(label2);
            Controls.Add(comboBoxFormasDePago);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Controls.Add(panel1);
            Name = "VentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridDetallesVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFecha;
        private Label label1;
        private ComboBox comboBoxFormasDePago;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxClientes;
        private Label label4;
        private ComboBox comboBoxProductos;
        private Panel panel1;
        private Label label5;
        private NumericUpDown numericPrecio;
        private Label label6;
        private NumericUpDown numericCantidad;
        private Label label7;
        private NumericUpDown numericSubtotal;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView GridDetallesVenta;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private Label label8;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton btnFinalizar;
    }
}