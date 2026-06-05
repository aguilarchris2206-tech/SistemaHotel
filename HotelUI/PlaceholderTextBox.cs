using System.ComponentModel;

namespace Hotel.UI
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholder = "";  //valor temporal a mostrar
        private bool _showing = false;  // define si el texto de placeholder se muestra o no
        // El atributo DesignerSerializationVisibility evita que el valor del placeholder se serialice en el diseñador,
        // lo que es útil para evitar problemas al cargar el control en tiempo de diseño.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
        public string Placeholder
        {
            get => _placeholder; // llamamos al _placeholder
            set
            {
                _placeholder = value; //asignamos un valor a placeholder
                //Validamos si el campo de texto esta desenfocado y vacio para mostrar el texto temporal
                if (!Focused && string.IsNullOrEmpty(Text)) MostrarPlaceholder();
            }
        }

        protected override void OnGotFocus(EventArgs e) //cuando este componente sea el enfoque principal de la interaccion del usuario
        {
            base.OnGotFocus(e); //ahora tenemos el enfoque principal
            // Texto a mostrar = nada, color = igual al del texto del resto del formulario 
            //_Showing=false; no se muestra el texto.
            if (_showing) { Text = ""; ForeColor = SystemColors.WindowText; _showing = false; } 
        }

        protected override void OnLostFocus(EventArgs e) //en caso de que perdamos el enfoque principal
        {
            base.OnLostFocus(e); //constructor
            // Si el campo de texto esta vacio: mostramos el texto temporal.
            if (string.IsNullOrEmpty(Text)) MostrarPlaceholder(); 
        }

        // Definimos el metodo que muestra el texto temporal y damos formato.
        private void MostrarPlaceholder() { Text = _placeholder; ForeColor = Color.Gray; _showing = true; }

        public string TextoReal => _showing ? "" : Text; //validacion del contenudo de _showing
    }
}
