namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            panel1 = new Panel();
            Clientes = new Label();
            dataGridVentas = new DataGridView();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            panelFiltrado = new Panel();
            btnFiltrar = new Button();
            dateTimeHasta = new DateTimePicker();
            label2 = new Label();
            dateTimeDesde = new DateTimePicker();
            label1 = new Label();
            checkFiltrado = new CheckBox();
            numericTotalFacturado = new NumericUpDown();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Clientes);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 74);
            panel1.TabIndex = 3;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(282, 20);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(245, 35);
            Clientes.TabIndex = 0;
            Clientes.Text = "Histórico de Ventas";
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridVentas.Location = new Point(30, 194);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(669, 207);
            dataGridVentas.TabIndex = 4;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.IconSize = 24;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(657, 420);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(108, 31);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "&Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // panelFiltrado
            // 
            panelFiltrado.BorderStyle = BorderStyle.Fixed3D;
            panelFiltrado.Controls.Add(btnFiltrar);
            panelFiltrado.Controls.Add(dateTimeHasta);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Controls.Add(dateTimeDesde);
            panelFiltrado.Controls.Add(label1);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(124, 105);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(664, 71);
            panelFiltrado.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(564, 26);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(405, 23);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(85, 23);
            dateTimeHasta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 29);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Hasta:";
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(168, 23);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(85, 23);
            dateTimeDesde.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // checkFiltrado
            // 
            checkFiltrado.AutoSize = true;
            checkFiltrado.Location = new Point(12, 130);
            checkFiltrado.Name = "checkFiltrado";
            checkFiltrado.Size = new Size(106, 19);
            checkFiltrado.TabIndex = 0;
            checkFiltrado.Text = "Activar Filtrado";
            checkFiltrado.UseVisualStyleBackColor = true;
            checkFiltrado.CheckedChanged += checkFiltro_CheckedChanged;
            // 
            // numericTotalFacturado
            // 
            numericTotalFacturado.DecimalPlaces = 2;
            numericTotalFacturado.Enabled = false;
            numericTotalFacturado.Location = new Point(468, 426);
            numericTotalFacturado.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericTotalFacturado.Name = "numericTotalFacturado";
            numericTotalFacturado.Size = new Size(120, 23);
            numericTotalFacturado.TabIndex = 16;
            numericTotalFacturado.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 428);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 17;
            label3.Text = "Total Facturado:";
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(label3);
            Controls.Add(numericTotalFacturado);
            Controls.Add(checkFiltrado);
            Controls.Add(panelFiltrado);
            Controls.Add(btnImprimir);
            Controls.Add(dataGridVentas);
            Controls.Add(panel1);
            Name = "HistoricoVentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HistoricoVentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Clientes;
        private DataGridView dataGridVentas;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private Panel panelFiltrado;
        private CheckBox checkFiltrado;
        private DateTimePicker dateTimeHasta;
        private Label label2;
        private DateTimePicker dateTimeDesde;
        private Label label1;
        private Button btnFiltrar;
        private NumericUpDown numericTotalFacturado;
        private Label label3;
    }
}