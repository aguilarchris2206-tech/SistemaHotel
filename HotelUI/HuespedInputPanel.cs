using Hotel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class HuespedInputPanel : UserControl
    {
        public event EventHandler<Huesped>? GuardarSolicitado; // Declaramos un evento personalizado

        public HuespedInputPanel() // Constructor de nuestro user control
        {
            InitializeComponent();
        }

        public void CargarHuesped(Huesped h) // Cargamos los valores del huesped en los campos para actualizar
        {
            txtNombre.Text = h.Nombre;
            txtCedula.Text = h.Cedula;
            txtTelefono.Text = h.Telefono;
            txtNombre.Tag = h.Id;

            // Forzamos el color real para que PlaceholderTextBox sepa que hay contenido real y no placeholder
            txtNombre.ForeColor = SystemColors.WindowText;
            txtCedula.ForeColor = SystemColors.WindowText;
            txtTelefono.ForeColor = SystemColors.WindowText;
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Definimos el comportamiento del boton guardar
        {
            lblError.Text = "";
            try
            {
                var h = new Huesped
                {
                    // Operador ternario para comprobar el valor en Tag -- mismo patron que el proyecto del profe
                    Id = txtNombre.Tag is int id ? id : 0,
                    Nombre = txtNombre.TextoReal,
                    Cedula = txtCedula.TextoReal,
                    Telefono = txtTelefono.TextoReal,
                };
                GuardarSolicitado?.Invoke(this, h); // Llamamos al evento personalizado y le pasamos el huesped
            }
            catch (FormatException) // Capturamos posible excepcion de formato
            {
                lblError.Text = "Verifique que los campos sean correctos!";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) // Definimos el comportamiento del boton Limpiar
        {
            // Limpiamos todos los campos
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
            txtNombre.Tag = 0;
            lblError.Text = "";
            txtNombre.Focus();
        }

        private void HuespedInputPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
