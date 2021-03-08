using NumerosExtensos.Enums;
using NumerosExtensos.Options.Numerais;

namespace NumerosExtensos.Options
{
    /// <summary>
    /// Classe de configuração de opções.
    /// </summary>
    public class ExtensoOptions
    {
        /// <summary>
        /// Enum definindo o tipo de numeral.
        /// </summary>
        public TipoNumerais Tipo { get; set; }

        /// <summary>
        /// Classe para configurar as opções dependendo do tipo de numeral escolhido.
        /// </summary>
        public NumeraisOptions NumeraisOptions { get; set; } = new NumeraisOptions();
    }
}
