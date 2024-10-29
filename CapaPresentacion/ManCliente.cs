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
        private int idClienteSeleccionado;
        public ManCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarClientes();
            gbDatos.Enabled = false;
            cmbTipoPersona.SelectedIndex = 0;
            ConfigurarBotonesInicial();
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
            LimpiarControles();
            gbDatos.Enabled = true;
            txtId.Enabled = false;
            txtRazonSocial.Focus();
            cbEstado.Checked = true;
            gbListaClientes.Enabled = false;
            ConfigurarBotonesNuevo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            ConfigurarBotonesInicial();
            btnNuevo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado>0)
            {
                gbDatos.Enabled = true;
                txtId.Enabled = false;
                ConfigurarBotonesEditar();
                try
                {
                    entCliente c = logCliente.Instancia.InformacionClienteID(idClienteSeleccionado);
                    if (c != null)
                    {
                        //txtId.Text = c.Id.ToString();
                        txtRazonSocial.Text = c.RazonSocial;
                        txtRUC.Text = c.RUC;
                        cmbTipoPersona.SelectedIndex = c.IdTipoPersona;
                        txtDireccion.Text = c.Direccion;
                        txtTelefono.Text = c.Telefono;
                        txtCorreo.Text = c.Correo;
                        cbEstado.Checked = c.Estado;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la información del cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la información del cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente de la lista primero");
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente
                {
                    RazonSocial = txtRazonSocial.Text.Trim(),
                    RUC = txtRUC.Text.Trim(),
                    IdTipoPersona = cmbTipoPersona.SelectedIndex,
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Ubigeo = txtUbigeo.Text.Trim(),
                    Estado = cbEstado.Checked
                };

                if (c.IdTipoPersona == 0)
                {
                    MessageBox.Show("Seleccione Tipo Persona");
                    return;
                }

                bool resultado = logCliente.Instancia.InsertarCliente(c);

                if (resultado)
                {
                    MessageBox.Show("Cliente guardado exitosamente.");
                    LimpiarControles();
                    //gbDatos.Enabled = false;
                    ListarClientes();
                    ConfigurarBotonesInicial();
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

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListaClientes.Rows[e.RowIndex];
                idClienteSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtId.Text=idClienteSeleccionado.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente
                {
                    Id = int.Parse(txtId.Text.Trim()),
                    RazonSocial = txtRazonSocial.Text.Trim(),
                    RUC = txtRUC.Text.Trim(),
                    IdTipoPersona = cmbTipoPersona.SelectedIndex,
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Ubigeo = txtUbigeo.Text.Trim(),
                    Estado = cbEstado.Checked
                };

                bool resultado = logCliente.Instancia.EditarCliente(c);

                if (resultado)
                {
                    MessageBox.Show("Cliente modificado exitosamente.");
                    //gbDatos.Enabled = false;
                    idClienteSeleccionado = 0;
                    ConfigurarBotonesInicial();
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarControles();
            ListarClientes();
        }

        private void ConfigurarBotonesInicial()
        {
            LimpiarControles();
            gbListaClientes.Enabled = true;
            gbDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void ConfigurarBotonesNuevo()
        {
            
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultaExterna.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void ConfigurarBotonesEditar()
        {
            gbListaClientes.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultaExterna.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
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
    }
}
