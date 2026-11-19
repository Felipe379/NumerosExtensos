using NumerosExtensos.Options.Numerais;
using NumerosExtensos.Utils;
using System;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Cardinal
{
    /// <summary>
    /// Escrita dos números cardinais por extenso.
    /// </summary>
    public class Escrever : Escrita
    {
        private static readonly Regex _pattern = new Regex(@"
            ^                                        # Início
            (?<sinal>(\+|-)?)                        # Pode ou não ter sinal
            (?<numeroParteInteira>[\d]{0,66})        # Pode ou não ter números antes da vírgula
            (?<temVirgula>(,|\.)?)                   # Pode ou não ter vírgula
            (?<numeroParteDecimal>[\d]{0,66})        # Pode ou não ter números depois da vírgula
            $                                        # Fim
        ", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);

        /// <summary>
        /// Opções utilizadas na escrita dos números cardinais.
        /// </summary>
        public CardinaisOptions CardinaisOptions { get; set; }

        /// <summary>
        /// Instancia a escrita dos números cardinais.
        /// </summary>
        /// <param name="extensoOptions">Opções do tipo <see cref="Options.Numerais.CardinaisOptions"/>.</param>
        /// <exception cref="InvalidOperationException">Quando as opções não forem do tipo <see cref="Options.Numerais.CardinaisOptions"/>.</exception>
        public Escrever(NumeraisOptions extensoOptions)
        {
            if (!(extensoOptions is CardinaisOptions cardinaisOpts))
                throw new InvalidOperationException($"Para o tipo de numeral Cardinais, a propriedade 'NumeraisOptions' deve ser do tipo '{nameof(CardinaisOptions)}'");

            CardinaisOptions = cardinaisOpts;
        }

        /// <inheritdoc/>
        public override string Numero(string numero)
        {
            var regex = _pattern.Match(numero);

            if (!regex.Success)
                throw new FormatException();

            var sinal = regex.Groups["sinal"].ToString();
            var virgula = regex.Groups["temVirgula"].ToString();
            var numeroParteInteira = regex.Groups["numeroParteInteira"].ToString();
            var numeroParteDecimal = regex.Groups["numeroParteDecimal"].ToString();

            if (string.IsNullOrWhiteSpace(virgula) && !string.IsNullOrWhiteSpace(numeroParteDecimal))
                throw new FormatException();

            if (string.IsNullOrWhiteSpace(numeroParteInteira) && string.IsNullOrWhiteSpace(numeroParteDecimal))
                throw new FormatException();

            var numeroEscrito = string.IsNullOrWhiteSpace(sinal) ? string.Empty : sinal == "-" ? " Menos " : " Mais ";

            var parteInteiraSingular = Helpers.NumeroSingular(numeroParteInteira);
            var parteDecimalSingular = Helpers.NumeroSingular(numeroParteDecimal);
            var valorEscrito = string.Empty;

            if (!string.IsNullOrWhiteSpace(numeroParteInteira))
            {
                valorEscrito = EscreveValor(numeroParteInteira, CardinaisOptions.ZeroExplicitoParteInteira);

                if (!string.IsNullOrWhiteSpace(virgula) && valorEscrito.EndsWith(" De ") && string.IsNullOrWhiteSpace(CardinaisOptions.ParteInteiraSingular) && string.IsNullOrWhiteSpace(CardinaisOptions.ParteInteiraPlural))
                    valorEscrito = valorEscrito.Remove(valorEscrito.Length - 4);

                numeroEscrito += $" {valorEscrito} " + (parteInteiraSingular ? $" {CardinaisOptions.ParteInteiraSingular} " : $" {CardinaisOptions.ParteInteiraPlural} ");
            }

            if (!string.IsNullOrWhiteSpace(virgula))
            {
                if (string.IsNullOrWhiteSpace(valorEscrito))
                {
                    if (CardinaisOptions.ConjuncaoExplicitaSeParteInteiraVazia)
                        numeroEscrito += $" {CardinaisOptions.Conjuncao} ";
                }
                else
                {
                    numeroEscrito += $" {CardinaisOptions.Conjuncao} ";
                }
            }

            if (!string.IsNullOrWhiteSpace(numeroParteDecimal))
            {
                valorEscrito = EscreveValor(numeroParteDecimal, CardinaisOptions.ZeroExplicitoParteDecimal);
                if (string.IsNullOrWhiteSpace(CardinaisOptions.ParteInteiraSingular) && string.IsNullOrWhiteSpace(CardinaisOptions.ParteInteiraPlural))
                    numeroEscrito += $" {valorEscrito} " + (parteInteiraSingular ? $" {CardinaisOptions.ParteDecimalSingular} " : $" {CardinaisOptions.ParteDecimalPlural} ");
                else
                    numeroEscrito += $" {valorEscrito} " + (parteDecimalSingular ? $" {CardinaisOptions.ParteDecimalSingular} " : $" {CardinaisOptions.ParteDecimalPlural} ");
            }
            else if (string.IsNullOrWhiteSpace(CardinaisOptions.ParteInteiraSingular) && string.IsNullOrWhiteSpace(CardinaisOptions.ParteInteiraPlural))
            {
                numeroEscrito += parteInteiraSingular ? $" {CardinaisOptions.ParteDecimalSingular} " : $" {CardinaisOptions.ParteDecimalPlural} ";
            }

            return Helpers.RemoveEspacosEmBranco(numeroEscrito);
        }

        private string EscreveValor(string numero, bool zeroExplicito)
        {
            var numeroEscrito = string.Empty;

            if (zeroExplicito)
            {
                var index = 0;

                for (; index < numero.Length && numero[index] == '0'; index++)
                    numeroEscrito += EscrevePorExtenso(0);

                numero = numero.Substring(index);
            }
            else if (Helpers.NumeroApenasZeros(numero))
            {
                numeroEscrito += EscrevePorExtenso(0);
                return numeroEscrito;
            }
            else
            {
                numero = Helpers.RemoveZerosAEsquerda(numero);
            }

            var arrayDeNumeros = Helpers.ObtemArrayNumerico(numero);

            var quantidadeDeCasas = arrayDeNumeros.Length;

            for (int i = quantidadeDeCasas - 1; i >= 0; i--)
            {
                var valor = int.Parse(arrayDeNumeros[i]);
                if (valor != 0)
                {
                    if ((Helpers.NumeroComecaComZero(arrayDeNumeros[i]) || Helpers.NumeroTerminaEmCentenaCheia(arrayDeNumeros[i])) && i == 0 && quantidadeDeCasas > 1)
                        numeroEscrito += " E ";
                    else if (CardinaisOptions.SepararClassesPorVirgula && quantidadeDeCasas != i + 1)
                        numeroEscrito += ", ";

                    // Milhão, bilhão etc. são substantivos masculinos, então a partir da classe 2 o número é sempre masculino.
                    numeroEscrito += (valor == 1 && i == 1 && !CardinaisOptions.UmMilExplicito) ? string.Empty : EscrevePorExtenso(valor, forcarMasculino: i >= 2);
                    numeroEscrito += i < 2 ? $" {Nomenclatura.Classes[i]}" : valor == 1 ? $" {Nomenclatura.Classes[i]}ão" : $" {Nomenclatura.Classes[i]}ões";
                }
            }

            numeroEscrito = numeroEscrito.Trim();

            if (CardinaisOptions.DeveUsarConjuncaoDe && (numeroEscrito.EndsWith("ão") || numeroEscrito.EndsWith("ões") || numeroEscrito.EndsWith("ão,") || numeroEscrito.EndsWith("ões,")))
                numeroEscrito += " De ";

            return numeroEscrito;
        }

        private string EscrevePorExtenso(int valor, bool forcarMasculino = false)
        {
            var numeros = Nomenclatura.ObterNumeros(CardinaisOptions.DeveUsarExtensoFeminino && !forcarMasculino);
            var unidadePorExtenso = string.Empty;
            var ordensNumericas = Helpers.ObterOrdemNumerica(valor);
            var valorUnidade = ordensNumericas[0];
            var valorDezena = ordensNumericas[1];
            var valorCentena = ordensNumericas[2];

            if (valorCentena > 0)
            {
                if (valorCentena == valor)
                    return valorCentena == 100 ? $" {numeros[valorCentena * -1]}" : $" {numeros[valorCentena]}";
                else
                    unidadePorExtenso += $" {numeros[valorCentena]} E ";
            }

            if (valorDezena > 0)
            {
                if (valorDezena == valorDezena + valorUnidade)
                    return unidadePorExtenso += $" {numeros[valorDezena]}";
                else if (valorDezena == 10)
                    return unidadePorExtenso += $" {numeros[valorDezena + valorUnidade]}";
                else if (valorDezena != 0)
                    unidadePorExtenso += $" {numeros[valorDezena]} E ";
            }

            unidadePorExtenso += $" {numeros[valorUnidade]}";

            return unidadePorExtenso;
        }
    }
}
