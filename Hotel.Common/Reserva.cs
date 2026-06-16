using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Common
{
    public class Reserva // Public: para que sea accesible a cualquier proyecto
    {
        public int Id { get; set; }

        // Referencia a la habitacion reservada
        public int HabitacionId { get; set; }

        // Referencia al huesped que hace la reserva
        public int HuespedId { get; set; }     
        
        public DateTime FechaEntrada { get; set; }

        public DateTime FechaSalida { get; set; }

        // Calculado en negocio: dias x TarifaNoche
        public decimal TotalCalculado { get; set; }

        // "Activa" o "Cancelada"
        public string Estado { get; set; } = "Activa"; 
    }
}