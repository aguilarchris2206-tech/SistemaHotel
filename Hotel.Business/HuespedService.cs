using Hotel.Common;
using Hotel.DataAccess;

namespace Hotel.Business
{
    /// <summary>
    /// Servicio de huéspedes. Contiene las validaciones y reglas de negocio.
    /// </summary>
    public class HuespedService
    {
        private readonly HuespedRepository _repo;

        public HuespedService() { _repo = new HuespedRepository(); }

        /// <summary>
        /// Devuelve todos los huéspedes activos.
        /// </summary>
        public List<Huesped> ObtenerTodos() => _repo.ObtenerTodos();

        /// <summary>
        /// Guarda un huésped aplicando validaciones de negocio.
        /// </summary>
        public void Guardar(Huesped huesped)
        {
            // Validación 1: El nombre es obligatorio y debe tener al menos 3 caracteres
            if (string.IsNullOrWhiteSpace(huesped.Nombre))
                throw new BusinessException("El nombre del huésped es requerido.", "HUES_NOMBRE_REQ");

            if (huesped.Nombre.Length < 3)
                throw new BusinessException("El nombre debe tener al menos 3 caracteres.", "HUES_NOMBRE_CORTO");

            // Validación 2: La cédula es obligatoria
            if (string.IsNullOrWhiteSpace(huesped.Cedula))
                throw new BusinessException("La cédula del huésped es requerida.", "HUES_CEDULA_REQ");

            // Validación 3: No puede existir otro huésped activo con la misma cédula
            var duplicado = _repo.ObtenerTodosSinFiltro()
                .FirstOrDefault(h => h.Cedula == huesped.Cedula && h.Activo && h.Id != huesped.Id);

            if (duplicado != null)
                throw new BusinessException($"Ya existe un huésped registrado con la cédula {huesped.Cedula}.", "HUES_CEDULA_DUP");

            // Validación 4: El teléfono es obligatorio
            if (string.IsNullOrWhiteSpace(huesped.Telefono))
                throw new BusinessException("El teléfono del huésped es requerido.", "HUES_TEL_REQ");

            if (huesped.Id == 0) _repo.Insertar(huesped);
            else _repo.Actualizar(huesped);
        }

        /// <summary>
        /// Elimina lógicamente un huésped por su ID.
        /// </summary>
        public void Eliminar(int id) => _repo.Eliminar(id);
    }
}
