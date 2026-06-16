using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Common;

namespace Hotel.DataAccess
{
    public class ReservaRepository
    {
        // Creamos una lista estatica de reservas (los datos viven en memoria mientras la app esta abierta)
        private static readonly List<Reserva> _datos = new()
        {
            new Reserva { Id = 1, HabitacionId = 1, HuespedId = 1, FechaEntrada = DateTime.Today, FechaSalida = DateTime.Today.AddDays(3), TotalCalculado = 105000, Estado = "Activa" },
        };

        public static int _nextId = 2; // Siguiente identificador en la lista

        // CRUD

        // Metodo para obtener todas las reservas activas del repositorio
        public List<Reserva> ObtenerTodas() => _datos.Where(r => r.Estado == "Activa").ToList();

        public void Insertar(Reserva reserva) // Metodo para insertar reservas nuevas
        {
            reserva.Id = _nextId++; // asignar el id de la reserva
            _datos.Add(reserva);    // agregar la reserva en nuestra lista _datos
        }

        public void Actualizar(Reserva reserva)
        {
            var ex = _datos.FirstOrDefault(r => r.Id == reserva.Id)
                ?? throw new Exception($"Reserva ID {reserva.Id} no encontrada!");

            ex.HabitacionId = reserva.HabitacionId;
            ex.HuespedId = reserva.HuespedId;
            ex.FechaEntrada = reserva.FechaEntrada;
            ex.FechaSalida = reserva.FechaSalida;
            ex.TotalCalculado = reserva.TotalCalculado;
        }

        public void Cancelar(int id) // Cancelar = borrado logico por estado (no se borra fisicamente)
        {
            var ex = _datos.FirstOrDefault(r => r.Id == id)
                ?? throw new Exception($"Reserva ID {id} no encontrada!");

            ex.Estado = "Cancelada"; // Cambiamos el estado en lugar de eliminar
        }

        public List<Reserva> ObtenerTodasSinFiltro() => _datos.ToList(); // Sin filtro -- para validar disponibilidad
    }
}
