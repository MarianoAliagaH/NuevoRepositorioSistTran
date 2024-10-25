namespace CapaPresentacion
{
    partial class RegisterVehiculo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnEditarVehiculo = new System.Windows.Forms.Button();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridVehiculo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.comboPlaca = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 66);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsquedad Vehiculos";
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(772, 545);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(162, 54);
            this.btnInformacion.TabIndex = 30;
            this.btnInformacion.Text = "Informacion Vehiculo";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(528, 545);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(162, 54);
            this.btnEliminarVehiculo.TabIndex = 29;
            this.btnEliminarVehiculo.Text = "Eliminar Vehiculo";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnEditarVehiculo
            // 
            this.btnEditarVehiculo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVehiculo.Location = new System.Drawing.Point(282, 545);
            this.btnEditarVehiculo.Name = "btnEditarVehiculo";
            this.btnEditarVehiculo.Size = new System.Drawing.Size(162, 54);
            this.btnEditarVehiculo.TabIndex = 28;
            this.btnEditarVehiculo.Text = "Editar Vehiculo";
            this.btnEditarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(39, 545);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(162, 54);
            this.btnNuevoVehiculo.TabIndex = 27;
            this.btnNuevoVehiculo.Text = "Nuevo Vehiculo";
            this.btnNuevoVehiculo.UseVisualStyleBackColor = true;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Opciones Vehiculos";
            // 
            // dataGridVehiculo
            // 
            this.dataGridVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehiculo.Location = new System.Drawing.Point(38, 171);
            this.dataGridVehiculo.Name = "dataGridVehiculo";
            this.dataGridVehiculo.RowHeadersWidth = 51;
            this.dataGridVehiculo.RowTemplate.Height = 24;
            this.dataGridVehiculo.Size = new System.Drawing.Size(956, 269);
            this.dataGridVehiculo.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(440, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 54);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(218, 111);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(198, 27);
            this.textPlaca.TabIndex = 23;
            // 
            // comboPlaca
            // 
            this.comboPlaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlaca.FormattingEnabled = true;
            this.comboPlaca.Items.AddRange(new object[] {
            "D.N.I.",
            "R.U.C."});
            this.comboPlaca.Location = new System.Drawing.Point(34, 107);
            this.comboPlaca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboPlaca.Name = "comboPlaca";
            this.comboPlaca.Size = new System.Drawing.Size(162, 23);
            this.comboPlaca.TabIndex = 22;
            this.comboPlaca.Text = "Buscar por Placa";
            // 
            // RegisterVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1061);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.btnEditarVehiculo);
            this.Controls.Add(this.btnNuevoVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridVehiculo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.comboPlaca);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Name = "RegisterVehiculo";
            this.Text = "RegisterVehiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnEditarVehiculo;
        private System.Windows.Forms.Button btnNuevoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridVehiculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.ComboBox comboPlaca;
    }
}