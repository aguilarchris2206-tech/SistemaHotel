using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Hotel.UI
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholder = ""; // valor temporal a mostrar
        private bool _showing = false;    // define si el texto de placeholder se muestra o no

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Placeholder
        {
            get => _placeholder; // llamamos _placeholder
            set
            {
                _placeholder = value; // asignamos un valor a placeholder
                if (!Focused && string.IsNullOrEmpty(Text)) MostrarPlaceholder(); // validamos si el campo esta desenfocado y vacio para mostrar el texto temporal
            }
        }

        protected override void OnGotFocus(EventArgs e) // cuando este componente sea el enfoque principal de la interaccion del usuario
        {
            base.OnGotFocus(e); // ahora tenemos el enfoque principal - constructor
            if (_showing) { Text = ""; ForeColor = SystemColors.WindowText; _showing = false; } // Texto a mostrar = nada, color = igual al del texto del resto del formulario
        }

        protected override void OnLostFocus(EventArgs e) // En caso de que perdamos el enfoque principal de las acciones del usuario
        {
            base.OnLostFocus(e); // constructor
            if (string.IsNullOrEmpty(Text)) MostrarPlaceholder(); // Si el campo de texto esta vacio: mostramos el texto temporal
        }

        private void MostrarPlaceholder() { Text = _placeholder; ForeColor = Color.Gray; _showing = true; } // Definimos el metodo que muestra el texto temporal y damos formato
        public string TextoReal => _showing ? "" : Text; // validacion del contenido de _showing
    }
}
