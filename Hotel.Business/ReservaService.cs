using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Common;
using Hotel.DataAccess;

namespace Hotel.Business
{
    public class ReservaService
    {
        private readonly ReservaRepository _repoReserva;       // Repositorio de reservas
        private readonly HabitacionRepository _repoHabitacion; // Repositorio de habitaciones es necesario para calcular el total

        public ReservaService() // Constructor
        {
            _repoReserva = new ReservaRepository();
            _repoHabitacion = new HabitacionRepository();
        }

        public List<Reserva> ObtenerTodas() => _repoReserva.ObtenerTodas(); // Lectura

        public void Guardar(Reserva reserva) // Insercion y Actualizacion: operacion principal de negocio
        {
            // Validaciones

            // 1. Si la fecha de salida no es posterior a la de entrada
            if (reserva.FechaSalida <= reserva.FechaEntrada)
                throw new BusinessException("La fecha de salida debe ser posterior a la fecha de entrada", "RES_FECHA_INV");

            // 2. Si la fecha de entrada ya paso (solo para reservas nuevas)
            if (reserva.Id == 0 && reserva.FechaEntrada.Date < DateTime.Today)
                throw new BusinessException("La fecha de entrada no puede ser en el pasado", "RES_FECHA_PASADO");

            // 3. Verificamos disponibilidad: la habitacion no debe tener reservas activas que se crucen con el rango solicitado
            var reservasActivas = _repoReserva.ObtenerTodasSinFiltro()
                .Where(r => r.HabitacionId == reserva.HabitacionId
                         && r.Estado == "Activa"
                         && r.Id != reserva.Id); // Excluimos la reserva actual al editar

            bool hayCruce = reservasActivas.Any(r =>
                reserva.FechaEntrada < r.FechaSalida &&
                reserva.FechaSalida > r.FechaEntrada);

            if (hayCruce)
                throw new BusinessException("La habitacion no esta disponible en las fechas seleccionadas", "RES_NO_DISPONIBLE");

            // Operacion de negocio: calculamos el total automaticamente
            // Total = numero de noches x tarifa por noche de la habitacion
            var habitacion = _repoHabitacion.ObtenerTodasSinFiltro()
                .FirstOrDefault(h => h.Id == reserva.HabitacionId)
                ?? throw new BusinessException("La habitacion seleccionada no existe", "RES_HAB_INVALIDA");

            int noches = (reserva.FechaSalida - reserva.FechaEntrada).Days;
            reserva.TotalCalculado = noches * habitacion.TarifaNoche;

            // Si Id == 0 es una reserva nueva; si no, es una actualizacion
            if (reserva.Id == 0) _repoReserva.Insertar(reserva);
            else _repoReserva.Actualizar(reserva);
        }

        public void Cancelar(int id) => _repoReserva.Cancelar(id); // Cancelacion (borrado logico)
    }
}
