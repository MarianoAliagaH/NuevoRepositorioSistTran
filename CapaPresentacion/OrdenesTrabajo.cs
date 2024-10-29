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
    public partial class OrdenesTrabajo : Form
    {
        public OrdenesTrabajo()
        {
            InitializeComponent();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            NuevaOrdenTrabajo nuevaOrdenTrabajo = new NuevaOrdenTrabajo();
            nuevaOrdenTrabajo.Show();
        }

        private void btnAdjuntarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnMonitoreo_Click(object sender, EventArgs e)
        {
            MonitoreoOrdenTrabajo monitoreoOrdenTrabajo =  new MonitoreoOrdenTrabajo();
            monitoreoOrdenTrabajo.Show();
        }

        private void btnInformacionOrdenTrabajo_Click(object sender, EventArgs e)
        {
            NuevaOrdenTrabajo nuevaOrdenTrabajo = new NuevaOrdenTrabajo();
            nuevaOrdenTrabajo.Show();
        }
    }
}
