namespace Vistas
{
    partial class FrmVehiculos
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMAtricula = new System.Windows.Forms.Label();
            this.lblMArca = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPuerta = new System.Windows.Forms.Label();
            this.lblGPS = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblClaseVehiculo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtMAtricula = new System.Windows.Forms.TextBox();
            this.txtMArca = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.chkGPS = new System.Windows.Forms.CheckBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxClaseVehiculo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(8, 49);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(607, 459);
            this.dgvVehiculos.TabIndex = 0;
            this.dgvVehiculos.CurrentCellChanged += new System.EventHandler(this.dgvVehiculos_CurrentCellChanged);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(818, 12);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(108, 75);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(676, 481);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(796, 481);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMAtricula
            // 
            this.lblMAtricula.AutoSize = true;
            this.lblMAtricula.Location = new System.Drawing.Point(631, 135);
            this.lblMAtricula.Name = "lblMAtricula";
            this.lblMAtricula.Size = new System.Drawing.Size(50, 13);
            this.lblMAtricula.TabIndex = 4;
            this.lblMAtricula.Text = "Matricula";
            // 
            // lblMArca
            // 
            this.lblMArca.AutoSize = true;
            this.lblMArca.Location = new System.Drawing.Point(631, 169);
            this.lblMArca.Name = "lblMArca";
            this.lblMArca.Size = new System.Drawing.Size(37, 13);
            this.lblMArca.TabIndex = 5;
            this.lblMArca.Text = "Marca";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(631, 203);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(33, 13);
            this.lblLinea.TabIndex = 6;
            this.lblLinea.Text = "Linea";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(631, 237);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(631, 271);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // lblPuerta
            // 
            this.lblPuerta.AutoSize = true;
            this.lblPuerta.Location = new System.Drawing.Point(631, 305);
            this.lblPuerta.Name = "lblPuerta";
            this.lblPuerta.Size = new System.Drawing.Size(43, 13);
            this.lblPuerta.TabIndex = 9;
            this.lblPuerta.Text = "Puertas";
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Location = new System.Drawing.Point(631, 339);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(29, 13);
            this.lblGPS.TabIndex = 10;
            this.lblGPS.Text = "GPS";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(631, 373);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(72, 13);
            this.lblTipoVehiculo.TabIndex = 11;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblClaseVehiculo
            // 
            this.lblClaseVehiculo.AutoSize = true;
            this.lblClaseVehiculo.Location = new System.Drawing.Point(631, 407);
            this.lblClaseVehiculo.Name = "lblClaseVehiculo";
            this.lblClaseVehiculo.Size = new System.Drawing.Size(77, 13);
            this.lblClaseVehiculo.TabIndex = 12;
            this.lblClaseVehiculo.Text = "Clase Vehiculo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(631, 441);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // txtMAtricula
            // 
            this.txtMAtricula.Enabled = false;
            this.txtMAtricula.Location = new System.Drawing.Point(731, 135);
            this.txtMAtricula.Name = "txtMAtricula";
            this.txtMAtricula.Size = new System.Drawing.Size(181, 20);
            this.txtMAtricula.TabIndex = 14;
            // 
            // txtMArca
            // 
            this.txtMArca.Location = new System.Drawing.Point(731, 169);
            this.txtMArca.Name = "txtMArca";
            this.txtMArca.Size = new System.Drawing.Size(181, 20);
            this.txtMArca.TabIndex = 15;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(731, 203);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(181, 20);
            this.txtLinea.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(731, 237);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(181, 20);
            this.txtModelo.TabIndex = 17;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(731, 271);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(181, 20);
            this.txtColor.TabIndex = 18;
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(731, 305);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(181, 20);
            this.txtPuertas.TabIndex = 19;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(731, 438);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 20);
            this.txtPrecio.TabIndex = 22;
            // 
            // chkGPS
            // 
            this.chkGPS.AutoSize = true;
            this.chkGPS.Location = new System.Drawing.Point(731, 339);
            this.chkGPS.Name = "chkGPS";
            this.chkGPS.Size = new System.Drawing.Size(15, 14);
            this.chkGPS.TabIndex = 23;
            this.chkGPS.UseVisualStyleBackColor = true;
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(731, 370);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(181, 21);
            this.cbxTipoVehiculo.TabIndex = 24;
            // 
            // cbxClaseVehiculo
            // 
            this.cbxClaseVehiculo.FormattingEnabled = true;
            this.cbxClaseVehiculo.Location = new System.Drawing.Point(731, 398);
            this.cbxClaseVehiculo.Name = "cbxClaseVehiculo";
            this.cbxClaseVehiculo.Size = new System.Drawing.Size(181, 21);
            this.cbxClaseVehiculo.TabIndex = 25;
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 516);
            this.Controls.Add(this.cbxClaseVehiculo);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.chkGPS);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtMArca);
            this.Controls.Add(this.txtMAtricula);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblClaseVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblGPS);
            this.Controls.Add(this.lblPuerta);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblMArca);
            this.Controls.Add(this.lblMAtricula);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "FrmVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMAtricula;
        private System.Windows.Forms.Label lblMArca;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPuerta;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblClaseVehiculo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtMAtricula;
        private System.Windows.Forms.TextBox txtMArca;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.CheckBox chkGPS;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ComboBox cbxClaseVehiculo;
    }
}