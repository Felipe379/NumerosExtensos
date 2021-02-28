using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Tipos;
using System;

namespace NumerosExtensos
{
    public class Extenso
    {
        public Escrita Escrever(ExtensoOptions extenso)
        {
            return extenso.Tipo switch
            {
                TipoNumerais.Cardinais => new Tipos.Cardinal.Escrever(extenso.NumeraisOptions),
                TipoNumerais.Ordinais => new Tipos.Ordinal.Escrever(extenso.NumeraisOptions),
                TipoNumerais.Multiplicativos => throw new NotSupportedException(),
                TipoNumerais.Fracionarios => throw new NotSupportedException(),
                TipoNumerais.Coletivos => throw new NotSupportedException(),
                TipoNumerais.Romanos => new Tipos.Romano.Escrever(),
                _ => throw new NotSupportedException()
            };
        }
    }
}
