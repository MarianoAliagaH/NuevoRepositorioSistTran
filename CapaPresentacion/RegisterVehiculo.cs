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
    public partial class RegisterVehiculo : Form
    {
        public RegisterVehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Show();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            InformacionVehiculo vehiculoV = new InformacionVehiculo();
            vehiculoV.Show();
        }
    }
}
