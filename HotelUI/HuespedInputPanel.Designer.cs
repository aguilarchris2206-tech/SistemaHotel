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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(250, 50);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(170, 23);
            txtCedula.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(465, 50);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 23);
            txtTelefono.TabIndex = 2;
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
            btnGuardar.Location = new Point(529, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(287, 195);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 19);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefono";
            // 
            // HuespedInputPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblError);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Name = "HuespedInputPanel";
            Size = new Size(689, 253);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
