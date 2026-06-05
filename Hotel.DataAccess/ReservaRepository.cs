using Hotel.Common;
using System.Text.Json;

namespace Hotel.DataAccess
{
    /// <summary>
    /// Repositorio de reservas. Maneja lectura y escritura en archivo JSON.
    /// </summary>
    public class ReservaRepository
    {
        private readonly string _archivo = "reservas.json";

        /// <summary>
        /// Devuelve todas las reservas activas (no canceladas).
        /// </summary>
        public List<Reserva> ObtenerTodas()
        {
            var todas = CargarDesdeArchivo();
            return todas.Where(r => r.Estado == "Activa").ToList();
        }

        /// <summary>
        /// Inserta una nueva reserva y guarda en el archivo JSON.
        /// </summary>
        public void Insertar(Reserva reserva)
        {
            var lista = CargarDesdeArchivo();
            reserva.Id = lista.Count > 0 ? lista.Max(r => r.Id) + 1 : 1;
            lista.Add(reserva);
            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Actualiza una reserva existente y guarda los cambios.
        /// </summary>
        public void Actualizar(Reserva reserva)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(r => r.Id == reserva.Id)
                ?? throw new Exception($"Reserva ID {reserva.Id} no encontrada.");

            existente.HabitacionId = reserva.HabitacionId;
            existente.HuespedId = reserva.HuespedId;
            existente.FechaEntrada = reserva.FechaEntrada;
            existente.FechaSalida = reserva.FechaSalida;
            existente.TotalCalculado = reserva.TotalCalculado;

            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Cancela una reserva (borrado lógico por estado).
        /// </summary>
        public void Cancelar(int id)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(r => r.Id == id)
                ?? throw new Exception($"Reserva ID {id} no encontrada.");

            existente.Estado = "Cancelada"; // No se borra físicamente
            GuardarEnArchivo(lista);
        }

        /// <summary>
        /// Devuelve todas las reservas sin filtro.
        /// Necesario para validar disponibilidad de habitaciones.
        /// </summary>
        public List<Reserva> ObtenerTodasSinFiltro() => CargarDesdeArchivo();

        // ── Métodos privados de persistencia ──────────────────────────────────

        private List<Reserva> CargarDesdeArchivo()
        {
            if (!File.Exists(_archivo)) return new List<Reserva>();
            var json = File.ReadAllText(_archivo);
            return JsonSerializer.Deserialize<List<Reserva>>(json) ?? new List<Reserva>();
        }

        private void GuardarEnArchivo(List<Reserva> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_archivo, json);
        }
    }
}
