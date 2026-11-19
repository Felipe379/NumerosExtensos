using System.ComponentModel;

namespace NumerosExtensos.Enums
{
    // Fonte: https://pt.wikipedia.org/wiki/Numerais_em_l%C3%ADngua_portuguesa
    /// <summary>
    /// Tipos de numerais da língua portuguesa.
    /// </summary>
    public enum TipoNumerais
    {
        /// <summary>
        /// Números cardinais. Exemplo: 15 -> Quinze.
        /// </summary>
        [Description("Cardinal")]
        Cardinais,

        /// <summary>
        /// Números ordinais. Exemplo: 15 -> Décimo quinto.
        /// </summary>
        [Description("Ordinal")]
        Ordinais,

        /// <summary>
        /// Números multiplicativos. Ainda não suportado: lança <see cref="System.NotSupportedException"/>.
        /// </summary>
        [Description("Multiplicativo")]
        Multiplicativos,

        /// <summary>
        /// Números fracionários. Ainda não suportado: lança <see cref="System.NotSupportedException"/>.
        /// </summary>
        [Description("Fracionário")]
        Fracionarios,

        /// <summary>
        /// Números coletivos. Ainda não suportado: lança <see cref="System.NotSupportedException"/>.
        /// </summary>
        [Description("Coletivo")]
        Coletivos,

        /// <summary>
        /// Números romanos, entre 1 e 3999. Exemplo: 15 -> XV.
        /// </summary>
        [Description("Romano")]
        Romanos
    }
}
