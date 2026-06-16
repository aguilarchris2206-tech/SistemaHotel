using Hotel.Business;
using Hotel.Common;
namespace HotelUI
{
    public partial class MainForm : Form
    {
        private readonly ReservaService _serviceReserva;       // Instanciamos los servicios de la capa business
        private readonly HabitacionService _serviceHabitacion;
        private readonly HuespedService _serviceHuesped;
        public MainForm()
        {
            InitializeComponent();
            _serviceReserva = new ReservaService();
            _serviceHabitacion = new HabitacionService();
            _serviceHuesped = new HuespedService();

            // Llamada a los eventos personalizados de cada input panel
            panelReserva.GuardarSolicitado += PanelReserva_GuardarSolicitado;
            panelHabitacion.GuardarSolicitado += PanelHabitacion_GuardarSolicitado;
            panelHuesped.GuardarSolicitado += PanelHuesped_GuardarSolicitado;
        }

        private void MainForm_Load(object sender, EventArgs e) // Acciones a realizar cuando el formulario carga
        {
            CargarGridReservas();     // Llenar los datagrids con los datos predefinidos
            CargarGridHabitaciones();
            CargarGridHuespedes();
        }
        // ── Metodos para cargar los DataGridViews ────────────────────────────

        private void CargarGridReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = _serviceReserva.ObtenerTodas();
            lblStatus.Text = $"Total reservas activas: {dgvReservas.Rows.Count}";
        }
        private void CargarGridHabitaciones()
        {
            dgvHabitaciones.DataSource = null;
            dgvHabitaciones.DataSource = _serviceHabitacion.ObtenerTodas();
            lblStatus.Text = $"Total habitaciones disponibles: {dgvHabitaciones.Rows.Count}";
        }
        private void CargarGridHuespedes()
        {
            dgvHuespedes.DataSource = null;
            dgvHuespedes.DataSource = _serviceHuesped.ObtenerTodos();
            lblStatus.Text = $"Total huespedes registrados: {dgvHuespedes.Rows.Count}";
        }
        // ── Eventos personalizados de cada panel (GuardarSolicitado) ─────────

        private void PanelReserva_GuardarSolicitado(object? sender, Reserva r)
        {
            try
            { // Intentamos
                _serviceReserva.Guardar(r); // guardar la reserva nueva/modificada
                CargarGridReservas();        // Refrescamos el grid para que muestre los datos nuevos
                lblStatus.Text = r.Id == 0 ? "Reserva creada con exito!" : "Reserva actualizada satisfactoriamente!";
            }
            catch (BusinessException ex) // Capturamos excepcion logica de la capa business
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatus.Text = $"Error: {ex.CodigoError}";
            }
            catch (Exception)
            {
                // Capturamos otro tipo de excepcion no esperada
                MessageBox.Show("Ocurrio un error inesperado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanelHabitacion_GuardarSolicitado(object? sender, Habitacion h)
        {
            try
            {
                _serviceHabitacion.Guardar(h);
                CargarGridHabitaciones();
                lblStatus.Text = h.Id == 0 ? "Habitacion creada con exito!" : "Habitacion actualizada satisfactoriamente!";
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatus.Text = $"Error: {ex.CodigoError}";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanelHuesped_GuardarSolicitado(object? sender, Huesped h)
        {
            try
            {
                _serviceHuesped.Guardar(h);
                CargarGridHuespedes();
                lblStatus.Text = h.Id == 0 ? "Huesped creado con exito!" : "Huesped actualizado satisfactoriamente!";
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatus.Text = $"Error: {ex.CodigoError}";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Doble clic en DataGridViews para editar ──────────────────────────

        private void dgvReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Si lo que damos doble clic es el encabezado del dgv retornamos

            // Casteamos la fila seleccionada en dgv a tipo Reserva
            var r = (Reserva)dgvReservas.Rows[e.RowIndex].DataBoundItem;

            panelReserva.CargarReserva(r); // Cargamos la informacion en los campos de texto
            lblStatus.Text = $"Editando reserva ID: {r.Id}";
        }

        private void dgvHabitaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var h = (Habitacion)dgvHabitaciones.Rows[e.RowIndex].DataBoundItem;

            panelHabitacion.CargarHabitacion(h); // Cargamos la informacion en los campos de texto
            lblStatus.Text = $"Editando habitacion: {h.Numero}";
        }

        private void dgvHuespedes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var h = (Huesped)dgvHuespedes.Rows[e.RowIndex].DataBoundItem;

            panelHuesped.CargarHuesped(h); // Cargamos la informacion en los campos de texto
            lblStatus.Text = $"Editando huesped: {h.Nombre}";
        }

        // ── Botones Eliminar ─────────────────────────────────────────────────
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null) return;

            var r = (Reserva)dgvReservas.CurrentRow.DataBoundItem; // Tomamos la fila y la convertimos a tipo Reserva

            if (MessageBox.Show($"Cancelar reserva ID {r.Id}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _serviceReserva.Cancelar(r.Id);
                CargarGridReservas();
                lblStatus.Text = "Reserva cancelada con exito!";
            }
        }

        private void btnEliminarHabitacion_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow == null) return;

            var h = (Habitacion)dgvHabitaciones.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Eliminar habitacion \"{h.Numero}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _serviceHabitacion.Eliminar(h.Id);
                CargarGridHabitaciones();
                lblStatus.Text = "Habitacion eliminada con exito!";
            }
        }

        private void btnEliminarHuesped_Click(object sender, EventArgs e)
        {
            if (dgvHuespedes.CurrentRow == null) return;

            var h = (Huesped)dgvHuespedes.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Eliminar huesped \"{h.Nombre}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _serviceHuesped.Eliminar(h.Id);
                CargarGridHuespedes();
                lblStatus.Text = "Huesped eliminado con exito!";
            }
        }

        private void tabReservas_Click(object sender, EventArgs e)
        {

        }

        private void dgvHuespedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}