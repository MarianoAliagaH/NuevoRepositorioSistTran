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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            Cliente ventanaCliente = new Cliente();
            ventanaCliente.Show();
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            AccesoSistema ventanaAccesoSistema = new AccesoSistema();
            ventanaAccesoSistema.Show();
            this.Dispose();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
