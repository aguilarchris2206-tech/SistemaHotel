using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Common;
using Hotel.DataAccess;

namespace Hotel.Business
{
    public class HuespedService
    {
        private readonly HuespedRepository _repo; // Variable privada de solo lectura, de tipo HuespedRepository

        public HuespedService() { _repo = new HuespedRepository(); } // Constructor
        public List<Huesped> ObtenerTodos() => _repo.ObtenerTodos(); // Lectura

        public void Guardar(Huesped huesped) // Insercion y Actualizacion
        {
            // Validaciones

            // 1. Si el nombre esta en blanco
            if (string.IsNullOrWhiteSpace(huesped.Nombre))
                throw new BusinessException("El nombre del huesped es requerido", "HUES_NOMBRE_REQ");

            // 2. Si el nombre es muy corto
            if (huesped.Nombre.Length < 3)
                throw new BusinessException("El nombre debe tener al menos 3 caracteres", "HUES_NOMBRE_CORTO");

            // 3. Si la cedula esta en blanco
            if (string.IsNullOrWhiteSpace(huesped.Cedula))
                throw new BusinessException("La cedula del huesped es requerida", "HUES_CEDULA_REQ");

            // 4. Si ya existe otro huesped activo con la misma cedula
            var duplicado = _repo.ObtenerTodosSinFiltro()
                .FirstOrDefault(h => h.Cedula == huesped.Cedula && h.Activo && h.Id != huesped.Id);

            if (duplicado != null)
                throw new BusinessException($"Ya existe un huesped registrado con la cedula {huesped.Cedula}", "HUES_CEDULA_DUP");

            // 5. Si el telefono esta en blanco
            if (string.IsNullOrWhiteSpace(huesped.Telefono))
                throw new BusinessException("El telefono del huesped es requerido", "HUES_TEL_REQ");

            // Si Id == 0 es un huesped nuevo; si no, es una actualizacion
            if (huesped.Id == 0) _repo.Insertar(huesped);
            else _repo.Actualizar(huesped);
        }

        public void Eliminar(int id) => _repo.Eliminar(id); // Eliminacion
    }
}
