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
    public partial class ProcesamientodeFacturasporCliente : Form
    {
        public ProcesamientodeFacturasporCliente()
        {
            InitializeComponent();
            CBbuscarClienteFac.SelectedIndex = 0;
        }

        private void CBbuscarClienteFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBbuscarClienteFac.SelectedIndex == 2) {
                BuscarNombreClienteOT buscarNombre = new BuscarNombreClienteOT();
                buscarNombre.Show();
            }
        }

        private void btnReporteFacCliente_Click(object sender, EventArgs e)
        {
            ReportesdeOrdenesdeTrabajo ReportOrdenTra = new ReportesdeOrdenesdeTrabajo();
            ReportOrdenTra.Show();
        }
    }
}
