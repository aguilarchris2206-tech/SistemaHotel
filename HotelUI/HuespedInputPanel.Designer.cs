namespace Hotel.UI
{
    partial class HuespedInputPanel
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
            txtNombre = new PlaceholderTextBox();
            txtCedula = new PlaceholderTextBox();
            txtTelefono = new PlaceholderTextBox();
            lblError = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(85, 64);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(170, 23);
            txtCedula.TabIndex = 1;
            txtCedula.Text = "Cedula";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(85, 106);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.Text = "Teléfono";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(85, 148);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(180, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(22, 195);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // HuespedInputPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblError);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Name = "HuespedInputPanel";
            Size = new Size(280, 253);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PlaceholderTextBox txtNombre;
        private PlaceholderTextBox txtCedula;
        private PlaceholderTextBox txtTelefono;
        private Label lblError;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}
