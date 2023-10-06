using NumerosExtensos.Options.Numerais;
using NumerosExtensos.Utils;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Cardinal
{
    public class Escrever : Escrita
    {
        public CardinaisOptions CardinaisOptions { get; set; }
        private Nomenclatura Nomenclatura { get; set; }

        public Escrever(NumeraisOptions extensoOptions)
        {
            if (!(extensoOptions is CardinaisOptions))
                throw new InvalidOperationException();

            CardinaisOptions = extensoOptions as CardinaisOptions;
            Nomenclatura = new Nomenclatura(CardinaisOptions.DeveUsarExtensoFeminino);
        }

        public override string Numero(string numero)
        {
            var pattern = @"^" +                                         // Inicio
                          @"(?<sinal>(\+|-)?)" +                         // Pode ou nao ter sinal
                          @"(?<numeroParteInteira>[\d]{0,66})" +         // Pode ou nao ter numeros antes da virgula
                          @"(?<temVirgula>(,|\.)?)" +                    // Pode ou nao ter virgula
                          @"(?<numeroParteDecimal>[\d]{0,66})" +         // Pode ou nao ter numeros depois da virgula
                          @"$";                                          // Fim

            var regex = new Regex(pattern).Match(numero);

            if (!regex.Success)
                throw new FormatException();

            var sinal = regex.Groups["sinal"].ToString();
            var virgula = regex.Groups["temVirgula"].ToString();
            var numeroParteInteira = regex.Groups["numeroParteInteira"].ToString();
            var numeroParteDecimal = regex.Groups["numeroParteDecimal"].ToString();

            if (string.IsNullOrWhiteSpace(virgula) && !string.IsNullOrWhiteSpace(numeroParteDecimal))
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

            var quantidadeDeCasas = arrayDeNumeros.Count();

            for (int i = quantidadeDeCasas - 1; i >= 0; i--)
            {
                var valor = int.Parse(arrayDeNumeros[i]);
                if (valor != 0)
                {
                    if ((Helpers.NumeroComecaComZero(arrayDeNumeros[i]) || Helpers.NumeroTerminaEmCentenaCheia(arrayDeNumeros[i])) && i == 0 && quantidadeDeCasas > 1)
                        numeroEscrito += " E ";
                    else if (CardinaisOptions.SepararClassesPorVirgula && quantidadeDeCasas != i + 1)
                        numeroEscrito += ", ";

                    numeroEscrito += (valor == 1 && i == 1 && !CardinaisOptions.UmMilExplicito) ? string.Empty : EscrevePorExtenso(valor);
                    numeroEscrito += i < 2 ? $" {Nomenclatura.Classes[i]}" : valor == 1 ? $" {Nomenclatura.Classes[i]}ão" : $" {Nomenclatura.Classes[i]}ões";
                }
            }

            numeroEscrito = numeroEscrito.Trim();

            if (CardinaisOptions.DeveUsarConjuncaoDe && (numeroEscrito.EndsWith("ão") || numeroEscrito.EndsWith("ões") || numeroEscrito.EndsWith("ão,") || numeroEscrito.EndsWith("ões,")))
                numeroEscrito += " De ";

            return numeroEscrito;
        }

        private string EscrevePorExtenso(int valor)
        {
            var unidadePorExtenso = string.Empty;
            var ordensNumericas = Helpers.ObterOrdemNumerica(valor);
            var valorUnidade = ordensNumericas[0];
            var valorDezena = ordensNumericas[1];
            var valorCentena = ordensNumericas[2];

            if (valorCentena > 0)
            {
                if (valorCentena == valor)
                    return valorCentena == 100 ? $" {Nomenclatura.Numeros[valorCentena * -1]}" : $" {Nomenclatura.Numeros[valorCentena]}";
                else
                    unidadePorExtenso += $" {Nomenclatura.Numeros[valorCentena]} E ";
            }

            if (valorDezena > 0)
            {
                if (valorDezena == valorDezena + valorUnidade)
                    return unidadePorExtenso += $" {Nomenclatura.Numeros[valorDezena]}";
                else if (valorDezena == 10)
                    return unidadePorExtenso += $" {Nomenclatura.Numeros[valorDezena + valorUnidade]}";
                else if (valorDezena != 0)
                    unidadePorExtenso += $" {Nomenclatura.Numeros[valorDezena]} E ";
            }

            unidadePorExtenso += $" {Nomenclatura.Numeros[valorUnidade]}";

            return unidadePorExtenso;
        }
    }
}
