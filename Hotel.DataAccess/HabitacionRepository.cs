using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Common;

namespace Hotel.DataAccess
{
    public class HabitacionRepository
    {
        // Creamos una lista estatica de habitaciones (los datos viven en memoria mientras la app esta abierta)
        private static readonly List<Habitacion> _datos = new()
        {
            new Habitacion { Id = 1, Numero = "101", Tipo = "Simple",  TarifaNoche = 35000 },
            new Habitacion { Id = 2, Numero = "102", Tipo = "Doble",   TarifaNoche = 55000 },
            new Habitacion { Id = 3, Numero = "201", Tipo = "Suite",   TarifaNoche = 95000 },
        };

        public static int _nextId = 4; // Siguiente identificador en la lista

        // CRUD

        // Metodo para obtener todas las habitaciones activas del repositorio
        public List<Habitacion> ObtenerTodas() => _datos.Where(h => h.Activa).ToList();

        public void Insertar(Habitacion habitacion) // Metodo para insertar habitaciones nuevas
        {
            habitacion.Id = _nextId++; // asignar el id de la habitacion
            _datos.Add(habitacion);    // agregar la habitacion en nuestra lista _datos
        }

        public void Actualizar(Habitacion habitacion)
        {
            // Buscamos la habitacion por ID; si no existe, lanzamos excepcion tecnica
            var ex = _datos.FirstOrDefault(h => h.Id == habitacion.Id)
                ?? throw new Exception($"Habitacion ID {habitacion.Id} no encontrada!");

            // Actualizando valores de la habitacion encontrada
            ex.Numero = habitacion.Numero;
            ex.Tipo = habitacion.Tipo;
            ex.TarifaNoche = habitacion.TarifaNoche;
        }

        public void Eliminar(int id) // Con el id es suficiente para identificar la habitacion
        {
            var ex = _datos.FirstOrDefault(h => h.Id == id) // Recorremos la lista buscando el match del id
                ?? throw new Exception($"Habitacion ID {id} no encontrada!"); // Si no aparece: lanzamos excepcion

            ex.Activa = false; // Si aparece: marcamos la habitacion como inactiva (borrado logico)
        }

        public List<Habitacion> ObtenerTodasSinFiltro() => _datos.ToList(); // Sin filtro de activo para validaciones internas
    }
}
