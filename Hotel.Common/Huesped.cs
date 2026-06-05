using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Hotel.Common
{
    public class Huesped
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        // Cédula de identidad - debe ser única por huésped
        public string Cedula { get; set; } = "";

        public string Telefono { get; set; } = "";

        // Permite el borrado lógico sin eliminar el registro
        public bool Activo { get; set; } = true;
    }
}
