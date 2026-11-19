using NumerosExtensos.Utils;
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
        internal const int QuantidadeMaximaDigitos = 66;

        /// <summary>
        /// Método que retorna o número escrito por extenso.
        /// </summary>
        /// <param name="value">Valor do número em string já formatado.</param>
        public abstract string Numero(string value);

        /// <summary>
        /// Método que retorna o número escrito por extenso.
        /// </summary>
        /// <param name="value">Valor do número. Tipos válidos incluem: byte, sbyte, short, ushort, int, uint, long, ulong, decimal, double, float.</param>
        /// <param name="precisaoDecimal">Precisão de números decimais, aceitando valores entre 0 e 66 e podendo ser nula caso não tenha uma precisão definida.</param>
        /// <param name="zerosEsquerda">Tamanho mínimo da parte inteira, completada com zeros à esquerda, aceitando valores entre 0 e 66. Com 0, o zero da parte inteira é omitido quando há parte decimal (ex.: 0.5 -> ,5).</param>
        public string Numero(object value, ushort? precisaoDecimal = null, ushort zerosEsquerda = 1)
        {
            if (precisaoDecimal > QuantidadeMaximaDigitos)
                throw new ArgumentOutOfRangeException(nameof(precisaoDecimal), $"O parâmetro 'precisaoDecimal' não pode ser maior que {QuantidadeMaximaDigitos}");

            if (zerosEsquerda > QuantidadeMaximaDigitos)
                throw new ArgumentOutOfRangeException(nameof(zerosEsquerda), $"O parâmetro 'zerosEsquerda' não pode ser maior que {QuantidadeMaximaDigitos}");

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            string numero;

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
                    // Convertido para decimal pois o ToString de double e float pode gerar notação científica (ex.: 1E+20).
                    // O formato "R" preserva todos os dígitos significativos, ao contrário do Convert.ToDecimal.
                    numero = ConverteParaDecimal(((double)value).ToString("R", CultureInfo.InvariantCulture)).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                case TypeCode.Single:
                    numero = ConverteParaDecimal(((float)value).ToString("R", CultureInfo.InvariantCulture)).ToString(precisaoFormatacao, CultureInfo.InvariantCulture);
                    break;
                default:
                    throw new InvalidCastException("Tipo de objeto 'value' inválido");
            }

            var numeros = numero.Split(new[] { ',', '.' });
            var sinal = string.Empty;

            if (numeros[0].StartsWith("-"))
            {
                numeros[0] = numeros[0].Substring(1);

                // Evita "Menos Zero" quando um valor negativo é arredondado para zero (ex.: -0.001 com precisão 2).
                var valorEhZero = numeros.All(Helpers.NumeroApenasZeros);

                if (!valorEhZero)
                    sinal = "-";
            }

            var temParteDecimal = numeros.Length > 1;

            if (zerosEsquerda == 0 && temParteDecimal && numeros[0] == "0")
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

        private static decimal ConverteParaDecimal(string valor)
        {
            try
            {
                return decimal.Parse(valor, NumberStyles.Float, CultureInfo.InvariantCulture);
            }
            catch (Exception ex) when (ex is OverflowException || ex is FormatException)
            {
                throw new ArgumentOutOfRangeException("value", "O valor está fora do intervalo suportado para os tipos double e float (±7,9 × 10^28, sem NaN ou infinito)");
            }
        }
    }
}
