using System.ComponentModel;

namespace NumerosExtensos.Enums
{
    /// <summary>
    /// Opções predefinidas disponíveis em <see cref="OpcoesPredefinidas.Predefinicoes"/>.
    /// </summary>
    public enum Predefinicoes
    {
        /// <summary>
        /// Cardinais sem nenhuma opção configurada.
        /// </summary>
        [Description("Nenhum")]
        Nenhum,

        /// <summary>
        /// Números cardinais com as classes separadas por vírgula. Exemplo: 1.5 -> Um vírgula cinco.
        /// </summary>
        [Description("Números Cardinais")]
        Cardinais,

        /// <summary>
        /// Números ordinais. Exemplo: 15 -> Décimo quinto.
        /// </summary>
        [Description("Números Ordinais")]
        Ordinais,

        /// <summary>
        /// Valores monetários em reais. Exemplo: 1.50 -> Um real e cinquenta centavos.
        /// </summary>
        [Description("Monetário BRL")]
        MonetarioBRL,

        /// <summary>
        /// Porcentagens. Exemplo: 1.5 -> Um vírgula cinco por cento.
        /// </summary>
        [Description("Porcentagem")]
        Porcentagem,

        /// <summary>
        /// Medidas em metros. Exemplo: 1.5 -> Um vírgula cinco metro.
        /// </summary>
        [Description("Metros")]
        Metros,

        /// <summary>
        /// Números romanos, entre 1 e 3999. Exemplo: 15 -> XV.
        /// </summary>
        [Description("Números Romanos")]
        Romanos
    };
}
