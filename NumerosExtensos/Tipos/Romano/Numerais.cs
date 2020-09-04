using System.Collections.Generic;

namespace NumerosExtensos.Tipos.Romano
{
    internal class Numerais
    {
        internal static readonly Dictionary<int, char> Romanos = new Dictionary<int, char>()
        {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' }
        };
    }
}
