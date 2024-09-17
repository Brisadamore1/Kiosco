namespace KioscoInformaticoDesktop.Views
{
    partial class ProductosView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Productos = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridProductosView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            numericUpDownPrecio = new NumericUpDown();
            label2 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label1 = new Label();
            txtFiltro = new TextBox();
            label3 = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Productos);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 83);
            panel1.TabIndex = 2;
            // 
            // Productos
            // 
            Productos.AutoSize = true;
            Productos.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Productos.Location = new Point(417, 32);
            Productos.Name = "Productos";
            Productos.Size = new Size(127, 35);
            Productos.TabIndex = 0;
            Productos.Text = "Productos";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(2, 180);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(965, 276);
            tabControl.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnEditar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dataGridProductosView);
            tabPageLista.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(957, 248);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 24;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(840, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 28);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "El&iminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 24;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(840, 113);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 28);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(840, 61);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridProductosView
            // 
            dataGridProductosView.AllowUserToAddRows = false;
            dataGridProductosView.AllowUserToDeleteRows = false;
            dataGridProductosView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductosView.BackgroundColor = SystemColors.Window;
            dataGridProductosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = Color.LavenderBlush;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridProductosView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridProductosView.Location = new Point(6, 32);
            dataGridProductosView.Name = "dataGridProductosView";
            dataGridProductosView.ReadOnly = true;
            dataGridProductosView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProductosView.Size = new Size(812, 215);
            dataGridProductosView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(numericUpDownPrecio);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label1);
            tabPageAgregarEditar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(957, 248);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Location = new Point(421, 120);
            numericUpDownPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(120, 26);
            numericUpDownPrecio.TabIndex = 9;
            numericUpDownPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 122);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 8;
            label2.Text = "Precio:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(435, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(288, 196);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 39);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(421, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 26);
            txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(6, 128);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(541, 23);
            txtFiltro.TabIndex = 4;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 110);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 6;
            label3.Text = "Buscar producto";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 24;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(747, 123);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 31);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 24;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(605, 123);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 31);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 487);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(txtFiltro);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "ProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductosView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductosView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Productos;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private DataGridView dataGridProductosView;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private NumericUpDown numericUpDownPrecio;
        private Label label2;
        private TextBox txtFiltro;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}