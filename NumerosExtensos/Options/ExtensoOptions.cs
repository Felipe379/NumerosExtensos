using NumerosExtensos.Enums;
using NumerosExtensos.Options.Numerais;

namespace NumerosExtensos.Options
{
    public class ExtensoOptions
    {
        public TipoNumerais Tipo { get; set; }
        public NumeraisOptions NumeraisOptions { get; set; } = new NumeraisOptions();
    }
}
