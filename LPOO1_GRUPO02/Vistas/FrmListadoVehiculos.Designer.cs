namespace Vistas
{
    partial class FrmListadoVehiculos
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
            this.btnActualizarListado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLinea = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarListado
            // 
            this.btnActualizarListado.Location = new System.Drawing.Point(494, 32);
            this.btnActualizarListado.Name = "btnActualizarListado";
            this.btnActualizarListado.Size = new System.Drawing.Size(143, 30);
            this.btnActualizarListado.TabIndex = 0;
            this.btnActualizarListado.Text = "Actualizar Listado";
            this.btnActualizarListado.UseVisualStyleBackColor = true;
            this.btnActualizarListado.Click += new System.EventHandler(this.btnActualizarListado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbLinea);
            this.groupBox1.Controls.Add(this.rdbMarca);
            this.groupBox1.Location = new System.Drawing.Point(229, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por:";
            // 
            // rdbLinea
            // 
            this.rdbLinea.AutoSize = true;
            this.rdbLinea.Location = new System.Drawing.Point(57, 66);
            this.rdbLinea.Name = "rdbLinea";
            this.rdbLinea.Size = new System.Drawing.Size(51, 17);
            this.rdbLinea.TabIndex = 1;
            this.rdbLinea.Text = "Linea";
            this.rdbLinea.UseVisualStyleBackColor = true;
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Checked = true;
            this.rdbMarca.Location = new System.Drawing.Point(57, 28);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(55, 17);
            this.rdbMarca.TabIndex = 0;
            this.rdbMarca.TabStop = true;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 99);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(601, 249);
            this.dgvVehiculos.TabIndex = 4;
            // 
            // FrmListadoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 360);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizarListado);
            this.Name = "FrmListadoVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoVehiculos";
            this.Load += new System.EventHandler(this.FrmListadoVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLinea;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.DataGridView dgvVehiculos;
    }
}