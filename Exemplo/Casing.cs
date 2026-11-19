using System.ComponentModel;

namespace Exemplo
{
    internal enum Casing
    {
        [Description("Uppercase")]
        Uppercase,

        [Description("Lowercase")]
        Lowercase,

        [Description("Frase")]
        Frase,

        [Description("Pascalcase")]
        Pascalcase
    }
}
