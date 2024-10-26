namespace CapaPresentacion
{
    partial class Facturas
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnAgregarFactura = new System.Windows.Forms.Button();
            this.txtDatosCliente = new System.Windows.Forms.Label();
            this.pnllDatoCliente = new System.Windows.Forms.Panel();
            this.textBoxItotal = new System.Windows.Forms.TextBox();
            this.textBoxMpago = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.txtFechas = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTipoCarga = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxRuc = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.Label();
            this.txtTipoCarga = new System.Windows.Forms.Label();
            this.textCrupotrc = new System.Windows.Forms.Label();
            this.txtTRC = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnllDatoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(137, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 41);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(576, 402);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(133, 36);
            this.btnGenerarFactura.TabIndex = 32;
            this.btnGenerarFactura.Text = "Generar factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.Location = new System.Drawing.Point(22, 395);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarFactura.TabIndex = 31;
            this.btnAgregarFactura.Text = "Agregar";
            this.btnAgregarFactura.UseVisualStyleBackColor = true;
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.AutoSize = true;
            this.txtDatosCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosCliente.Location = new System.Drawing.Point(17, 49);
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.Size = new System.Drawing.Size(126, 19);
            this.txtDatosCliente.TabIndex = 28;
            this.txtDatosCliente.Text = "Buscar Cliente";
            // 
            // pnllDatoCliente
            // 
            this.pnllDatoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnllDatoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnllDatoCliente.Controls.Add(this.textBoxItotal);
            this.pnllDatoCliente.Controls.Add(this.textBoxMpago);
            this.pnllDatoCliente.Controls.Add(this.lblImporteTotal);
            this.pnllDatoCliente.Controls.Add(this.lblMetodoPago);
            this.pnllDatoCliente.Controls.Add(this.textBoxFecha);
            this.pnllDatoCliente.Controls.Add(this.txtFechas);
            this.pnllDatoCliente.Controls.Add(this.textBoxDireccion);
            this.pnllDatoCliente.Controls.Add(this.textBoxNombre);
            this.pnllDatoCliente.Controls.Add(this.textBoxTipoCarga);
            this.pnllDatoCliente.Controls.Add(this.textBoxCodigo);
            this.pnllDatoCliente.Controls.Add(this.textBoxRuc);
            this.pnllDatoCliente.Controls.Add(this.txtCodigo);
            this.pnllDatoCliente.Controls.Add(this.textDireccion);
            this.pnllDatoCliente.Controls.Add(this.txtNombres);
            this.pnllDatoCliente.Controls.Add(this.txtRuc);
            this.pnllDatoCliente.Controls.Add(this.txtTipoCarga);
            this.pnllDatoCliente.Location = new System.Drawing.Point(4, 58);
            this.pnllDatoCliente.Name = "pnllDatoCliente";
            this.pnllDatoCliente.Size = new System.Drawing.Size(793, 271);
            this.pnllDatoCliente.TabIndex = 30;
            // 
            // textBoxItotal
            // 
            this.textBoxItotal.Location = new System.Drawing.Point(459, 140);
            this.textBoxItotal.Name = "textBoxItotal";
            this.textBoxItotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxItotal.TabIndex = 30;
            // 
            // textBoxMpago
            // 
            this.textBoxMpago.Location = new System.Drawing.Point(156, 140);
            this.textBoxMpago.Name = "textBoxMpago";
            this.textBoxMpago.Size = new System.Drawing.Size(100, 20);
            this.textBoxMpago.TabIndex = 29;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(319, 143);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(69, 13);
            this.lblImporteTotal.TabIndex = 28;
            this.lblImporteTotal.Text = "ImporteTotal:";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(12, 143);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(88, 13);
            this.lblMetodoPago.TabIndex = 27;
            this.lblMetodoPago.Text = "Metodo de pago:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(535, 55);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 26;
            // 
            // txtFechas
            // 
            this.txtFechas.AutoSize = true;
            this.txtFechas.Location = new System.Drawing.Point(474, 58);
            this.txtFechas.Name = "txtFechas";
            this.txtFechas.Size = new System.Drawing.Size(40, 13);
            this.txtFechas.TabIndex = 25;
            this.txtFechas.Text = "Fecha:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(98, 94);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(655, 20);
            this.textBoxDireccion.TabIndex = 24;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(180, 50);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(271, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // textBoxTipoCarga
            // 
            this.textBoxTipoCarga.Location = new System.Drawing.Point(595, 10);
            this.textBoxTipoCarga.Name = "textBoxTipoCarga";
            this.textBoxTipoCarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoCarga.TabIndex = 22;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(351, 15);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 21;
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Location = new System.Drawing.Point(132, 15);
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(113, 20);
            this.textBoxRuc.TabIndex = 20;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(280, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 13);
            this.txtCodigo.TabIndex = 19;
            this.txtCodigo.Text = "Codigo:";
            // 
            // textDireccion
            // 
            this.textDireccion.AutoSize = true;
            this.textDireccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(12, 102);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(80, 19);
            this.textDireccion.TabIndex = 5;
            this.textDireccion.Text = "Direccion:";
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(12, 50);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(162, 19);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.Text = "Apellidos y Nombres:";
            // 
            // txtRuc
            // 
            this.txtRuc.AutoSize = true;
            this.txtRuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(12, 18);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(96, 19);
            this.txtRuc.TabIndex = 0;
            this.txtRuc.Text = "N° de R.U.C";
            // 
            // txtTipoCarga
            // 
            this.txtTipoCarga.AutoSize = true;
            this.txtTipoCarga.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCarga.Location = new System.Drawing.Point(474, 13);
            this.txtTipoCarga.Name = "txtTipoCarga";
            this.txtTipoCarga.Size = new System.Drawing.Size(115, 19);
            this.txtTipoCarga.TabIndex = 2;
            this.txtTipoCarga.Text = "Tipo de Carga:";
            // 
            // textCrupotrc
            // 
            this.textCrupotrc.AutoSize = true;
            this.textCrupotrc.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCrupotrc.ForeColor = System.Drawing.Color.Red;
            this.textCrupotrc.Location = new System.Drawing.Point(338, 6);
            this.textCrupotrc.Name = "textCrupotrc";
            this.textCrupotrc.Size = new System.Drawing.Size(107, 19);
            this.textCrupotrc.TabIndex = 27;
            this.textCrupotrc.Text = "GRUPO TRC";
            // 
            // txtTRC
            // 
            this.txtTRC.AutoSize = true;
            this.txtTRC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRC.Location = new System.Drawing.Point(260, 25);
            this.txtTRC.Name = "txtTRC";
            this.txtTRC.Size = new System.Drawing.Size(304, 19);
            this.txtTRC.TabIndex = 26;
            this.txtTRC.Text = "TRANSPORTE RODRIGO CARRANZA";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvFactura.Location = new System.Drawing.Point(4, 335);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.Size = new System.Drawing.Size(793, 54);
            this.dgvFactura.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Importe Total";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de Carga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Metodo de Pago";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "R.U.C";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cliente";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.btnAgregarFactura);
            this.Controls.Add(this.txtDatosCliente);
            this.Controls.Add(this.pnllDatoCliente);
            this.Controls.Add(this.textCrupotrc);
            this.Controls.Add(this.txtTRC);
            this.Controls.Add(this.dgvFactura);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.pnllDatoCliente.ResumeLayout(false);
            this.pnllDatoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnAgregarFactura;
        private System.Windows.Forms.Label txtDatosCliente;
        private System.Windows.Forms.Panel pnllDatoCliente;
        private System.Windows.Forms.TextBox textBoxItotal;
        private System.Windows.Forms.TextBox textBoxMpago;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label txtFechas;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTipoCarga;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxRuc;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label textDireccion;
        private System.Windows.Forms.Label txtNombres;
        private System.Windows.Forms.Label txtRuc;
        private System.Windows.Forms.Label txtTipoCarga;
        private System.Windows.Forms.Label textCrupotrc;
        private System.Windows.Forms.Label txtTRC;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}