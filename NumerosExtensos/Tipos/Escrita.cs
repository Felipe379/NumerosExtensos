using System;
using System.Globalization;
using System.Linq;

namespace NumerosExtensos.Tipos
{
    /// <summary>
    /// Classe abstrata para os tipos de escrita.
    /// </summary>
    public abstract class Escrita
    {
        /// <summary>
        /// Método que retorna o número escrito por extenso.
        /// </summary>
        /// <param name="value">Valor do número em string já formatado.</param>
        public abstract string Numero(string value);

        /// <summary>
        /// Método que retorna o número escrito por extenso.
        /// </summary>
        /// <param name="value">Valor do número. Tipos válidos incluem: byte, sbyte, short, ushort, int, uint, long, ulong, decimal, double, float.</param>
        /// <param name="precisaoDecimal">Precisão de números decimais, aceitando valores entre 0 e 99 e podendo ser nula caso não tenha uma precisão definida.</param>
        /// <param name="zerosEsquerda">Quantidade mínima de zeros à esquerda, aceitando valores entre 0 e 99.</param>
        public string Numero(object value, ushort? precisaoDecimal = null, ushort zerosEsquerda = 1)
        {
            if (precisaoDecimal >= 100)
                throw new ArgumentOutOfRangeException(nameof(precisaoDecimal), "O parâmetro 'precisaoDecimal' não pode ser maior ou igual a 100");

            if (zerosEsquerda >= 100)
                throw new ArgumentOutOfRangeException(nameof(zerosEsquerda), "O parâmetro 'zerosEsquerda' não pode ser maior ou igual a 100");

            var numero = string.Empty;

            if (value == null)
                return numero;

            var typeCode = Type.GetTypeCode(value.GetType());
            var precisaoFormatacao = precisaoDecimal.HasValue ? $"F{precisaoDecimal}" : string.Empty;
            switch (typeCode)
            {
                case TypeCode.Byte:
                    numero = ((byte)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.SByte:
                    numero = ((sbyte)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Int16:
                    numero = ((short)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.UInt16:
                    numero = ((ushort)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Int32:
                    numero = ((int)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.UInt32:
                    numero = ((uint)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Int64:
                    numero = ((long)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.UInt64:
                    numero = ((ulong)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Decimal:
                    numero = ((decimal)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Double:
                    numero = ((double)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Single:
                    numero = ((float)value).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                default:
                    throw new InvalidCastException("Tipo de objeto 'value' inválido");
            }

            var numeros = numero.Split(new[] { ',', '.' });
            var sinal = string.Empty;

            if (numeros[0].StartsWith("-"))
            {
                sinal = numeros[0].Substring(0, 1);
                numeros[0] = numeros[0].Substring(1);
            }


            if (zerosEsquerda == 0 && numeros.First() == "0")
            {
                numeros[0] = string.Empty;
            }
            else
            {
                numeros[0] = numeros[0].PadLeft(zerosEsquerda, '0');
            }

            var numeroFormatado = sinal + string.Join(",", numeros);

            var numeroEscrito = Numero(numeroFormatado);

            return numeroEscrito;
        }
    }
}
