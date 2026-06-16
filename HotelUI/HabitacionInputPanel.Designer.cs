namespace Hotel.UI
{
    partial class HabitacionInputPanel
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
            txtNumero = new PlaceholderTextBox();
            txtTipo = new PlaceholderTextBox();
            txtTarifa = new PlaceholderTextBox();
            lblError = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(114, 19);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(131, 23);
            txtNumero.TabIndex = 0;
            txtNumero.Text = "Numero de Habitación";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(114, 58);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(112, 23);
            txtTipo.TabIndex = 1;
            txtTipo.Text = "Tipo de Habitación";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(114, 96);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 23);
            txtTarifa.TabIndex = 2;
            txtTarifa.Text = "Tarifa la Noche";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(114, 132);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(151, 185);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(28, 185);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // HabitacionInputPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblError);
            Controls.Add(txtTarifa);
            Controls.Add(txtTipo);
            Controls.Add(txtNumero);
            Name = "HabitacionInputPanel";
            Size = new Size(259, 250);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PlaceholderTextBox txtNumero;
        private PlaceholderTextBox txtTipo;
        private PlaceholderTextBox txtTarifa;
        private Label lblError;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}
