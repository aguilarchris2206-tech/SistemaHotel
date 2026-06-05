using System.ComponentModel;

namespace Hotel.UI
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholder = "";  
        private bool _showing = false;     

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Placeholder
        {
            get => _placeholder;
            set
            {
                _placeholder = value;
                if (!Focused && string.IsNullOrEmpty(Text)) MostrarPlaceholder();
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (_showing) { Text = ""; ForeColor = SystemColors.WindowText; _showing = false; }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (string.IsNullOrEmpty(Text)) MostrarPlaceholder();
        }

        private void MostrarPlaceholder() { Text = _placeholder; ForeColor = Color.Gray; _showing = true; }

        public string TextoReal => _showing ? "" : Text;
    }
}
