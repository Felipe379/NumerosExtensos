namespace NumerosExtensos.Options.Numerais
{
    /// <summary>
    /// Define as opções para o tipo de numeral ordinal.
    /// </summary>
    public class OrdinaisOptions : NumeraisOptions
    {
        /// <summary>
        /// Define o que deve ser escrito após o valor.
        /// Exemplo: 15 -> Décimo quinto COLOCADO.
        /// </summary>
        public string Singular { get; set; }
    }
}
