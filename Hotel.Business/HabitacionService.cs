using Hotel.Common;
using Hotel.DataAccess;

// La capa de negocio es donde viven las reglas del sistema.
// Nunca se accede al repositorio directamente desde la UI —
// todo pasa por aquí, igual que ProductoService en el proyecto de ejemplo.

namespace Hotel.Business
{
    /// <summary>
    /// Servicio de habitaciones. Contiene las validaciones y reglas de negocio.
    /// </summary>
    public class HabitacionService
    {
        // Referencia al repositorio — solo la capa de negocio lo usa
        private readonly HabitacionRepository _repo;

        /// <summary>
        /// Constructor. Instancia el repositorio internamente.
        /// </summary>
        public HabitacionService() { _repo = new HabitacionRepository(); }

        /// <summary>
        /// Devuelve todas las habitaciones activas.
        /// </summary>
        public List<Habitacion> ObtenerTodas() => _repo.ObtenerTodas();

        /// <summary>
        /// Guarda una habitación (insertar si Id==0, actualizar si Id>0).
        /// Aplica las validaciones de negocio antes de persistir.
        /// </summary>
        public void Guardar(Habitacion habitacion)
        {
            // Validación 1: El número de habitación es obligatorio
            if (string.IsNullOrWhiteSpace(habitacion.Numero))
                throw new BusinessException("El número de habitación es requerido.", "HAB_NUMERO_REQ");

            // Validación 2: El tipo de habitación es obligatorio
            if (string.IsNullOrWhiteSpace(habitacion.Tipo))
                throw new BusinessException("El tipo de habitación es requerido.", "HAB_TIPO_REQ");

            // Validación 3: La tarifa por noche debe ser mayor a cero
            if (habitacion.TarifaNoche <= 0)
                throw new BusinessException("La tarifa por noche debe ser mayor a cero.", "HAB_TARIFA_INV");

            // Validación 4: No puede existir otra habitación activa con el mismo número
            var duplicado = _repo.ObtenerTodosSinFiltro()
                .FirstOrDefault(h => h.Numero == habitacion.Numero && h.Activa && h.Id != habitacion.Id);

            if (duplicado != null)
                throw new BusinessException($"Ya existe una habitación con el número {habitacion.Numero}.", "HAB_NUMERO_DUP");

            // Si Id == 0 es una habitación nueva; si no, es una actualización
            if (habitacion.Id == 0) _repo.Insertar(habitacion);
            else _repo.Actualizar(habitacion);
        }

        /// <summary>
        /// Elimina lógicamente una habitación por su ID.
        /// </summary>
        public void Eliminar(int id) => _repo.Eliminar(id);
    }
}
