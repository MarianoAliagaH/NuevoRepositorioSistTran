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
    public partial class ClienteInformacion : Form
    {
        private int idCliente; //Ajustar el constructor del formulario para aceptar el idCliente como parámetro.
        //public event EventHandler ClienteModificado;

        public ClienteInformacion(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            CargarInformacionCliente();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //btnModificarCliente.Enabled = false;
        }

        public void CargarInformacionCliente()
        {
            /*
            entCliente c = logCliente.Instancia.InformacionClienteID(idCliente);
            if (c != null)
            {
                // Mostrar la información del cliente en los controles del formulario
                txtNumeroDocumento.Text = c.numeroDocumento.ToString();
                txtRazonSocial.Text = c.razonSocial.ToString();
                cmbTipoPersona.SelectedIndex = c.idTipoPersona;
                txtDepartamento.Text = c.departamento.ToString();
                txtProvincia.Text = c.provincia.ToString();
                txtDistrito.Text = c.distrito.ToString();
                txtDireccion.Text = c.direccion.ToString();
                txtTelefono.Text = c.telefono.ToString();
                txtCorreo.Text = c.correo.ToString();
                cbActivo.Checked = c.activo;
                txtSitioWeb.Text = c.sitioWeb.ToString();
                dtpFechaRegistro.Text = c.fechaRegistro.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("No se encontró la información del cliente.");
            }*/
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            //btnModificarCliente.Enabled = true;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            /*
            //Actualizar
            try
            {
                entCliente c = new entCliente
                {
                    idCliente = idCliente,
                    numeroDocumento = txtNumeroDocumento.Text.Trim(),
                    razonSocial = txtRazonSocial.Text.Trim(),
                    idTipoPersona = cmbTipoPersona.SelectedIndex,
                    departamento = txtDepartamento.Text.Trim(),
                    provincia = txtProvincia.Text.Trim(),
                    distrito = txtDistrito.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    correo = txtCorreo.Text.Trim(),
                    activo = cbActivo.Checked,
                    sitioWeb = txtSitioWeb.Text.Trim(),
                    fechaRegistro=dtpFechaRegistro.Value
                };
                bool actualizado = logCliente.Instancia.EditarCliente(c);
                if (actualizado)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    ClienteModificado?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ClienteInformacion: " + ex.Message);
            }*/
        }
    }
}
