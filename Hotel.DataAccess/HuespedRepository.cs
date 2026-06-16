using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Common;

namespace Hotel.DataAccess
{
    public class HuespedRepository
    {
        // Creamos una lista estatica de huespedes (los datos viven en memoria mientras la app esta abierta)
        private static readonly List<Huesped> _datos = new()
        {
            new Huesped { Id = 1, Nombre = "Carlos Mora",    Cedula = "301450123", Telefono = "88001122" },
            new Huesped { Id = 2, Nombre = "Laura Jimenez",  Cedula = "205670456", Telefono = "72334455" },
            new Huesped { Id = 3, Nombre = "Diego Salazar",  Cedula = "109870789", Telefono = "63219988" },
        };

        public static int _nextId = 4; // Siguiente identificador en la lista

        // CRUD

        // Metodo para obtener todos los huespedes activos del repositorio
        public List<Huesped> ObtenerTodos() => _datos.Where(h => h.Activo).ToList();

        public void Insertar(Huesped huesped) // Metodo para insertar huespedes nuevos
        {
            huesped.Id = _nextId++; // asignar el id del huesped
            _datos.Add(huesped);    // agregar el huesped en nuestra lista _datos
        }

        public void Actualizar(Huesped huesped)
        {
            var ex = _datos.FirstOrDefault(h => h.Id == huesped.Id)
                ?? throw new Exception($"Huesped ID {huesped.Id} no encontrado!");

            ex.Nombre = huesped.Nombre;
            ex.Cedula = huesped.Cedula;
            ex.Telefono = huesped.Telefono;
        }

        public void Eliminar(int id)
        {
            var ex = _datos.FirstOrDefault(h => h.Id == id)
                ?? throw new Exception($"Huesped ID {id} no encontrado!");

            ex.Activo = false; // Borrado logico
        }

        public List<Huesped> ObtenerTodosSinFiltro() => _datos.ToList(); // Sin filtro de activo para validaciones internas
    }
}
