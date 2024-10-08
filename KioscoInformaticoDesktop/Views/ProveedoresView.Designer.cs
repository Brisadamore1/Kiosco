namespace KioscoInformaticoDesktop.Views
{
    partial class ProveedoresView
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
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            dataGridProveedoresView = new DataGridView();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            tabPageAgregarEditar = new TabPage();
            comboCondicionIva = new ComboBox();
            label1 = new Label();
            txtCbu = new MaskedTextBox();
            Cbu = new Label();
            txtTelefonos = new MaskedTextBox();
            Telefono = new Label();
            txtDireccion = new TextBox();
            Direccion = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            Nombre = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtFiltro = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            Proveedores = new Label();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedoresView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(2, 168);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(964, 317);
            tabControl.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(dataGridProveedoresView);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnEditar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(956, 279);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // dataGridProveedoresView
            // 
            dataGridProveedoresView.AllowUserToAddRows = false;
            dataGridProveedoresView.AllowUserToDeleteRows = false;
            dataGridProveedoresView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProveedoresView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProveedoresView.Location = new Point(18, 17);
            dataGridProveedoresView.Name = "dataGridProveedoresView";
            dataGridProveedoresView.ReadOnly = true;
            dataGridProveedoresView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProveedoresView.Size = new Size(790, 256);
            dataGridProveedoresView.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 24;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(842, 185);
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
            btnEditar.Location = new Point(842, 138);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 23);
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
            btnAgregar.Location = new Point(842, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(comboCondicionIva);
            tabPageAgregarEditar.Controls.Add(label1);
            tabPageAgregarEditar.Controls.Add(txtCbu);
            tabPageAgregarEditar.Controls.Add(Cbu);
            tabPageAgregarEditar.Controls.Add(txtTelefonos);
            tabPageAgregarEditar.Controls.Add(Telefono);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(Direccion);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(Nombre);
            tabPageAgregarEditar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(956, 289);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // comboCondicionIva
            // 
            comboCondicionIva.FormattingEnabled = true;
            comboCondicionIva.Location = new Point(423, 173);
            comboCondicionIva.Name = "comboCondicionIva";
            comboCondicionIva.Size = new Size(170, 26);
            comboCondicionIva.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 173);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 14;
            label1.Text = "Condicion iva:";
            // 
            // txtCbu
            // 
            txtCbu.Location = new Point(423, 135);
            txtCbu.Mask = "9999999999999";
            txtCbu.Name = "txtCbu";
            txtCbu.PromptChar = ' ';
            txtCbu.Size = new Size(170, 26);
            txtCbu.TabIndex = 13;
            txtCbu.TextAlign = HorizontalAlignment.Right;
            // 
            // Cbu
            // 
            Cbu.AutoSize = true;
            Cbu.Location = new Point(310, 135);
            Cbu.Name = "Cbu";
            Cbu.Size = new Size(35, 18);
            Cbu.TabIndex = 12;
            Cbu.Text = "Cbu:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(423, 95);
            txtTelefonos.Mask = "9999999999999";
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.PromptChar = ' ';
            txtTelefonos.Size = new Size(170, 26);
            txtTelefonos.TabIndex = 11;
            txtTelefonos.TextAlign = HorizontalAlignment.Right;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(310, 95);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(67, 18);
            Telefono.TabIndex = 10;
            Telefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(423, 55);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 26);
            txtDireccion.TabIndex = 9;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(310, 55);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(70, 18);
            Direccion.TabIndex = 8;
            Direccion.Text = "Direccion:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(468, 244);
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
            btnGuardar.Location = new Point(310, 247);
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
            txtNombre.Location = new Point(423, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 26);
            txtNombre.TabIndex = 5;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(310, 20);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(59, 18);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre:";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 24;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(848, 136);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 31);
            btnSalir.TabIndex = 13;
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
            btnBuscar.Location = new Point(724, 136);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 31);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(158, 136);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(541, 23);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Buscar producto";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Proveedores);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 108);
            panel1.TabIndex = 2;
            // 
            // Proveedores
            // 
            Proveedores.AutoSize = true;
            Proveedores.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proveedores.Location = new Point(406, 41);
            Proveedores.Name = "Proveedores";
            Proveedores.Size = new Size(155, 35);
            Proveedores.TabIndex = 0;
            Proveedores.Text = "Proveedores";
            // 
            // ProveedoresView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 487);
            Controls.Add(btnSalir);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(txtFiltro);
            Name = "ProveedoresView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProveedoresView";
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProveedoresView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtFiltro;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label Nombre;
        private DataGridView dataGridProveedoresView;
        private Panel panel1;
        private Label Proveedores;
        private Label Direccion;
        private TextBox txtDireccion;
        private MaskedTextBox txtTelefonos;
        private Label Telefono;
        private MaskedTextBox txtCbu;
        private Label Cbu;
        private Label label1;
        private ComboBox comboCondicionIva;
    }
}