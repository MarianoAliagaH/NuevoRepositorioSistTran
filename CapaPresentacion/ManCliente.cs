using CapaLogicaNegocio;
using CapaEntidad;
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
    public partial class ManCliente : Form
    {
        public ManCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarClientes();
            gbDatos.Enabled = false;
            cmbTipoPersona.SelectedIndex = 0;
        }

        public void ListarClientes()
        {
            var clientes = logCliente.Instancia.ListarCliente();
            dgvListaClientes.DataSource = clientes;

            // Configurar las columnas visibles
            dgvListaClientes.Columns.Clear();
            dgvListaClientes.AutoGenerateColumns = false;

            dgvListaClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID"
            });

            dgvListaClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RazonSocial",
                HeaderText = "Razón Social"
            });

            dgvListaClientes.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado"
            });
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            //LimpiarControles();
            btnNuevo.Enabled = false;
            gbDatos.Enabled = true;
            txtId.Enabled = false;
            txtRazonSocial.Focus();
            cbEstado.Checked = true;
            btnGuardar.Visible = true;
            cbEstado.Enabled = true;
            btnEditar.Enabled = false;
            //btnModificar.Visible = false;
        }

        public void LimpiarControles()
        {
            txtId.Text = "";
            txtRazonSocial.Text = "";
            txtRUC.Text = "";
            cmbTipoPersona.SelectedIndex = 0;
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtUbigeo.Text = "";
            cbEstado.Checked = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //LimpiarVariables();
            gbDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnNuevo.Enabled = false;
            gbDatos.Enabled=true;
            btnEditar.Enabled = true;

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Crear una nueva instancia de entCliente
                entCliente c = new entCliente();
                // Asignar valores a las propiedades del cliente
                c.RazonSocial = txtRazonSocial.Text.Trim();
                c.RUC = txtRUC.Text.Trim();
                // Validar la selección del tipo de persona
                if (cmbTipoPersona.SelectedIndex == 1)
                {
                    c.IdTipoPersona = 1;
                }
                else if (cmbTipoPersona.SelectedIndex == 2)
                {
                    c.IdTipoPersona = 2;
                }
                else
                {
                    MessageBox.Show("Seleccione Tipo Persona");
                    return; // Salir del método si no se selecciona un tipo de persona válido
                }
                // Asignar los demás valores
                c.Telefono = txtTelefono.Text.Trim();
                c.Correo = txtCorreo.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Ubigeo = txtUbigeo.Text.Trim();
                c.Estado = cbEstado.Checked;
                // Llamar al método para insertar el cliente
                bool resultado = logCliente.Instancia.InsertarCliente(c);

                // Verificar el resultado de la inserción
                if (resultado)
                {
                    MessageBox.Show("Cliente guardado exitosamente.");
                    LimpiarControles();
                    gbDatos.Enabled = false;
                    ListarClientes();
                    dgvListaClientes.Focus();
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al guardar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
