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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.chkGPS = new System.Windows.Forms.CheckBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxClaseVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxPuertas = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 129);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(769, 459);
            this.dgvVehiculos.TabIndex = 0;
            this.dgvVehiculos.CurrentCellChanged += new System.EventHandler(this.dgvVehiculos_CurrentCellChanged);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackgroundImage = global::Vistas.Properties.Resources.addcard;
            this.btnAgregarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(998, 73);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(108, 75);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(803, 555);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 33);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(911, 555);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMAtricula
            // 
            this.lblMAtricula.AutoSize = true;
            this.lblMAtricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAtricula.ForeColor = System.Drawing.Color.White;
            this.lblMAtricula.Location = new System.Drawing.Point(797, 174);
            this.lblMAtricula.Name = "lblMAtricula";
            this.lblMAtricula.Size = new System.Drawing.Size(75, 16);
            this.lblMAtricula.TabIndex = 4;
            this.lblMAtricula.Text = "Matricula:";
            // 
            // lblMArca
            // 
            this.lblMArca.AutoSize = true;
            this.lblMArca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMArca.ForeColor = System.Drawing.Color.White;
            this.lblMArca.Location = new System.Drawing.Point(797, 208);
            this.lblMArca.Name = "lblMArca";
            this.lblMArca.Size = new System.Drawing.Size(54, 16);
            this.lblMArca.TabIndex = 5;
            this.lblMArca.Text = "Marca:";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.ForeColor = System.Drawing.Color.White;
            this.lblLinea.Location = new System.Drawing.Point(797, 242);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(48, 16);
            this.lblLinea.TabIndex = 6;
            this.lblLinea.Text = "Linea:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(797, 276);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 16);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(797, 310);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 16);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color:";
            // 
            // lblPuerta
            // 
            this.lblPuerta.AutoSize = true;
            this.lblPuerta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerta.ForeColor = System.Drawing.Color.White;
            this.lblPuerta.Location = new System.Drawing.Point(797, 344);
            this.lblPuerta.Name = "lblPuerta";
            this.lblPuerta.Size = new System.Drawing.Size(64, 16);
            this.lblPuerta.TabIndex = 9;
            this.lblPuerta.Text = "Puertas:";
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPS.ForeColor = System.Drawing.Color.White;
            this.lblGPS.Location = new System.Drawing.Point(797, 378);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(41, 16);
            this.lblGPS.TabIndex = 10;
            this.lblGPS.Text = "GPS:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(797, 412);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(104, 16);
            this.lblTipoVehiculo.TabIndex = 11;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // lblClaseVehiculo
            // 
            this.lblClaseVehiculo.AutoSize = true;
            this.lblClaseVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblClaseVehiculo.Location = new System.Drawing.Point(797, 446);
            this.lblClaseVehiculo.Name = "lblClaseVehiculo";
            this.lblClaseVehiculo.Size = new System.Drawing.Size(112, 16);
            this.lblClaseVehiculo.TabIndex = 12;
            this.lblClaseVehiculo.Text = "Clase Vehiculo:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(797, 480);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 16);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtMAtricula
            // 
            this.txtMAtricula.Enabled = false;
            this.txtMAtricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAtricula.Location = new System.Drawing.Point(925, 175);
            this.txtMAtricula.Name = "txtMAtricula";
            this.txtMAtricula.Size = new System.Drawing.Size(181, 23);
            this.txtMAtricula.TabIndex = 14;
            // 
            // txtLinea
            // 
            this.txtLinea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(925, 241);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(181, 23);
            this.txtLinea.TabIndex = 16;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(925, 475);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 23);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // chkGPS
            // 
            this.chkGPS.AutoSize = true;
            this.chkGPS.Location = new System.Drawing.Point(925, 380);
            this.chkGPS.Name = "chkGPS";
            this.chkGPS.Size = new System.Drawing.Size(15, 14);
            this.chkGPS.TabIndex = 23;
            this.chkGPS.UseVisualStyleBackColor = true;
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipoVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(925, 407);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(181, 23);
            this.cbxTipoVehiculo.TabIndex = 24;
            // 
            // cbxClaseVehiculo
            // 
            this.cbxClaseVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxClaseVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClaseVehiculo.FormattingEnabled = true;
            this.cbxClaseVehiculo.Location = new System.Drawing.Point(925, 441);
            this.cbxClaseVehiculo.Name = "cbxClaseVehiculo";
            this.cbxClaseVehiculo.Size = new System.Drawing.Size(181, 23);
            this.cbxClaseVehiculo.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DE VEHICULOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 60);
            this.panel1.TabIndex = 26;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1059, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 46);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1016, 555);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 33);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Ford",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.cbxMarca.Location = new System.Drawing.Point(925, 208);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(181, 23);
            this.cbxMarca.TabIndex = 28;
            // 
            // cbxColor
            // 
            this.cbxColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Gris",
            "Negro",
            "Rojo",
            "Verde"});
            this.cbxColor.Location = new System.Drawing.Point(925, 307);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(181, 23);
            this.cbxColor.TabIndex = 29;
            this.cbxColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxColor_KeyPress);
            // 
            // cbxPuertas
            // 
            this.cbxPuertas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPuertas.FormattingEnabled = true;
            this.cbxPuertas.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cbxPuertas.Location = new System.Drawing.Point(925, 341);
            this.cbxPuertas.Name = "cbxPuertas";
            this.cbxPuertas.Size = new System.Drawing.Size(181, 23);
            this.cbxPuertas.TabIndex = 31;
            this.cbxPuertas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPuertas_KeyPress);
            // 
            // cbxModelo
            // 
            this.cbxModelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cbxModelo.Location = new System.Drawing.Point(925, 273);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(181, 23);
            this.cbxModelo.TabIndex = 30;
            this.cbxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxModelo_KeyPress);
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1118, 600);
            this.Controls.Add(this.cbxPuertas);
            this.Controls.Add(this.cbxModelo);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxClaseVehiculo);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.chkGPS);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtLinea);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.CheckBox chkGPS;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ComboBox cbxClaseVehiculo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxPuertas;
        private System.Windows.Forms.ComboBox cbxModelo;
    }
}