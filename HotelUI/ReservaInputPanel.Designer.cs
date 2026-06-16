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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtHabitacionId
            // 
            txtHabitacionId.Location = new Point(15, 57);
            txtHabitacionId.Name = "txtHabitacionId";
            txtHabitacionId.Size = new Size(100, 23);
            txtHabitacionId.TabIndex = 0;
            // 
            // txtHuespedId
            // 
            txtHuespedId.Location = new Point(162, 57);
            txtHuespedId.Name = "txtHuespedId";
            txtHuespedId.Size = new Size(100, 23);
            txtHuespedId.TabIndex = 1;
            // 
            // dtpEntrada
            // 
            dtpEntrada.CustomFormat = "Short";
            dtpEntrada.Location = new Point(299, 57);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(200, 23);
            dtpEntrada.TabIndex = 3;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(526, 57);
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
            btnGuardar.Location = new Point(559, 221);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(316, 221);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "ID Habitación";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 25);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "ID Huesped";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 25);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha de Inicio";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 25);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Cierre";
            // 
            // ReservaInputPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblError);
            Controls.Add(dtpSalida);
            Controls.Add(dtpEntrada);
            Controls.Add(txtHuespedId);
            Controls.Add(txtHabitacionId);
            Name = "ReservaInputPanel";
            Size = new Size(748, 276);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
