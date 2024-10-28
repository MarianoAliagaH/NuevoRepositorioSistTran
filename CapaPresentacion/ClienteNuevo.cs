using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ClienteNuevo : Form
    {
        //public event EventHandler ClienteAgregado;
        public ClienteNuevo()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LimpiarVariables()
        {
            txtNumeroDocumento.Text = "";
            txtRazonSocial.Text = "";
            cmbTipoPersona.SelectedIndex = 0;
            txtDepartamento.Text = "";
            txtProvincia.Text = "";
            txtDistrito.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtSitioWeb.Text = "";
        }
        private void btnInsertaCliente_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                /*
                entCliente c = new entCliente();
                c.numeroDocumento = txtNumeroDocumento.Text.Trim();
                c.razonSocial = txtRazonSocial.Text.Trim();
                if (cmbTipoPersona.SelectedIndex == 1)
                {
                    c.idTipoPersona = 1;
                }
                else if (cmbTipoPersona.SelectedIndex == 2)
                {
                    c.idTipoPersona = 2;
                }
                else
                {
                    MessageBox.Show("Seleccione Tipo Persona");
                }
                c.departamento = txtDepartamento.Text.Trim();
                c.provincia = txtProvincia.Text.Trim();
                c.distrito = txtDistrito.Text.Trim();
                c.direccion = txtDireccion.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.correo = txtCorreo.Text.Trim();
                c.activo = cbActivo.Checked;
                c.sitioWeb = txtSitioWeb.Text.Trim();
                c.fechaRegistro = dtpFechaRegistro.Value;
                logCliente.Instancia.InsertarCliente(c);
                // Disparar el evento ClienteAgregado
                ClienteAgregado?.Invoke(this, EventArgs.Empty);

                // Cerrar el formulario this.Dispose();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;

        }

        private void ClienteNuevo_Load(object sender, EventArgs e)
        {
            cbActivo.Checked = true;
            cmbTipoPersona.SelectedIndex = 0;
        }
    }
}
