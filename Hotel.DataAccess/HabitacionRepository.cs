using Hotel.Common;
using System.Text.Json;


namespace Hotel.DataAccess
{
    public class HabitacionRepository
    {
        private readonly string _archivo = "habitaciones.json";

        // Contador para el siguiente ID disponible
        private static int _nextId = 1;

        public List<Habitacion> ObtenerTodas()
        {
            var todas = CargarDesdeArchivo();
            return todas.Where(h => h.Activa).ToList(); // Solo devolvemos las activas
        }

        public void Insertar(Habitacion habitacion)
        {
            var lista = CargarDesdeArchivo();

            // Calculamos el siguiente ID basado en el máximo existente
            habitacion.Id = lista.Count > 0 ? lista.Max(h => h.Id) + 1 : 1;

            lista.Add(habitacion);
            GuardarEnArchivo(lista);
        }

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

        public void Eliminar(int id)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(h => h.Id == id)
                ?? throw new Exception($"Habitación ID {id} no encontrada.");

            existente.Activa = false; // Borrado lógico, igual que en el proyecto de ejemplo
            GuardarEnArchivo(lista);
        }

        public List<Habitacion> ObtenerTodasSinFiltro() => CargarDesdeArchivo();

        // ── Métodos privados de persistencia ──────────────────────────────────
        private List<Habitacion> CargarDesdeArchivo()
        {
            if (!File.Exists(_archivo)) return new List<Habitacion>();

            var json = File.ReadAllText(_archivo);
            return JsonSerializer.Deserialize<List<Habitacion>>(json) ?? new List<Habitacion>();
        }

        private void GuardarEnArchivo(List<Habitacion> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_archivo, json);
        }
    }
}
