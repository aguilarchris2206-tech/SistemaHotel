namespace Hotel.UI
{
    partial class ReservaInputPanel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtHabitacionId = new PlaceholderTextBox();
            txtHuespedId = new PlaceholderTextBox();
            dtpEntrada = new DateTimePicker();
            dtpSalida = new DateTimePicker();
            lblError = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtHabitacionId
            // 
            txtHabitacionId.Location = new Point(185, 17);
            txtHabitacionId.Name = "txtHabitacionId";
            txtHabitacionId.Size = new Size(100, 23);
            txtHabitacionId.TabIndex = 0;
            txtHabitacionId.Text = "ID Habitación";
            // 
            // txtHuespedId
            // 
            txtHuespedId.Location = new Point(185, 57);
            txtHuespedId.Name = "txtHuespedId";
            txtHuespedId.Size = new Size(100, 23);
            txtHuespedId.TabIndex = 1;
            txtHuespedId.Text = "ID Huesped";
            // 
            // dtpEntrada
            // 
            dtpEntrada.CustomFormat = "Short";
            dtpEntrada.Location = new Point(85, 100);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(200, 23);
            dtpEntrada.TabIndex = 3;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(85, 142);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(200, 23);
            dtpSalida.TabIndex = 4;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = SystemColors.Control;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(187, 186);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(187, 221);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(40, 221);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ReservaInputPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblError);
            Controls.Add(dtpSalida);
            Controls.Add(dtpEntrada);
            Controls.Add(txtHuespedId);
            Controls.Add(txtHabitacionId);
            Name = "ReservaInputPanel";
            Size = new Size(299, 275);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PlaceholderTextBox txtHabitacionId;
        private PlaceholderTextBox txtHuespedId;
        private DateTimePicker dtpEntrada;
        private DateTimePicker dtpSalida;
        private Label lblError;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}
