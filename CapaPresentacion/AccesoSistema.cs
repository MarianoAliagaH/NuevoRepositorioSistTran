﻿using System;
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
    public partial class AccesoSistema : Form
    {
        public AccesoSistema()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Administrador ventanaAdministrador = new Administrador();
            
            ventanaAdministrador.Show();
            this.Hide();
        }
    }
}
