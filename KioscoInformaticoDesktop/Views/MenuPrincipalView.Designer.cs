namespace KioscoInformaticoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            localidadesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            iconToolHistoricoVentas = new FontAwesome.Sharp.IconToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3, iconMenuItem2, iconMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuVentas });
            iconMenuItem1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 30;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(103, 34);
            iconMenuItem1.Text = "Principal";
            // 
            // iconMenuVentas
            // 
            iconMenuVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconMenuVentas.IconColor = Color.Black;
            iconMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuVentas.Name = "iconMenuVentas";
            iconMenuVentas.Size = new Size(180, 22);
            iconMenuVentas.Text = "Ventas";
            iconMenuVentas.Click += iconMenuItem5_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuLocalidades, ItemMenuProductos, ItemMenuClientes, ItemMenuProveedores });
            iconMenuItem3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 30;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(84, 34);
            iconMenuItem3.Text = "Bases";
            // 
            // ItemMenuLocalidades
            // 
            ItemMenuLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            ItemMenuLocalidades.IconColor = Color.Black;
            ItemMenuLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuLocalidades.Name = "ItemMenuLocalidades";
            ItemMenuLocalidades.Size = new Size(150, 22);
            ItemMenuLocalidades.Text = "Localidades";
            ItemMenuLocalidades.Click += ItemMenuLocalidades_Click;
            // 
            // ItemMenuProductos
            // 
            ItemMenuProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            ItemMenuProductos.IconColor = Color.Black;
            ItemMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuProductos.Name = "ItemMenuProductos";
            ItemMenuProductos.Size = new Size(150, 22);
            ItemMenuProductos.Text = "Productos";
            ItemMenuProductos.Click += ItemMenuProductos_Click;
            // 
            // ItemMenuClientes
            // 
            ItemMenuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ItemMenuClientes.IconColor = Color.Black;
            ItemMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuClientes.Name = "ItemMenuClientes";
            ItemMenuClientes.Size = new Size(150, 22);
            ItemMenuClientes.Text = "Clientes";
            ItemMenuClientes.Click += ItemMenuClientes_Click;
            // 
            // ItemMenuProveedores
            // 
            ItemMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingLuggage;
            ItemMenuProveedores.IconColor = Color.Black;
            ItemMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuProveedores.Name = "ItemMenuProveedores";
            ItemMenuProveedores.Size = new Size(150, 22);
            ItemMenuProveedores.Text = "Proveedores";
            ItemMenuProveedores.Click += ItemMenuProveedores_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuSalirDelSistema });
            iconMenuItem2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.IconSize = 30;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(80, 34);
            iconMenuItem2.Text = "Salir";
            // 
            // ItemMenuSalirDelSistema
            // 
            ItemMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            ItemMenuSalirDelSistema.IconColor = Color.Black;
            ItemMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuSalirDelSistema.IconSize = 30;
            ItemMenuSalirDelSistema.ImageScaling = ToolStripItemImageScaling.None;
            ItemMenuSalirDelSistema.Name = "ItemMenuSalirDelSistema";
            ItemMenuSalirDelSistema.Size = new Size(191, 36);
            ItemMenuSalirDelSistema.Text = "Salir del sistema";
            ItemMenuSalirDelSistema.Click += ItemMenuSalirDelSistema_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { localidadesToolStripMenuItem, clientesToolStripMenuItem });
            iconMenuItem4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.List12;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(86, 34);
            iconMenuItem4.Text = "Listados";
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Size = new Size(148, 22);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(148, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolHistoricoVentas });
            toolStrip1.Location = new Point(0, 38);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 67);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolHistoricoVentas
            // 
            iconToolHistoricoVentas.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconToolHistoricoVentas.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconToolHistoricoVentas.IconColor = Color.Black;
            iconToolHistoricoVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolHistoricoVentas.ImageScaling = ToolStripItemImageScaling.None;
            iconToolHistoricoVentas.ImageTransparentColor = Color.Magenta;
            iconToolHistoricoVentas.Name = "iconToolHistoricoVentas";
            iconToolHistoricoVentas.Size = new Size(72, 64);
            iconToolHistoricoVentas.Text = "Histórico Ventas";
            iconToolHistoricoVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolHistoricoVentas.Click += iconToolHistoricoVentas_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 510);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kiosco Informatico Desktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem ItemMenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem ItemMenuLocalidades;
        private FontAwesome.Sharp.IconMenuItem ItemMenuProductos;
        private FontAwesome.Sharp.IconMenuItem ItemMenuClientes;
        private FontAwesome.Sharp.IconMenuItem ItemMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private ToolStripMenuItem localidadesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuVentas;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton iconToolHistoricoVentas;
    }
}
