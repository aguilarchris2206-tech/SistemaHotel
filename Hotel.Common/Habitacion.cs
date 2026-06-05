

namespace Hotel.Common
{
    public class Habitacion
    {
        public int Id { get; set; }

        // Número visible de la habitación 
        public string Numero { get; set; } = "";

        // Tipo: Simple, Doble, Suite
        public string Tipo { get; set; } = "";

        // Tarifa base por noche
        public decimal TarifaNoche { get; set; }

        // Permite el borrado lógico sin eliminar el registro
        public bool Activa { get; set; } = true;
    }
}
