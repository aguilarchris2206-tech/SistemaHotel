using Hotel.Common;
using System.Text.Json;

// La capa de datos maneja la persistencia de la información.
// En lugar de una base de datos, usamos archivos JSON para que los datos
// sobrevivan al cerrar la aplicación — igual que el proyecto de ejemplo
// pero con persistencia real en disco.

namespace Hotel.DataAccess
{
    /// <summary>
    /// Repositorio de habitaciones. Maneja lectura y escritura en archivo JSON.
    /// </summary>
    public class HabitacionRepository
    {
        // Ruta del archivo JSON donde se persisten las habitaciones
        private readonly string _archivo = "habitaciones.json";

        // Contador para el siguiente ID disponible
        private static int _nextId = 1;

        /// <summary>
        /// Carga todas las habitaciones activas desde el archivo JSON.
        /// </summary>
        public List<Habitacion> ObtenerTodas()
        {
            var todas = CargarDesdeArchivo();
            return todas.Where(h => h.Activa).ToList(); // Solo devolvemos las activas
        }

        /// <summary>
        /// Inserta una nueva habitación y guarda en el archivo JSON.
        /// </summary>
        public void Insertar(Habitacion habitacion)
        {
            var lista = CargarDesdeArchivo();

            // Calculamos el siguiente ID basado en el máximo existente
            habitacion.Id = lista.Count > 0 ? lista.Max(h => h.Id) + 1 : 1;

            lista.Add(habitacion);
            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Actualiza una habitación existente y guarda los cambios.
        /// </summary>
        public void Actualizar(Habitacion habitacion)
        {
            var lista = CargarDesdeArchivo();

            // Buscamos la habitación por ID; si no existe, lanzamos excepción técnica
            var existente = lista.FirstOrDefault(h => h.Id == habitacion.Id)
                ?? throw new Exception($"Habitación ID {habitacion.Id} no encontrada.");

            // Actualizamos los campos modificables
            existente.Numero = habitacion.Numero;
            existente.Tipo = habitacion.Tipo;
            existente.TarifaNoche = habitacion.TarifaNoche;

            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Borrado lógico: marca la habitación como inactiva en lugar de eliminarla.
        /// </summary>
        public void Eliminar(int id)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(h => h.Id == id)
                ?? throw new Exception($"Habitación ID {id} no encontrada.");

            existente.Activa = false; // Borrado lógico, igual que en el proyecto de ejemplo
            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Devuelve todas las habitaciones (incluyendo inactivas).
        /// Usado internamente para validaciones de disponibilidad.
        /// </summary>
        public List<Habitacion> ObtenerTodasSinFiltro() => CargarDesdeArchivo();

        // ── Métodos privados de persistencia ──────────────────────────────────

        /// <summary>
        /// Lee el archivo JSON y deserializa la lista de habitaciones.
        /// Si el archivo no existe, devuelve una lista vacía.
        /// </summary>
        private List<Habitacion> CargarDesdeArchivo()
        {
            if (!File.Exists(_archivo)) return new List<Habitacion>();

            var json = File.ReadAllText(_archivo);
            return JsonSerializer.Deserialize<List<Habitacion>>(json) ?? new List<Habitacion>();
        }

        /// <summary>
        /// Serializa la lista de habitaciones y la guarda en el archivo JSON.
        /// </summary>
        private void GuardarEnArchivo(List<Habitacion> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_archivo, json);
        }
    }
}
