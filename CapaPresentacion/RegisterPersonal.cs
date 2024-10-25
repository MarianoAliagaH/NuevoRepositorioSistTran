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
    public partial class RegisterPersonal : Form
    {
        public RegisterPersonal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja baja = new Baja();
            baja.Show();
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            HistorialDocumento historialDocumento = new HistorialDocumento();
            historialDocumento.Show();
        }

        private void btnNuevoPersonal_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.Show();
        }
    }
}
