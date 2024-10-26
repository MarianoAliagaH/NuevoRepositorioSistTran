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
    public partial class OrdenTrabajoAutorizacion : Form
    {
        public OrdenTrabajoAutorizacion()
        {
            InitializeComponent();
        }

        private void BtnSolicitudAuto_Click(object sender, EventArgs e)
        {
            AtenderOrdenTrabajoAutorizacion ventanaAtenderAuto = new AtenderOrdenTrabajoAutorizacion();
            ventanaAtenderAuto.Show();
        }
    }
}
