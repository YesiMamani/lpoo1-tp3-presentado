namespace Vistas
{
    partial class FrmAltaVehiculo
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
            this.btnAceptarVehiculo = new System.Windows.Forms.Button();
            this.btnCancelarVehiculo = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblGps = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblClaseVehiculo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.chkGps = new System.Windows.Forms.CheckBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxClaseVehiculo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.cbxPuertas = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptarVehiculo
            // 
            this.btnAceptarVehiculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarVehiculo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAceptarVehiculo.Location = new System.Drawing.Point(53, 530);
            this.btnAceptarVehiculo.Name = "btnAceptarVehiculo";
            this.btnAceptarVehiculo.Size = new System.Drawing.Size(130, 40);
            this.btnAceptarVehiculo.TabIndex = 10;
            this.btnAceptarVehiculo.Text = "ACEPTAR";
            this.btnAceptarVehiculo.UseVisualStyleBackColor = false;
            this.btnAceptarVehiculo.Click += new System.EventHandler(this.btnAceptarVehiculo_Click);
            // 
            // btnCancelarVehiculo
            // 
            this.btnCancelarVehiculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVehiculo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVehiculo.Location = new System.Drawing.Point(215, 530);
            this.btnCancelarVehiculo.Name = "btnCancelarVehiculo";
            this.btnCancelarVehiculo.Size = new System.Drawing.Size(130, 40);
            this.btnCancelarVehiculo.TabIndex = 11;
            this.btnCancelarVehiculo.Text = "CANCELAR";
            this.btnCancelarVehiculo.UseVisualStyleBackColor = false;
            this.btnCancelarVehiculo.Click += new System.EventHandler(this.btnCancelarVehiculo_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.White;
            this.lblMatricula.Location = new System.Drawing.Point(49, 94);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(75, 16);
            this.lblMatricula.TabIndex = 12;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(50, 136);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 16);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca:";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.ForeColor = System.Drawing.Color.White;
            this.lblLinea.Location = new System.Drawing.Point(50, 178);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(48, 16);
            this.lblLinea.TabIndex = 14;
            this.lblLinea.Text = "Linea:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(49, 220);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 16);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(50, 262);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 16);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color:";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertas.ForeColor = System.Drawing.Color.White;
            this.lblPuertas.Location = new System.Drawing.Point(49, 304);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(64, 16);
            this.lblPuertas.TabIndex = 17;
            this.lblPuertas.Text = "Puertas:";
            // 
            // lblGps
            // 
            this.lblGps.AutoSize = true;
            this.lblGps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGps.ForeColor = System.Drawing.Color.White;
            this.lblGps.Location = new System.Drawing.Point(50, 344);
            this.lblGps.Name = "lblGps";
            this.lblGps.Size = new System.Drawing.Size(41, 16);
            this.lblGps.TabIndex = 19;
            this.lblGps.Text = "GPS:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(49, 384);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(125, 16);
            this.lblTipoVehiculo.TabIndex = 20;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // lblClaseVehiculo
            // 
            this.lblClaseVehiculo.AutoSize = true;
            this.lblClaseVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblClaseVehiculo.Location = new System.Drawing.Point(49, 427);
            this.lblClaseVehiculo.Name = "lblClaseVehiculo";
            this.lblClaseVehiculo.Size = new System.Drawing.Size(133, 16);
            this.lblClaseVehiculo.TabIndex = 21;
            this.lblClaseVehiculo.Text = "Clase de Vehiculo:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(200, 94);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(145, 23);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.Leave += new System.EventHandler(this.txtMatricula_Leave);
            // 
            // txtLinea
            // 
            this.txtLinea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(200, 178);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(145, 23);
            this.txtLinea.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(200, 468);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(145, 23);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(49, 470);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 16);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio:";
            // 
            // chkGps
            // 
            this.chkGps.AutoSize = true;
            this.chkGps.Location = new System.Drawing.Point(200, 346);
            this.chkGps.Name = "chkGps";
            this.chkGps.Size = new System.Drawing.Size(15, 14);
            this.chkGps.TabIndex = 6;
            this.chkGps.UseVisualStyleBackColor = true;
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipoVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(200, 382);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(145, 23);
            this.cbxTipoVehiculo.TabIndex = 7;
            // 
            // cbxClaseVehiculo
            // 
            this.cbxClaseVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxClaseVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClaseVehiculo.FormattingEnabled = true;
            this.cbxClaseVehiculo.Location = new System.Drawing.Point(200, 425);
            this.cbxClaseVehiculo.Name = "cbxClaseVehiculo";
            this.cbxClaseVehiculo.Size = new System.Drawing.Size(145, 23);
            this.cbxClaseVehiculo.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 58);
            this.panel1.TabIndex = 23;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(345, 6);
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
            this.lblTitle.Location = new System.Drawing.Point(7, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ALTA VEHICULO";
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Ford",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.cbxMarca.Location = new System.Drawing.Point(200, 136);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(145, 23);
            this.cbxMarca.TabIndex = 24;
            // 
            // cbxColor
            // 
            this.cbxColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Gris",
            "Negro",
            "Rojo",
            "Verde"});
            this.cbxColor.Location = new System.Drawing.Point(200, 262);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(145, 23);
            this.cbxColor.TabIndex = 25;
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
            this.cbxModelo.Location = new System.Drawing.Point(200, 220);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(145, 23);
            this.cbxModelo.TabIndex = 26;
            this.cbxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxModelo_KeyPress);
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
            this.cbxPuertas.Location = new System.Drawing.Point(200, 304);
            this.cbxPuertas.Name = "cbxPuertas";
            this.cbxPuertas.Size = new System.Drawing.Size(145, 23);
            this.cbxPuertas.TabIndex = 27;
            this.cbxPuertas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPuertas_KeyPress);
            // 
            // FrmAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(402, 600);
            this.Controls.Add(this.cbxPuertas);
            this.Controls.Add(this.cbxModelo);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxClaseVehiculo);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.chkGps);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblClaseVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblGps);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnCancelarVehiculo);
            this.Controls.Add(this.btnAceptarVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario  Alta de Vehiculos";
            this.Load += new System.EventHandler(this.FrmAltaVehiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarVehiculo;
        private System.Windows.Forms.Button btnCancelarVehiculo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblGps;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblClaseVehiculo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.CheckBox chkGps;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ComboBox cbxClaseVehiculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.ComboBox cbxPuertas;
    }
}