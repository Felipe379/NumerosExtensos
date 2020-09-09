using NumerosExtensos.Enums;

namespace NumerosExtensos.Options
{
    public class ExtensoOptions
    {
        public TipoNumerais Tipo { get; set; }
        public CardinaisOptions CardinaisOptions { get; set; } = new CardinaisOptions();
        public OrdinaisOptions OrdinaisOptions { get; set; } = new OrdinaisOptions();
    }
}
