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
            this.lblVentas = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbFormaDePago = new System.Windows.Forms.ComboBox();
            this.cmbPrecioFinal = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeCompra = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(71, 381);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(127, 23);
            this.btnConfirmarCompra.TabIndex = 0;
            this.btnConfirmarCompra.Text = "Confirmar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(345, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(42, 94);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(42, 134);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(42, 174);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(51, 13);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehiculo:";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Location = new System.Drawing.Point(42, 214);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaDePago.TabIndex = 5;
            this.lblFormaDePago.Text = "Forma de Pago:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(42, 254);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(65, 13);
            this.lblPrecioFinal.TabIndex = 6;
            this.lblPrecioFinal.Text = "Precio Final:";
            // 
            // lblFechaDeCompra
            // 
            this.lblFechaDeCompra.AutoSize = true;
            this.lblFechaDeCompra.Location = new System.Drawing.Point(42, 294);
            this.lblFechaDeCompra.Name = "lblFechaDeCompra";
            this.lblFechaDeCompra.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDeCompra.TabIndex = 7;
            this.lblFechaDeCompra.Text = "Fecha de Compra:";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(163, 20);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(66, 20);
            this.lblVentas.TabIndex = 8;
            this.lblVentas.Text = "Ventas";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(134, 94);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(120, 20);
            this.txtVendedor.TabIndex = 9;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(134, 134);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(233, 21);
            this.cmbCliente.TabIndex = 10;
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(134, 174);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(233, 21);
            this.cmbVehiculo.TabIndex = 11;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculo_SelectedIndexChanged);
            // 
            // cmbFormaDePago
            // 
            this.cmbFormaDePago.FormattingEnabled = true;
            this.cmbFormaDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque",
            "Transferencia"});
            this.cmbFormaDePago.Location = new System.Drawing.Point(134, 214);
            this.cmbFormaDePago.Name = "cmbFormaDePago";
            this.cmbFormaDePago.Size = new System.Drawing.Size(160, 21);
            this.cmbFormaDePago.TabIndex = 12;
            // 
            // cmbPrecioFinal
            // 
            this.cmbPrecioFinal.FormattingEnabled = true;
            this.cmbPrecioFinal.Location = new System.Drawing.Point(134, 254);
            this.cmbPrecioFinal.Name = "cmbPrecioFinal";
            this.cmbPrecioFinal.Size = new System.Drawing.Size(160, 21);
            this.cmbPrecioFinal.TabIndex = 13;
            // 
            // dtpFechaDeCompra
            // 
            this.dtpFechaDeCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeCompra.Location = new System.Drawing.Point(134, 294);
            this.dtpFechaDeCompra.Name = "dtpFechaDeCompra";
            this.dtpFechaDeCompra.Size = new System.Drawing.Size(233, 20);
            this.dtpFechaDeCompra.TabIndex = 14;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 436);
            this.Controls.Add(this.dtpFechaDeCompra);
            this.Controls.Add(this.cmbPrecioFinal);
            this.Controls.Add(this.cmbFormaDePago);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblFechaDeCompra);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
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
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.ComboBox cmbFormaDePago;
        private System.Windows.Forms.ComboBox cmbPrecioFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaDeCompra;
    }
}