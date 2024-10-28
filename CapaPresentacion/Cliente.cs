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
        private int idClienteSeleccionado;

        public Cliente()
        {
            InitializeComponent();
            ListarCliente();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void ListarCliente()
        {
            var clientes = logCliente.Instancia.ListarCliente();
            dgvCliente.DataSource = clientes;
            lblTotalClientes.Text = $"Total de Clientes: {clientes.Count}";
        }

        private void ClienteNuevo_ClienteAgregado(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnAbrirClienteNuevo_Click(object sender, EventArgs e)
        {
            ClienteNuevo ventanaCliente = new ClienteNuevo();
            //ventanaCliente.ClienteAgregado += ClienteNuevo_ClienteAgregado;
            ventanaCliente.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClienteInformacion_ClienteModificado(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnAbrirClienteInfo_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado > 0)
            {
                ClienteInformacion ventanaClienteInfo = new ClienteInformacion(idClienteSeleccionado);
                //ventanaClienteInfo.ClienteModificado += ClienteInformacion_ClienteModificado;
                ventanaClienteInfo.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente primero.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado > 0)
            {
                FleteRuta ventanaFleteRuta = new FleteRuta(idClienteSeleccionado);
                ventanaFleteRuta.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente primero.");
            }

        }

        private void btnDeshabilitaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Id = idClienteSeleccionado;
                logCliente.Instancia.DeshabilitarCliente(c);
                ListarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
                    idClienteSeleccionado = Convert.ToInt32(filaActual.Cells[0].Value);
                    Console.WriteLine("ID del Cliente seleccionado en MantenedorCliente: " + idClienteSeleccionado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el ID del cliente: " + ex.Message);
            }
        }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
