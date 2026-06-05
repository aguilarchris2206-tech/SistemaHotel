using Hotel.Common;
using System.Text.Json;

namespace Hotel.DataAccess
{
    /// <summary>
    /// Repositorio de huéspedes. Maneja lectura y escritura en archivo JSON.
    /// </summary>
    public class HuespedRepository
    {
        private readonly string _archivo = "huespedes.json";

        /// <summary>
        /// Carga todos los huéspedes activos desde el archivo JSON.
        /// </summary>
        public List<Huesped> ObtenerTodos()
        {
            var todos = CargarDesdeArchivo();
            return todos.Where(h => h.Activo).ToList();
        }

        /// <summary>
        /// Inserta un nuevo huésped y guarda en el archivo JSON.
        /// </summary>
        public void Insertar(Huesped huesped)
        {
            var lista = CargarDesdeArchivo();
            huesped.Id = lista.Count > 0 ? lista.Max(h => h.Id) + 1 : 1;
            lista.Add(huesped);
            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Actualiza un huésped existente y guarda los cambios.
        /// </summary>
        public void Actualizar(Huesped huesped)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(h => h.Id == huesped.Id)
                ?? throw new Exception($"Huésped ID {huesped.Id} no encontrado.");

            existente.Nombre = huesped.Nombre;
            existente.Cedula = huesped.Cedula;
            existente.Telefono = huesped.Telefono;

            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Borrado lógico: marca el huésped como inactivo.
        /// </summary>
        public void Eliminar(int id)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(h => h.Id == id)
                ?? throw new Exception($"Huésped ID {id} no encontrado.");

            existente.Activo = false;
            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Devuelve todos los huéspedes sin filtro de estado activo.
        /// Usado para validar cédulas duplicadas.
        /// </summary>
        public List<Huesped> ObtenerTodosSinFiltro() => CargarDesdeArchivo();

        // ── Métodos privados de persistencia ──────────────────────────────────

        private List<Huesped> CargarDesdeArchivo()
        {
            if (!File.Exists(_archivo)) return new List<Huesped>();
            var json = File.ReadAllText(_archivo);
            return JsonSerializer.Deserialize<List<Huesped>>(json) ?? new List<Huesped>();
        }

        private void GuardarEnArchivo(List<Huesped> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_archivo, json);
        }
    }
}
