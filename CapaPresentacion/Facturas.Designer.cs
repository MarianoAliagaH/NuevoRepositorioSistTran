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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.txtDatosCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cB2NumeroAño = new System.Windows.Forms.ComboBox();
            this.rB3Fechas = new System.Windows.Forms.RadioButton();
            this.rB2AñoFecha = new System.Windows.Forms.RadioButton();
            this.rB1Todas = new System.Windows.Forms.RadioButton();
            this.pnllDatoCliente = new System.Windows.Forms.Panel();
            this.ComboBuscar = new System.Windows.Forms.ComboBox();
            this.textBoxRuc = new System.Windows.Forms.TextBox();
            this.textCrupotrc = new System.Windows.Forms.Label();
            this.txtTRC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnllDatoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(16, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 331);
            this.dataGridView1.TabIndex = 43;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Serie y N°";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SubTotal";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "% I.G.V";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Monto I.G.V";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total (S/.)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Valor Referencial";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estado";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(55, 455);
            this.lblOpciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(108, 24);
            this.lblOpciones.TabIndex = 42;
            this.lblOpciones.Text = "Opciones ";
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.AutoSize = true;
            this.txtDatosCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosCliente.Location = new System.Drawing.Point(55, 14);
            this.txtDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.Size = new System.Drawing.Size(162, 24);
            this.txtDatosCliente.TabIndex = 38;
            this.txtDatosCliente.Text = "Buscar Factura";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPagar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Location = new System.Drawing.Point(16, 469);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1417, 105);
            this.panel2.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1161, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Imprimir ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(76, 36);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 41);
            this.btnPagar.TabIndex = 23;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(217, 36);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 41);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(505, 14);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(112, 24);
            this.lblFiltrar.TabIndex = 35;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bFiltrar);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cB2NumeroAño);
            this.panel1.Controls.Add(this.rB3Fechas);
            this.panel1.Controls.Add(this.rB2AñoFecha);
            this.panel1.Controls.Add(this.rB1Todas);
            this.panel1.Location = new System.Drawing.Point(377, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 86);
            this.panel1.TabIndex = 40;
            // 
            // bFiltrar
            // 
            this.bFiltrar.Location = new System.Drawing.Point(916, 9);
            this.bFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(100, 71);
            this.bFiltrar.TabIndex = 7;
            this.bFiltrar.Text = "Filtrar";
            this.bFiltrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(755, 30);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(609, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Todos los meses";
            // 
            // cB2NumeroAño
            // 
            this.cB2NumeroAño.FormattingEnabled = true;
            this.cB2NumeroAño.Location = new System.Drawing.Point(248, 30);
            this.cB2NumeroAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cB2NumeroAño.Name = "cB2NumeroAño";
            this.cB2NumeroAño.Size = new System.Drawing.Size(85, 24);
            this.cB2NumeroAño.TabIndex = 3;
            this.cB2NumeroAño.Text = "2015";
            // 
            // rB3Fechas
            // 
            this.rB3Fechas.AutoSize = true;
            this.rB3Fechas.Location = new System.Drawing.Point(488, 31);
            this.rB3Fechas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rB3Fechas.Name = "rB3Fechas";
            this.rB3Fechas.Size = new System.Drawing.Size(79, 20);
            this.rB3Fechas.TabIndex = 2;
            this.rB3Fechas.TabStop = true;
            this.rB3Fechas.Text = "Fechas :";
            this.rB3Fechas.UseVisualStyleBackColor = true;
            // 
            // rB2AñoFecha
            // 
            this.rB2AñoFecha.AutoSize = true;
            this.rB2AñoFecha.Location = new System.Drawing.Point(105, 34);
            this.rB2AñoFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rB2AñoFecha.Name = "rB2AñoFecha";
            this.rB2AñoFecha.Size = new System.Drawing.Size(91, 20);
            this.rB2AñoFecha.TabIndex = 1;
            this.rB2AñoFecha.TabStop = true;
            this.rB2AñoFecha.Text = "Año y Mes";
            this.rB2AñoFecha.UseVisualStyleBackColor = true;
            // 
            // rB1Todas
            // 
            this.rB1Todas.AutoSize = true;
            this.rB1Todas.Location = new System.Drawing.Point(4, 34);
            this.rB1Todas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rB1Todas.Name = "rB1Todas";
            this.rB1Todas.Size = new System.Drawing.Size(68, 20);
            this.rB1Todas.TabIndex = 0;
            this.rB1Todas.TabStop = true;
            this.rB1Todas.Text = "Todas";
            this.rB1Todas.UseVisualStyleBackColor = true;
            // 
            // pnllDatoCliente
            // 
            this.pnllDatoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnllDatoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnllDatoCliente.Controls.Add(this.ComboBuscar);
            this.pnllDatoCliente.Controls.Add(this.textBoxRuc);
            this.pnllDatoCliente.Location = new System.Drawing.Point(16, 27);
            this.pnllDatoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnllDatoCliente.Name = "pnllDatoCliente";
            this.pnllDatoCliente.Size = new System.Drawing.Size(353, 86);
            this.pnllDatoCliente.TabIndex = 39;
            // 
            // ComboBuscar
            // 
            this.ComboBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBuscar.FormattingEnabled = true;
            this.ComboBuscar.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ComboBuscar.Location = new System.Drawing.Point(8, 30);
            this.ComboBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBuscar.Name = "ComboBuscar";
            this.ComboBuscar.Size = new System.Drawing.Size(165, 24);
            this.ComboBuscar.TabIndex = 23;
            this.ComboBuscar.Text = "Buscar por N°";
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Location = new System.Drawing.Point(195, 30);
            this.textBoxRuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(136, 22);
            this.textBoxRuc.TabIndex = 20;
            // 
            // textCrupotrc
            // 
            this.textCrupotrc.AutoSize = true;
            this.textCrupotrc.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCrupotrc.ForeColor = System.Drawing.Color.Red;
            this.textCrupotrc.Location = new System.Drawing.Point(241, -21);
            this.textCrupotrc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textCrupotrc.Name = "textCrupotrc";
            this.textCrupotrc.Size = new System.Drawing.Size(129, 24);
            this.textCrupotrc.TabIndex = 37;
            this.textCrupotrc.Text = "GRUPO TRC";
            // 
            // txtTRC
            // 
            this.txtTRC.AutoSize = true;
            this.txtTRC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRC.Location = new System.Drawing.Point(673, -21);
            this.txtTRC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTRC.Name = "txtTRC";
            this.txtTRC.Size = new System.Drawing.Size(370, 24);
            this.txtTRC.TabIndex = 36;
            this.txtTRC.Text = "TRANSPORTE RODRIGO CARRANZA";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.txtDatosCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnllDatoCliente);
            this.Controls.Add(this.textCrupotrc);
            this.Controls.Add(this.txtTRC);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnllDatoCliente.ResumeLayout(false);
            this.pnllDatoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label txtDatosCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bFiltrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cB2NumeroAño;
        private System.Windows.Forms.RadioButton rB3Fechas;
        private System.Windows.Forms.RadioButton rB2AñoFecha;
        private System.Windows.Forms.RadioButton rB1Todas;
        private System.Windows.Forms.Panel pnllDatoCliente;
        private System.Windows.Forms.ComboBox ComboBuscar;
        private System.Windows.Forms.TextBox textBoxRuc;
        private System.Windows.Forms.Label textCrupotrc;
        private System.Windows.Forms.Label txtTRC;
    }
}