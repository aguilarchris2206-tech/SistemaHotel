using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Common;
using Hotel.DataAccess;

namespace Hotel.Business
{
    public class HabitacionService
    {
        private readonly HabitacionRepository _repo; // Variable privada de solo lectura, de tipo HabitacionRepository

        public HabitacionService() { _repo = new HabitacionRepository(); } // Constructor
        public List<Habitacion> ObtenerTodas() => _repo.ObtenerTodas(); // Lectura

        public void Guardar(Habitacion habitacion) // Insercion y Actualizacion
        {
            // Validaciones

            // 1. Si el numero de habitacion esta en blanco
            if (string.IsNullOrWhiteSpace(habitacion.Numero))
                throw new BusinessException("El numero de habitacion es requerido", "HAB_NUMERO_REQ");

            // 2. Si el tipo de habitacion esta en blanco
            if (string.IsNullOrWhiteSpace(habitacion.Tipo))
                throw new BusinessException("El tipo de habitacion es requerido", "HAB_TIPO_REQ");

            // 3. Si la tarifa por noche es menor o igual a cero
            if (habitacion.TarifaNoche <= 0)
                throw new BusinessException("La tarifa por noche debe ser mayor a cero", "HAB_TARIFA_INV");

            // 4. Si ya existe una habitacion activa con el mismo numero
            var duplicado = _repo.ObtenerTodasSinFiltro()
                .FirstOrDefault(h => h.Numero == habitacion.Numero && h.Activa && h.Id != habitacion.Id);

            if (duplicado != null)
                throw new BusinessException($"Ya existe una habitacion con el numero {habitacion.Numero}", "HAB_NUMERO_DUP");

            // Si Id == 0 es una habitacion nueva; si no, es una actualizacion
            if (habitacion.Id == 0) _repo.Insertar(habitacion);
            else _repo.Actualizar(habitacion);
        }

        public void Eliminar(int id) => _repo.Eliminar(id); // Eliminacion
    }
}
