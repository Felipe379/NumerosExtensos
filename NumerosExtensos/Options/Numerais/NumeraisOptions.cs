namespace NumerosExtensos.Options.Numerais
{
    /// <summary>
    /// Opções que valem tanto para os números cardinais quantos os ordinais.
    /// </summary>
    public class NumeraisOptions
    {
        /// <summary>
        /// Define se o gênero deve ser flexionado no feminino.
        /// Exemplo Cardinal: 2000 -> DUAS mil.
        /// Exemplo Ordinal: 10 -> DÉCIMA.
        /// </summary
        public bool DeveUsarExtensoFeminino { get; set; }

        /// <summary>
        /// Define se as classes devem ser separadas por vírgulas.
        /// Exemplo Cardinal: 1537 -> Mil, quinhentos e trinta e sete
        /// Exemplo Ordinal: 210115 -> Ducentésimo décimo milésimo, centésimo décimo quinto.
        /// </summary
        public bool SepararClassesPorVirgula { get; set; }
    }
}
