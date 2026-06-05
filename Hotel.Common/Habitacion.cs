

namespace Hotel.Common
{
    /// <summary>
    /// Representa una habitación del hotel.
    /// Entidad principal del sistema.
    /// </summary>
    public class Habitacion
    {
        public int Id { get; set; }

        // Número visible de la habitación (ej: "101", "302")
        public string Numero { get; set; } = "";

        // Tipo: Simple, Doble, Suite
        public string Tipo { get; set; } = "";

        // Tarifa base por noche en colones
        public decimal TarifaNoche { get; set; }

        // Permite el borrado lógico sin eliminar el registro
        public bool Activa { get; set; } = true;
    }
}
