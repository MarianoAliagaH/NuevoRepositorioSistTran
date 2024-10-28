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
            if (CBbusquedadOrdenTC.Items.Count > 0) {
                CBbusquedadOrdenTC.SelectedIndex = 0;
            }
        }

        private void CBbusquedadOrdenTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBbusquedadOrdenTC.SelectedIndex == 2)
            {
                BuscarNombreClienteOT NombreCliente = new BuscarNombreClienteOT();
                NombreCliente.Show();
            }
        }

        private void btnGerararFacturaOTC_Click(object sender, EventArgs e)
        {
            GenerarNuevaFactura nuevaFactura = new GenerarNuevaFactura();
            nuevaFactura.Show();
        }
    }
}
