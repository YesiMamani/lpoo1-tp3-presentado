namespace Vistas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalirPrincipal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 150);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem});
            this.usuarioToolStripMenuItem.Image = global::Vistas.Properties.Resources.cliente;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(151, 146);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            this.usuarioToolStripMenuItem.MouseHover += new System.EventHandler(this.usuarioToolStripMenuItem_MouseHover);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeVehiculosToolStripMenuItem,
            this.listadoDeVehiculosToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Image = global::Vistas.Properties.Resources.vehiculo;
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(161, 146);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            this.vehiculosToolStripMenuItem.MouseHover += new System.EventHandler(this.vehiculosToolStripMenuItem_MouseHover);
            // 
            // gestionDeVehiculosToolStripMenuItem
            // 
            this.gestionDeVehiculosToolStripMenuItem.Name = "gestionDeVehiculosToolStripMenuItem";
            this.gestionDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.gestionDeVehiculosToolStripMenuItem.Text = "Gestion de Vehiculos";
            this.gestionDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeVehiculosToolStripMenuItem_Click);
            // 
            // listadoDeVehiculosToolStripMenuItem
            // 
            this.listadoDeVehiculosToolStripMenuItem.Name = "listadoDeVehiculosToolStripMenuItem";
            this.listadoDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.listadoDeVehiculosToolStripMenuItem.Text = "Listado de Vehiculos";
            this.listadoDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVehiculosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroVentasToolStripMenuItem,
            this.listadoVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Image = global::Vistas.Properties.Resources.venta;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(128, 146);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.MouseHover += new System.EventHandler(this.ventasToolStripMenuItem_MouseHover);
            // 
            // registroVentasToolStripMenuItem
            // 
            this.registroVentasToolStripMenuItem.Name = "registroVentasToolStripMenuItem";
            this.registroVentasToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.registroVentasToolStripMenuItem.Text = "Registrar Venta";
            this.registroVentasToolStripMenuItem.Click += new System.EventHandler(this.registroVentasToolStripMenuItem_Click);
            // 
            // listadoVentasToolStripMenuItem
            // 
            this.listadoVentasToolStripMenuItem.Name = "listadoVentasToolStripMenuItem";
            this.listadoVentasToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.listadoVentasToolStripMenuItem.Text = "Listado de Ventas";
            this.listadoVentasToolStripMenuItem.Click += new System.EventHandler(this.listadoVentasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::Vistas.Properties.Resources.UserF;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(143, 146);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            this.clientesToolStripMenuItem.MouseHover += new System.EventHandler(this.clientesToolStripMenuItem_MouseHover);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClasesToolStripMenuItem});
            this.gestionToolStripMenuItem.Image = global::Vistas.Properties.Resources.gear_set;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(138, 146);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.MouseHover += new System.EventHandler(this.gestionToolStripMenuItem_MouseHover);
            // 
            // gestionClasesToolStripMenuItem
            // 
            this.gestionClasesToolStripMenuItem.Name = "gestionClasesToolStripMenuItem";
            this.gestionClasesToolStripMenuItem.Size = new System.Drawing.Size(487, 34);
            this.gestionClasesToolStripMenuItem.Text = "Gestion Clases - Tipo - Forma Pago";
            this.gestionClasesToolStripMenuItem.Click += new System.EventHandler(this.gestionClasesToolStripMenuItem_Click);
            // 
            // btnSalirPrincipal
            // 
            this.btnSalirPrincipal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalirPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirPrincipal.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnSalirPrincipal.Location = new System.Drawing.Point(953, 535);
            this.btnSalirPrincipal.Name = "btnSalirPrincipal";
            this.btnSalirPrincipal.Size = new System.Drawing.Size(132, 47);
            this.btnSalirPrincipal.TabIndex = 1;
            this.btnSalirPrincipal.Text = "SALIR";
            this.btnSalirPrincipal.UseVisualStyleBackColor = false;
            this.btnSalirPrincipal.Click += new System.EventHandler(this.btnSalirPrincipal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(110, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 150);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Logo_Volkswagen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(311, 34);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Vistas.Properties.Resources.golweb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalirPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Button btnSalirPrincipal;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
    }
}