namespace Vistas
{
    partial class FrmListadoVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentasRealizadas = new System.Windows.Forms.DataGridView();
            this.lblVentasRealizadas = new System.Windows.Forms.Label();
            this.cbxListadoCliente = new System.Windows.Forms.ComboBox();
            this.cbxListadoMarca = new System.Windows.Forms.ComboBox();
            this.gbxListadoMarca = new System.Windows.Forms.GroupBox();
            this.gbxListadoCliente = new System.Windows.Forms.GroupBox();
            this.gbxListarFecha = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnListarFecha = new System.Windows.Forms.Button();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAnularVentaSeleccionada = new System.Windows.Forms.Button();
            this.lblCantVentas = new System.Windows.Forms.Label();
            this.lblCantVentasAnuladas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantVentas = new System.Windows.Forms.Label();
            this.cantVentasAnuladas = new System.Windows.Forms.Label();
            this.importeTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).BeginInit();
            this.gbxListadoMarca.SuspendLayout();
            this.gbxListadoCliente.SuspendLayout();
            this.gbxListarFecha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentasRealizadas
            // 
            this.dgvVentasRealizadas.AllowUserToAddRows = false;
            this.dgvVentasRealizadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasRealizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasRealizadas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasRealizadas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentasRealizadas.Location = new System.Drawing.Point(12, 198);
            this.dgvVentasRealizadas.Name = "dgvVentasRealizadas";
            this.dgvVentasRealizadas.ReadOnly = true;
            this.dgvVentasRealizadas.RowHeadersVisible = false;
            this.dgvVentasRealizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasRealizadas.Size = new System.Drawing.Size(1110, 407);
            this.dgvVentasRealizadas.TabIndex = 0;
            // 
            // lblVentasRealizadas
            // 
            this.lblVentasRealizadas.AutoSize = true;
            this.lblVentasRealizadas.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasRealizadas.ForeColor = System.Drawing.Color.White;
            this.lblVentasRealizadas.Location = new System.Drawing.Point(7, 10);
            this.lblVentasRealizadas.Name = "lblVentasRealizadas";
            this.lblVentasRealizadas.Size = new System.Drawing.Size(490, 40);
            this.lblVentasRealizadas.TabIndex = 1;
            this.lblVentasRealizadas.Text = "LISTADO DE VENTAS REALIZADAS";
            // 
            // cbxListadoCliente
            // 
            this.cbxListadoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxListadoCliente.FormattingEnabled = true;
            this.cbxListadoCliente.Location = new System.Drawing.Point(13, 39);
            this.cbxListadoCliente.Name = "cbxListadoCliente";
            this.cbxListadoCliente.Size = new System.Drawing.Size(180, 25);
            this.cbxListadoCliente.TabIndex = 4;
            this.cbxListadoCliente.SelectedIndexChanged += new System.EventHandler(this.cbxListadoCliente_SelectedIndexChanged);
            // 
            // cbxListadoMarca
            // 
            this.cbxListadoMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxListadoMarca.FormattingEnabled = true;
            this.cbxListadoMarca.Location = new System.Drawing.Point(17, 37);
            this.cbxListadoMarca.Name = "cbxListadoMarca";
            this.cbxListadoMarca.Size = new System.Drawing.Size(177, 25);
            this.cbxListadoMarca.TabIndex = 5;
            this.cbxListadoMarca.SelectedIndexChanged += new System.EventHandler(this.cbxListadoMarca_SelectedIndexChanged);
            // 
            // gbxListadoMarca
            // 
            this.gbxListadoMarca.Controls.Add(this.cbxListadoMarca);
            this.gbxListadoMarca.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoMarca.ForeColor = System.Drawing.Color.White;
            this.gbxListadoMarca.Location = new System.Drawing.Point(299, 83);
            this.gbxListadoMarca.Name = "gbxListadoMarca";
            this.gbxListadoMarca.Size = new System.Drawing.Size(212, 90);
            this.gbxListadoMarca.TabIndex = 6;
            this.gbxListadoMarca.TabStop = false;
            this.gbxListadoMarca.Text = "Listado por Marca";
            // 
            // gbxListadoCliente
            // 
            this.gbxListadoCliente.Controls.Add(this.cbxListadoCliente);
            this.gbxListadoCliente.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoCliente.ForeColor = System.Drawing.Color.White;
            this.gbxListadoCliente.Location = new System.Drawing.Point(23, 81);
            this.gbxListadoCliente.Name = "gbxListadoCliente";
            this.gbxListadoCliente.Size = new System.Drawing.Size(210, 90);
            this.gbxListadoCliente.TabIndex = 7;
            this.gbxListadoCliente.TabStop = false;
            this.gbxListadoCliente.Text = "Listado por Cliente";
            // 
            // gbxListarFecha
            // 
            this.gbxListarFecha.Controls.Add(this.dtpFechaFin);
            this.gbxListarFecha.Controls.Add(this.dtpFechaInicio);
            this.gbxListarFecha.Controls.Add(this.lblFin);
            this.gbxListarFecha.Controls.Add(this.lblInicio);
            this.gbxListarFecha.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListarFecha.ForeColor = System.Drawing.Color.White;
            this.gbxListarFecha.Location = new System.Drawing.Point(576, 83);
            this.gbxListarFecha.Name = "gbxListarFecha";
            this.gbxListarFecha.Size = new System.Drawing.Size(258, 90);
            this.gbxListarFecha.TabIndex = 8;
            this.gbxListarFecha.TabStop = false;
            this.gbxListarFecha.Text = "Listar por Fecha";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(134, 55);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(118, 24);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(134, 25);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(118, 24);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(6, 57);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(107, 15);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Fin (dd/mm/aaaa)";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(6, 32);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(122, 15);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio (dd/mm/aaaa)";
            // 
            // btnListarFecha
            // 
            this.btnListarFecha.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarFecha.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarFecha.ForeColor = System.Drawing.Color.White;
            this.btnListarFecha.Location = new System.Drawing.Point(903, 83);
            this.btnListarFecha.Name = "btnListarFecha";
            this.btnListarFecha.Size = new System.Drawing.Size(218, 40);
            this.btnListarFecha.TabIndex = 3;
            this.btnListarFecha.Text = "LISTAR POR FECHA";
            this.btnListarFecha.UseVisualStyleBackColor = false;
            this.btnListarFecha.Click += new System.EventHandler(this.btnListarFecha_Click);
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTodo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.ForeColor = System.Drawing.Color.White;
            this.btnListarTodo.Location = new System.Drawing.Point(903, 138);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(218, 40);
            this.btnListarTodo.TabIndex = 9;
            this.btnListarTodo.Text = "LISTAR TODO";
            this.btnListarTodo.UseVisualStyleBackColor = false;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblVentasRealizadas);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 61);
            this.panel1.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1076, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 46);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAnularVentaSeleccionada
            // 
            this.btnAnularVentaSeleccionada.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnularVentaSeleccionada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularVentaSeleccionada.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularVentaSeleccionada.ForeColor = System.Drawing.Color.White;
            this.btnAnularVentaSeleccionada.Location = new System.Drawing.Point(889, 611);
            this.btnAnularVentaSeleccionada.Name = "btnAnularVentaSeleccionada";
            this.btnAnularVentaSeleccionada.Size = new System.Drawing.Size(233, 33);
            this.btnAnularVentaSeleccionada.TabIndex = 11;
            this.btnAnularVentaSeleccionada.Text = "ANULAR VENTA SELECCIONADA";
            this.btnAnularVentaSeleccionada.UseVisualStyleBackColor = false;
            this.btnAnularVentaSeleccionada.Click += new System.EventHandler(this.btnAnularVentaSeleccionada_Click);
            // 
            // lblCantVentas
            // 
            this.lblCantVentas.AutoSize = true;
            this.lblCantVentas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVentas.ForeColor = System.Drawing.Color.White;
            this.lblCantVentas.Location = new System.Drawing.Point(11, 620);
            this.lblCantVentas.Name = "lblCantVentas";
            this.lblCantVentas.Size = new System.Drawing.Size(137, 17);
            this.lblCantVentas.TabIndex = 12;
            this.lblCantVentas.Text = "Cantidad de ventas:";
            // 
            // lblCantVentasAnuladas
            // 
            this.lblCantVentasAnuladas.AutoSize = true;
            this.lblCantVentasAnuladas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVentasAnuladas.ForeColor = System.Drawing.Color.White;
            this.lblCantVentasAnuladas.Location = new System.Drawing.Point(254, 620);
            this.lblCantVentasAnuladas.Name = "lblCantVentasAnuladas";
            this.lblCantVentasAnuladas.Size = new System.Drawing.Size(213, 17);
            this.lblCantVentasAnuladas.TabIndex = 13;
            this.lblCantVentasAnuladas.Text = "Cantidad de ventas ANULADAS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(561, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Importe TOTAL de Ventas: $";
            // 
            // cantVentas
            // 
            this.cantVentas.AutoSize = true;
            this.cantVentas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantVentas.ForeColor = System.Drawing.Color.White;
            this.cantVentas.Location = new System.Drawing.Point(148, 620);
            this.cantVentas.Name = "cantVentas";
            this.cantVentas.Size = new System.Drawing.Size(12, 17);
            this.cantVentas.TabIndex = 15;
            this.cantVentas.Text = "-";
            // 
            // cantVentasAnuladas
            // 
            this.cantVentasAnuladas.AutoSize = true;
            this.cantVentasAnuladas.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantVentasAnuladas.ForeColor = System.Drawing.Color.White;
            this.cantVentasAnuladas.Location = new System.Drawing.Point(466, 620);
            this.cantVentasAnuladas.Name = "cantVentasAnuladas";
            this.cantVentasAnuladas.Size = new System.Drawing.Size(11, 15);
            this.cantVentasAnuladas.TabIndex = 16;
            this.cantVentasAnuladas.Text = "-";
            // 
            // importeTotal
            // 
            this.importeTotal.AutoSize = true;
            this.importeTotal.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTotal.ForeColor = System.Drawing.Color.White;
            this.importeTotal.Location = new System.Drawing.Point(753, 620);
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.Size = new System.Drawing.Size(12, 17);
            this.importeTotal.TabIndex = 17;
            this.importeTotal.Text = "-";
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1134, 650);
            this.Controls.Add(this.importeTotal);
            this.Controls.Add(this.cantVentasAnuladas);
            this.Controls.Add(this.cantVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantVentasAnuladas);
            this.Controls.Add(this.lblCantVentas);
            this.Controls.Add(this.btnAnularVentaSeleccionada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.btnListarFecha);
            this.Controls.Add(this.gbxListarFecha);
            this.Controls.Add(this.gbxListadoCliente);
            this.Controls.Add(this.gbxListadoMarca);
            this.Controls.Add(this.dgvVentasRealizadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ventas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).EndInit();
            this.gbxListadoMarca.ResumeLayout(false);
            this.gbxListadoCliente.ResumeLayout(false);
            this.gbxListarFecha.ResumeLayout(false);
            this.gbxListarFecha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasRealizadas;
        private System.Windows.Forms.Label lblVentasRealizadas;
        private System.Windows.Forms.ComboBox cbxListadoCliente;
        private System.Windows.Forms.ComboBox cbxListadoMarca;
        private System.Windows.Forms.GroupBox gbxListadoMarca;
        private System.Windows.Forms.GroupBox gbxListadoCliente;
        private System.Windows.Forms.GroupBox gbxListarFecha;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnListarFecha;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnAnularVentaSeleccionada;
        private System.Windows.Forms.Label lblCantVentas;
        private System.Windows.Forms.Label lblCantVentasAnuladas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cantVentas;
        private System.Windows.Forms.Label cantVentasAnuladas;
        private System.Windows.Forms.Label importeTotal;
    }
}