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
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
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
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuLocalidades, ItemMenuProductos, ItemMenuClientes });
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
            ItemMenuLocalidades.Size = new Size(180, 22);
            ItemMenuLocalidades.Text = "Localidades";
            ItemMenuLocalidades.Click += ItemMenuLocalidades_Click;
            // 
            // ItemMenuProductos
            // 
            ItemMenuProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            ItemMenuProductos.IconColor = Color.Black;
            ItemMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuProductos.Name = "ItemMenuProductos";
            ItemMenuProductos.Size = new Size(180, 22);
            ItemMenuProductos.Text = "Productos";
            ItemMenuProductos.Click += ItemMenuProductos_Click;
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
            // ItemMenuClientes
            // 
            ItemMenuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ItemMenuClientes.IconColor = Color.Black;
            ItemMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuClientes.Name = "ItemMenuClientes";
            ItemMenuClientes.Size = new Size(180, 22);
            ItemMenuClientes.Text = "Clientes";
            ItemMenuClientes.Click += ItemMenuClientes_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 510);
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
    }
}
