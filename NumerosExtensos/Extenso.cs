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
            switch (extenso.Tipo)
            {
                case TipoNumerais.Cardinais:
                    return new Tipos.Cardinal.Escrever(extenso.NumeraisOptions);
                case TipoNumerais.Ordinais:
                    return new Tipos.Ordinal.Escrever(extenso.NumeraisOptions);
                case TipoNumerais.Multiplicativos:
                    throw new NotSupportedException();
                case TipoNumerais.Fracionarios:
                    throw new NotSupportedException();
                case TipoNumerais.Coletivos:
                    throw new NotSupportedException();
                case TipoNumerais.Romanos:
                    return new Tipos.Romano.Escrever();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
