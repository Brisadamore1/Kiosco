namespace KioscoInformaticoDesktop.Views
{
    partial class ClientesView
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
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtFiltro = new TextBox();
            label3 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridClientesView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            dateTimeFechaNacimiento = new DateTimePicker();
            label6 = new Label();
            cboLocalidades = new ComboBox();
            label5 = new Label();
            txtTelefono = new MaskedTextBox();
            txtDireccion = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            Clientes = new Label();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(2, 101);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(914, 352);
            tabControl.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnSalir);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnEditar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dataGridClientesView);
            tabPageLista.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(906, 324);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 24;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(789, 24);
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
            btnBuscar.Location = new Point(675, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 31);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(119, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(501, 26);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(107, 18);
            label3.TabIndex = 7;
            label3.Text = "Buscar producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 24;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(782, 200);
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
            btnEditar.Location = new Point(782, 155);
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
            btnAgregar.Location = new Point(782, 108);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridClientesView
            // 
            dataGridClientesView.AllowUserToAddRows = false;
            dataGridClientesView.AllowUserToDeleteRows = false;
            dataGridClientesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridClientesView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridClientesView.Location = new Point(0, 69);
            dataGridClientesView.Name = "dataGridClientesView";
            dataGridClientesView.ReadOnly = true;
            dataGridClientesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientesView.Size = new Size(747, 255);
            dataGridClientesView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(dateTimeFechaNacimiento);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(cboLocalidades);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(txtTelefono);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label1);
            tabPageAgregarEditar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(906, 324);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(403, 206);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(170, 26);
            dateTimeFechaNacimiento.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 212);
            label6.Name = "label6";
            label6.Size = new Size(135, 18);
            label6.TabIndex = 4;
            label6.Text = "Fecha de nacimiento:";
            // 
            // cboLocalidades
            // 
            cboLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocalidades.FormattingEnabled = true;
            cboLocalidades.Location = new Point(403, 168);
            cboLocalidades.Name = "cboLocalidades";
            cboLocalidades.Size = new Size(170, 26);
            cboLocalidades.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 168);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 3;
            label5.Text = "Localidad:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(403, 124);
            txtTelefono.Mask = "9999999999999";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PromptChar = ' ';
            txtTelefono.Size = new Size(170, 26);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(403, 76);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 26);
            txtDireccion.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 84);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 1;
            label4.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 2;
            label2.Text = "Teléfono:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(432, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 11;
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
            btnGuardar.Location = new Point(278, 268);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 39);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(403, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 26);
            txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Clientes);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 83);
            panel1.TabIndex = 2;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(410, 24);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(106, 35);
            Clientes.TabIndex = 0;
            Clientes.Text = "Clientes";
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 465);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "ClientesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientesView";
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private DataGridView dataGridClientesView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label1;
        private Panel panel1;
        private Label Clientes;
        private TextBox txtDireccion;
        private Label label4;
        private Label label2;
        private MaskedTextBox txtTelefono;
        private Label label5;
        private ComboBox cboLocalidades;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label label6;
    }
}