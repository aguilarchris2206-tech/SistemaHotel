using Hotel.Common;
using Hotel.DataAccess;



namespace Hotel.Business
{
    public class HabitacionService
    {
        private readonly HabitacionRepository _repo;

        public HabitacionService() { _repo = new HabitacionRepository(); }

        public List<Habitacion> ObtenerTodas() => _repo.ObtenerTodas();

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

        public void Eliminar(int id) => _repo.Eliminar(id);
    }
}
