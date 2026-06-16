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
    public partial class HabitacionInputPanel : UserControl
    {
        public event EventHandler<Habitacion>? GuardarSolicitado; // Declaramos un evento personalizado

        public HabitacionInputPanel() // Constructor de nuestro user control
        {
            InitializeComponent();
        }

        public void CargarHabitacion(Habitacion h) // Cargamos los valores de la habitacion en los campos para actualizar
        {
            txtNumero.Text = h.Numero;
            txtTipo.Text = h.Tipo;
            txtTarifa.Text = h.TarifaNoche.ToString();
            txtNumero.Tag = h.Id;
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Definimos el comportamiento del boton guardar
        {
            lblError.Text = "";
            try
            {
                var h = new Habitacion
                {
                    // Operador ternario para comprobar el valor en Tag -- mismo patron que el proyecto del profe
                    Id = txtNumero.Tag is int id ? id : 0,
                    Numero = txtNumero.TextoReal,
                    Tipo = txtTipo.TextoReal,
                    TarifaNoche = decimal.Parse(txtTarifa.TextoReal), // parseamos el valor a decimal para su almacenamiento
                };
                GuardarSolicitado?.Invoke(this, h); // Llamamos al evento personalizado y le pasamos la habitacion
            }
            catch (FormatException) // Capturamos posible excepcion de formato
            {
                lblError.Text = "Verifique que la tarifa sea un valor numerico!";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) // Definimos el comportamiento del boton Limpiar
        {
            // Limpiamos todos los campos
            txtNumero.Text = "";
            txtTipo.Text = "";
            txtTarifa.Text = "";
            txtNumero.Tag = 0;
            lblError.Text = "";
            txtNumero.Focus();
        }

        private void HabitacionInputPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
