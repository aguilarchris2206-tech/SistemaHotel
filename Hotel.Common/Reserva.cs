using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
namespace Hotel.Common
{
    public class Reserva
    {
        public int Id { get; set; }

        public int HabitacionId { get; set; }

        public int HuespedId { get; set; }

        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public decimal TotalCalculado { get; set; }

        public string Estado { get; set; } = "Activa";
    }
}
