using System.Collections.Specialized;

namespace Hotel.Common
{
    public class BusinessException : Exception
    {
        public StringDictionary CodigoError { get; }
        public BusinessException(string mensaje, string codigoError) : base(mensaje)
        {
            CodigoError = new StringDictionary();
            CodigoError.Add("Codigo", codigoError);
        }
    }
}
