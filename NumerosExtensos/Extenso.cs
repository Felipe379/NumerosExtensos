using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Tipos;
using System;

namespace NumerosExtensos
{
    /// <summary>
    /// Classe para definir qual tipo de escrita deverá ser utilizado.
    /// </summary>
    public class Extenso
    {
        /// <summary>
        /// Método para instanciar uma classe do tipo de numeral definido.
        /// </summary>
        /// <param name="extenso">Opções prédefinidas que devem ser passadas para retornar o tipo de numeral que deverá ser escrito.</param>
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
