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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(28, 67);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(131, 23);
            txtNumero.TabIndex = 0;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(259, 67);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(112, 23);
            txtTipo.TabIndex = 1;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(481, 67);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 23);
            txtTarifa.TabIndex = 2;
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
            btnGuardar.Location = new Point(495, 185);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(272, 185);
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
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 6;
            label1.Text = "Número de Habitación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Tipo de Habitación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 40);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "Tarifa la Noche";
            // 
            // HabitacionInputPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblError);
            Controls.Add(txtTarifa);
            Controls.Add(txtTipo);
            Controls.Add(txtNumero);
            Name = "HabitacionInputPanel";
            Size = new Size(647, 250);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
