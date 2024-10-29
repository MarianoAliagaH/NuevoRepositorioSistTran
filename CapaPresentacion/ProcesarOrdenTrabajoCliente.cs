using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ProcesarOrdenTrabajoCliente : Form
    {
        public ProcesarOrdenTrabajoCliente()
        {
            InitializeComponent();
            CBbuscarCliente.SelectedIndex = 0;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            GenerarNuevaFactura GenerarFactura = new GenerarNuevaFactura();
            GenerarFactura.Show();
        }

        private void CBbuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBbuscarCliente.SelectedIndex == 2) { 
                BuscarNombreClienteOT buscarNombre = new BuscarNombreClienteOT();
                buscarNombre.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
