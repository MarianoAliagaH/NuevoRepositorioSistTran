using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            ListarCliente();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void ListarCliente()
        {
            
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();

            lblTotalClientes.Text = $"Total de Clientes: {3}";
            /*
            // FiltrarColumnas
            var clientes = logCliente.Instancia.ListarCliente();
            var clientesFiltrados = clientes.Select(c => new
            {
                IdCliente = c.idCliente,
                NumeroDocumento = c.numeroDocumento,
                TipoPersona = c.idTipoPersona, // Asumiendo que tienes una forma de convertir idTipoPersona a un nombre legible
                RazonSocial = c.razonSocial,
                DireccionCompleta = $"{c.direccion}, {c.distrito}, {c.provincia}, {c.departamento}"
            }).ToList();

            dgvCliente.DataSource = clientesFiltrados;
            
            // Personalizar los encabezados de las columnas
            dgvCliente.Columns["IdCliente"].HeaderText = "Codigo";
            dgvCliente.Columns["NumeroDocumento"].HeaderText = "Nº de R.U.C.";
            dgvCliente.Columns["TipoPersona"].HeaderText = "Tipo Persona";
            dgvCliente.Columns["RazonSocial"].HeaderText = "Razón Social";
            dgvCliente.Columns["DireccionCompleta"].HeaderText = "Domicilio Fiscal";

            // Ajustar el ancho de las columnas
            dgvCliente.Columns["IdCliente"].Width = 100;
            dgvCliente.Columns["NumeroDocumento"].Width = 150; // Ancho en píxeles
            dgvCliente.Columns["TipoPersona"].Width = 100;
            dgvCliente.Columns["RazonSocial"].Width = 325;
            dgvCliente.Columns["DireccionCompleta"].Width = 475;
            // Centrar los títulos de las columnas
            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            lblTotalClientes.Text = $"Total de Clientes: {clientes.Count}";*/
        }

        private void btnAbrirClienteNuevo_Click(object sender, EventArgs e)
        {
            ClienteNuevo ventanaCliente = new ClienteNuevo();
            ventanaCliente.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAbrirClienteModificar_Click(object sender, EventArgs e)
        {
            ClienteModificar ventanaClienteModificar = new ClienteModificar();
            ventanaClienteModificar.Show();
        }

        private void btnAbrirClienteInfo_Click(object sender, EventArgs e)
        {
            ClienteModificar ventanaClienteModificar = new ClienteModificar();
            ventanaClienteModificar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FleteRuta ventanaFleteRuta = new FleteRuta();
            ventanaFleteRuta.Show();
        }
    }
}
