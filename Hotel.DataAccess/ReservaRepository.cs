using Hotel.Common;
using System.Text.Json;

namespace Hotel.DataAccess
{
    public class ReservaRepository
    {
        private readonly string _archivo = "reservas.json";

        public List<Reserva> ObtenerTodas()
        {
            var todas = CargarDesdeArchivo();
            return todas.Where(r => r.Estado == "Activa").ToList();
        }

        public void Insertar(Reserva reserva)
        {
            var lista = CargarDesdeArchivo();
            reserva.Id = lista.Count > 0 ? lista.Max(r => r.Id) + 1 : 1;
            lista.Add(reserva);
            GuardarEnArchivo(lista);
        }

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

        public void Cancelar(int id)
        {
            var lista = CargarDesdeArchivo();

            var existente = lista.FirstOrDefault(r => r.Id == id)
                ?? throw new Exception($"Reserva ID {id} no encontrada.");

            existente.Estado = "Cancelada"; // No se borra físicamente
            GuardarEnArchivo(lista);
        }

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
