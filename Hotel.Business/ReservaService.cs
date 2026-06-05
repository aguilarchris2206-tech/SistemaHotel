using Hotel.Common;
using Hotel.DataAccess;

namespace Hotel.Business
{
    /// <summary>
    /// Servicio de reservas. Contiene la operación de negocio principal del sistema:
    /// calcular tarifa y validar disponibilidad de habitaciones.
    /// </summary>
    public class ReservaService
    {
        private readonly ReservaRepository _repoReserva;
        private readonly HabitacionRepository _repoHabitacion;

        /// <summary>
        /// Constructor. Instancia los repositorios necesarios para la operación de negocio.
        /// </summary>
        public ReservaService()
        {
            _repoReserva = new ReservaRepository();
            _repoHabitacion = new HabitacionRepository();
        }

        /// <summary>
        /// Devuelve todas las reservas activas.
        /// </summary>
        public List<Reserva> ObtenerTodas() => _repoReserva.ObtenerTodas();

        /// <summary>
        /// Guarda una reserva. Aplica validaciones de fechas, disponibilidad
        /// y calcula automáticamente el total a cobrar.
        /// </summary>
        public void Guardar(Reserva reserva)
        {
            // Validación 1: Las fechas son obligatorias y deben ser coherentes
            if (reserva.FechaEntrada == default || reserva.FechaSalida == default)
                throw new BusinessException("Las fechas de entrada y salida son requeridas.", "RES_FECHAS_REQ");

            // Validación 2: La fecha de salida debe ser posterior a la de entrada
            if (reserva.FechaSalida <= reserva.FechaEntrada)
                throw new BusinessException("La fecha de salida debe ser posterior a la fecha de entrada.", "RES_FECHA_INV");

            // Validación 3: La fecha de entrada no puede ser en el pasado (solo para reservas nuevas)
            if (reserva.Id == 0 && reserva.FechaEntrada.Date < DateTime.Today)
                throw new BusinessException("La fecha de entrada no puede ser en el pasado.", "RES_FECHA_PASADO");

            // Validación 4: Verificar disponibilidad — la habitación no debe tener reservas
            // activas que se crucen con el rango de fechas solicitado
            var reservasActivas = _repoReserva.ObtenerTodasSinFiltro()
                .Where(r => r.HabitacionId == reserva.HabitacionId
                         && r.Estado == "Activa"
                         && r.Id != reserva.Id); // Excluimos la reserva actual al editar

            bool hayCruce = reservasActivas.Any(r =>
                reserva.FechaEntrada < r.FechaSalida &&
                reserva.FechaSalida > r.FechaEntrada);

            if (hayCruce)
                throw new BusinessException("La habitación no está disponible en las fechas seleccionadas.", "RES_NO_DISPONIBLE");

            // Operación de negocio: calcular el total automáticamente
            // Total = número de noches × tarifa por noche de la habitación
            var habitacion = _repoHabitacion.ObtenerTodosSinFiltro()
                .FirstOrDefault(h => h.Id == reserva.HabitacionId)
                ?? throw new BusinessException("La habitación seleccionada no existe.", "RES_HAB_INVALIDA");

            int noches = (reserva.FechaSalida - reserva.FechaEntrada).Days;
            reserva.TotalCalculado = noches * habitacion.TarifaNoche;

            if (reserva.Id == 0) _repoReserva.Insertar(reserva);
            else _repoReserva.Actualizar(reserva);
        }

        /// <summary>
        /// Cancela una reserva por su ID (borrado lógico por estado).
        /// </summary>
        public void Cancelar(int id) => _repoReserva.Cancelar(id);
    }
}
