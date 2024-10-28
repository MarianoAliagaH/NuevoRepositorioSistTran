using CapaEntidad;
using CapaLogicaNegocio;
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
    public partial class FleteRuta : Form
    {
        private int idCliente;
        public FleteRuta(int idCliente)
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.idCliente = idCliente;
            ObtenerNombre_RUC();
        }
        public void ObtenerNombre_RUC()
        {
            entCliente c = logCliente.Instancia.ObtenerNombre_RUC(idCliente);
            if (c != null)
            {
                lblNombreEmpresa.Text = "Cliente: "+c.RazonSocial.ToString();
                lblNumRUC.Text = "R.U.C. Nº : "+c.RUC.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró la información del cliente.");
            }
        }
        private void btnAbrirFleteRutaNuevo_Click(object sender, EventArgs e)
        {
            FleteRutaNuevo ventantaFleteRutaNuevo = new FleteRutaNuevo();
            ventantaFleteRutaNuevo.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
