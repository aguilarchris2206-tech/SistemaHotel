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
    public partial class ReservaInputPanel : UserControl
    {
        public event EventHandler<Reserva>? GuardarSolicitado; // Declaramos un evento personalizado

        public ReservaInputPanel() // Constructor de nuestro user control
        {
            InitializeComponent();
        }

        public void CargarReserva(Reserva r) // Cargamos los valores de la reserva en los campos para actualizar
        {
            txtHabitacionId.Text = r.HabitacionId.ToString();
            txtHuespedId.Text = r.HuespedId.ToString();
            dtpEntrada.Value = r.FechaEntrada;
            dtpSalida.Value = r.FechaSalida;
            txtHabitacionId.Tag = r.Id;
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Definimos el comportamiento del boton guardar
        {
            lblError.Text = "";
            try
            {
                var r = new Reserva
                {
                    // Operador ternario para comprobar el valor en Tag (mismo patron que el proyecto del profe)
                    Id = txtHabitacionId.Tag is int id ? id : 0,
                    HabitacionId = int.Parse(txtHabitacionId.TextoReal),
                    HuespedId = int.Parse(txtHuespedId.TextoReal),
                    FechaEntrada = dtpEntrada.Value.Date,
                    FechaSalida = dtpSalida.Value.Date,
                };
                GuardarSolicitado?.Invoke(this, r); // Llamamos al evento personalizado y le pasamos la reserva
            }
            catch (FormatException) // Capturamos posible excepcion de formato
            {
                lblError.Text = "Verifique que ID Habitacion e ID Huesped sean numericos!";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) // Definimos el comportamiento del boton Limpiar
        {
            // Limpiamos todos los campos
            txtHabitacionId.Text = "";
            txtHuespedId.Text = "";
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);
            txtHabitacionId.Tag = 0;
            lblError.Text = "";
            txtHabitacionId.Focus();
        }

        private void ReservaInputPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
