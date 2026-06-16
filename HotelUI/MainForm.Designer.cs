namespace HotelUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabReservas = new TabPage();
            panelReserva = new Hotel.UI.ReservaInputPanel();
            lblStatus = new Label();
            btnCancelarReserva = new Button();
            dgvReservas = new DataGridView();
            tabHabitaciones = new TabPage();
            panelHabitacion = new Hotel.UI.HabitacionInputPanel();
            label1 = new Label();
            btnEliminarHabitacion = new Button();
            dgvHabitaciones = new DataGridView();
            tabHuespedes = new TabPage();
            panelHuesped = new Hotel.UI.HuespedInputPanel();
            btnEliminarHuesped = new Button();
            dgvHuespedes = new DataGridView();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            tabHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            tabHuespedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHuespedes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabReservas);
            tabControl1.Controls.Add(tabHabitaciones);
            tabControl1.Controls.Add(tabHuespedes);
            tabControl1.Location = new Point(215, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(472, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabReservas
            // 
            tabReservas.BackColor = SystemColors.ButtonHighlight;
            tabReservas.Controls.Add(panelReserva);
            tabReservas.Controls.Add(lblStatus);
            tabReservas.Controls.Add(btnCancelarReserva);
            tabReservas.Controls.Add(dgvReservas);
            tabReservas.Location = new Point(4, 24);
            tabReservas.Name = "tabReservas";
            tabReservas.Size = new Size(464, 542);
            tabReservas.TabIndex = 0;
            tabReservas.Text = "Reservas";

            // 
            // panelReserva
            // 
            panelReserva.Location = new Point(169, 271);
            panelReserva.Name = "panelReserva";
            panelReserva.Size = new Size(299, 275);
            panelReserva.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Lime;
            lblStatus.Location = new Point(249, 472);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.Location = new Point(72, 507);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(75, 23);
            btnCancelarReserva.TabIndex = 3;
            btnCancelarReserva.Text = "Cancelarrrr";
            btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // dgvReservas
            // 
            dgvReservas.BackgroundColor = SystemColors.ActiveCaption;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(-4, 0);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(466, 270);
            dgvReservas.TabIndex = 1;
            // 
            // tabHabitaciones
            // 
            tabHabitaciones.Controls.Add(panelHabitacion);
            tabHabitaciones.Controls.Add(label1);
            tabHabitaciones.Controls.Add(btnEliminarHabitacion);
            tabHabitaciones.Controls.Add(dgvHabitaciones);
            tabHabitaciones.Location = new Point(4, 24);
            tabHabitaciones.Name = "tabHabitaciones";
            tabHabitaciones.Size = new Size(464, 542);
            tabHabitaciones.TabIndex = 1;
            tabHabitaciones.Text = "Habitaciones";
            tabHabitaciones.UseVisualStyleBackColor = true;
            // 
            // panelHabitacion
            // 
            panelHabitacion.Location = new Point(202, 281);
            panelHabitacion.Name = "panelHabitacion";
            panelHabitacion.Size = new Size(259, 250);
            panelHabitacion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(323, 427);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // btnEliminarHabitacion
            // 
            btnEliminarHabitacion.Location = new Point(121, 466);
            btnEliminarHabitacion.Name = "btnEliminarHabitacion";
            btnEliminarHabitacion.Size = new Size(75, 23);
            btnEliminarHabitacion.TabIndex = 3;
            btnEliminarHabitacion.Text = "Eliminar";
            btnEliminarHabitacion.UseVisualStyleBackColor = true;
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.BackgroundColor = SystemColors.ActiveCaption;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Location = new Point(-4, 0);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.Size = new Size(472, 275);
            dgvHabitaciones.TabIndex = 0;
            // 
            // tabHuespedes
            // 
            tabHuespedes.Controls.Add(panelHuesped);
            tabHuespedes.Controls.Add(btnEliminarHuesped);
            tabHuespedes.Controls.Add(dgvHuespedes);
            tabHuespedes.Controls.Add(label2);
            tabHuespedes.Location = new Point(4, 24);
            tabHuespedes.Name = "tabHuespedes";
            tabHuespedes.Size = new Size(464, 542);
            tabHuespedes.TabIndex = 2;
            tabHuespedes.Text = "Huéspedes";
            tabHuespedes.UseVisualStyleBackColor = true;
            // 
            // panelHuesped
            // 
            panelHuesped.Location = new Point(181, 279);
            panelHuesped.Name = "panelHuesped";
            panelHuesped.Size = new Size(280, 253);
            panelHuesped.TabIndex = 9;
            // 
            // btnEliminarHuesped
            // 
            btnEliminarHuesped.Location = new Point(100, 474);
            btnEliminarHuesped.Name = "btnEliminarHuesped";
            btnEliminarHuesped.Size = new Size(75, 23);
            btnEliminarHuesped.TabIndex = 8;
            btnEliminarHuesped.Text = "Eliminar";
            btnEliminarHuesped.UseVisualStyleBackColor = true;
            // 
            // dgvHuespedes
            // 
            dgvHuespedes.BackgroundColor = SystemColors.ActiveCaption;
            dgvHuespedes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHuespedes.Location = new Point(3, 3);
            dgvHuespedes.Name = "dgvHuespedes";
            dgvHuespedes.Size = new Size(458, 270);
            dgvHuespedes.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(299, 415);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(947, 716);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabReservas.ResumeLayout(false);
            tabReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            tabHabitaciones.ResumeLayout(false);
            tabHabitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            tabHuespedes.ResumeLayout(false);
            tabHuespedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHuespedes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabReservas;
        private TabPage tabHabitaciones;
        private TabPage tabHuespedes;
        private DataGridView dgvReservas;
        private Hotel.UI.ReservaInputPanel reservaInputPanel1;
        private Label lblStatus;
        private Button btnCancelarReserva;
        private DataGridView dgvHabitaciones;
        private Hotel.UI.HabitacionInputPanel habitacionInputPanel1;
        private Button btnEliminarHabitacion;
        private Label label1;
        private Button btnEliminarHuesped;
        private Hotel.UI.HuespedInputPanel huespedInputPanel1;
        private DataGridView dgvHuespedes;
        private Label label2;
        private Hotel.UI.ReservaInputPanel panelReserva;
        private Hotel.UI.HabitacionInputPanel panelHabitacion;
        private Hotel.UI.HuespedInputPanel panelHuesped;
    }
}
