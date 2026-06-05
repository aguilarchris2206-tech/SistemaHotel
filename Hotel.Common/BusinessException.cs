using System.Collections.Specialized;

namespace Hotel.Common
{
    public class BusinessException : Exception
    {
        public StringDictionary CodigoError { get; }
        /// <param name="mensaje">Descripción del error para mostrar al usuario</param>
        /// <param name="codigoError">Código interno que identifica el tipo de error</param>
        public BusinessException(string mensaje, string codigoError) : base(mensaje)
        {
            CodigoError = new StringDictionary();
            CodigoError.Add("Codigo", codigoError);
        }
    }
}
