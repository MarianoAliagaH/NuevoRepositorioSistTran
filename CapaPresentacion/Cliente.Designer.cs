namespace CapaPresentacion
{
    partial class Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAbrirClienteInfo = new System.Windows.Forms.Button();
            this.btnDeshabilitaCliente = new System.Windows.Forms.Button();
            this.btnAbrirClienteNuevo = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmbBuscarCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Clientes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 2;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Location = new System.Drawing.Point(6, 26);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(121, 27);
            this.cmbBuscarCliente.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(349, 26);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnAbrirClienteInfo);
            this.groupBox2.Controls.Add(this.btnDeshabilitaCliente);
            this.groupBox2.Controls.Add(this.btnAbrirClienteNuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones [Clientes]";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1110, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 75);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(526, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(225, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "Fletes por Ruta del Cliente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAbrirClienteInfo
            // 
            this.btnAbrirClienteInfo.Location = new System.Drawing.Point(197, 26);
            this.btnAbrirClienteInfo.Name = "btnAbrirClienteInfo";
            this.btnAbrirClienteInfo.Size = new System.Drawing.Size(75, 75);
            this.btnAbrirClienteInfo.TabIndex = 4;
            this.btnAbrirClienteInfo.Text = "Cliente Info";
            this.btnAbrirClienteInfo.UseVisualStyleBackColor = true;
            this.btnAbrirClienteInfo.Click += new System.EventHandler(this.btnAbrirClienteInfo_Click);
            // 
            // btnDeshabilitaCliente
            // 
            this.btnDeshabilitaCliente.Location = new System.Drawing.Point(990, 26);
            this.btnDeshabilitaCliente.Name = "btnDeshabilitaCliente";
            this.btnDeshabilitaCliente.Size = new System.Drawing.Size(75, 75);
            this.btnDeshabilitaCliente.TabIndex = 3;
            this.btnDeshabilitaCliente.Text = "Cliente Deshabilitar";
            this.btnDeshabilitaCliente.UseVisualStyleBackColor = true;
            this.btnDeshabilitaCliente.Click += new System.EventHandler(this.btnDeshabilitaCliente_Click);
            // 
            // btnAbrirClienteNuevo
            // 
            this.btnAbrirClienteNuevo.Location = new System.Drawing.Point(52, 26);
            this.btnAbrirClienteNuevo.Name = "btnAbrirClienteNuevo";
            this.btnAbrirClienteNuevo.Size = new System.Drawing.Size(75, 75);
            this.btnAbrirClienteNuevo.TabIndex = 1;
            this.btnAbrirClienteNuevo.Text = "Cliente Nuevo";
            this.btnAbrirClienteNuevo.UseVisualStyleBackColor = true;
            this.btnAbrirClienteNuevo.Click += new System.EventHandler(this.btnAbrirClienteNuevo_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 131);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(1240, 397);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Location = new System.Drawing.Point(14, 531);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(133, 19);
            this.lblTotalClientes.TabIndex = 3;
            this.lblTotalClientes.Text = "Total de Clientes:";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cliente";
            this.Text = "Mantenimiento de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAbrirClienteInfo;
        private System.Windows.Forms.Button btnDeshabilitaCliente;
        private System.Windows.Forms.Button btnAbrirClienteNuevo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblTotalClientes;
    }
}