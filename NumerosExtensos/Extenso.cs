using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using System;

namespace NumerosExtensos
{
    public class Extenso
    {
        private readonly ExtensoOptions _extenso;
        public Extenso(ExtensoOptions extenso)
        {
            _extenso = extenso;
        }

        public string EscreverNumero(string numero)
        {
            return _extenso.Tipo switch
            {
                TipoNumerais.Cardinais => Tipos.Cardinal.Escrever.Numero(numero, _extenso.NumeraisOptions),
                TipoNumerais.Ordinais => Tipos.Ordinal.Escrever.Numero(numero, _extenso.NumeraisOptions),
                TipoNumerais.Multiplicativos => throw new NotSupportedException(),
                TipoNumerais.Fracionarios => throw new NotSupportedException(),
                TipoNumerais.Coletivos => throw new NotSupportedException(),
                TipoNumerais.Romanos => Tipos.Romano.Escrever.Numero(numero),
                _ => throw new NotSupportedException()
            };
        }
    }
}
