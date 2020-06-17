namespace Vistas
{
    partial class FrmVentas
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
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblFechaDeCompra = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbFormaDePago = new System.Windows.Forms.ComboBox();
            this.cmbPrecioFinal = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeCompra = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirmarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCompra.Location = new System.Drawing.Point(79, 371);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(187, 40);
            this.btnConfirmarCompra.TabIndex = 0;
            this.btnConfirmarCompra.Text = "CONFIRMAR COMPRA";
            this.btnConfirmarCompra.UseVisualStyleBackColor = false;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(272, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(76, 93);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(78, 16);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(76, 148);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 16);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblVehiculo.Location = new System.Drawing.Point(76, 188);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(70, 16);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehiculo:";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.ForeColor = System.Drawing.Color.White;
            this.lblFormaDePago.Location = new System.Drawing.Point(76, 228);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(113, 16);
            this.lblFormaDePago.TabIndex = 5;
            this.lblFormaDePago.Text = "Forma de Pago:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.White;
            this.lblPrecioFinal.Location = new System.Drawing.Point(76, 268);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(91, 16);
            this.lblPrecioFinal.TabIndex = 6;
            this.lblPrecioFinal.Text = "Precio Final:";
            // 
            // lblFechaDeCompra
            // 
            this.lblFechaDeCompra.AutoSize = true;
            this.lblFechaDeCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeCompra.ForeColor = System.Drawing.Color.White;
            this.lblFechaDeCompra.Location = new System.Drawing.Point(76, 308);
            this.lblFechaDeCompra.Name = "lblFechaDeCompra";
            this.lblFechaDeCompra.Size = new System.Drawing.Size(130, 16);
            this.lblFechaDeCompra.TabIndex = 7;
            this.lblFechaDeCompra.Text = "Fecha de Compra:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Cursor = System.Windows.Forms.Cursors.No;
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(210, 93);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(233, 23);
            this.txtVendedor.TabIndex = 9;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(210, 148);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(233, 23);
            this.cmbCliente.TabIndex = 10;
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(210, 188);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(233, 23);
            this.cmbVehiculo.TabIndex = 11;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculo_SelectedIndexChanged);
            // 
            // cmbFormaDePago
            // 
            this.cmbFormaDePago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaDePago.FormattingEnabled = true;
            this.cmbFormaDePago.Location = new System.Drawing.Point(210, 228);
            this.cmbFormaDePago.Name = "cmbFormaDePago";
            this.cmbFormaDePago.Size = new System.Drawing.Size(233, 23);
            this.cmbFormaDePago.TabIndex = 12;
            // 
            // cmbPrecioFinal
            // 
            this.cmbPrecioFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrecioFinal.FormattingEnabled = true;
            this.cmbPrecioFinal.Location = new System.Drawing.Point(210, 268);
            this.cmbPrecioFinal.Name = "cmbPrecioFinal";
            this.cmbPrecioFinal.Size = new System.Drawing.Size(233, 23);
            this.cmbPrecioFinal.TabIndex = 13;
            this.cmbPrecioFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPrecioFinal_KeyPress);
            // 
            // dtpFechaDeCompra
            // 
            this.dtpFechaDeCompra.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDeCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeCompra.Location = new System.Drawing.Point(210, 308);
            this.dtpFechaDeCompra.Name = "dtpFechaDeCompra";
            this.dtpFechaDeCompra.Size = new System.Drawing.Size(233, 23);
            this.dtpFechaDeCompra.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 58);
            this.panel1.TabIndex = 21;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(476, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 46);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REGISTRAR VENTA";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(535, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechaDeCompra);
            this.Controls.Add(this.cmbPrecioFinal);
            this.Controls.Add(this.cmbFormaDePago);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblFechaDeCompra);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarCompra);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblFechaDeCompra;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.ComboBox cmbFormaDePago;
        private System.Windows.Forms.ComboBox cmbPrecioFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaDeCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitle;
    }
}