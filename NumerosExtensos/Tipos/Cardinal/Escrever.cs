using NumerosExtensos.Options.Numerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Cardinal
{
    internal static class Escrever
    {
        public static string Numero(string numero, NumeraisOptions extensoOptions)
        {
            if (!(extensoOptions is CardinaisOptions))
                throw new InvalidOperationException();

            var extenso = extensoOptions as CardinaisOptions;

            var regex = @"^" +                                            // Inicio
                        @"(?<sinal>(\+|-)?)" +                            // Pode ou nao ter sinal
                        @"(?<numeroParteInteira>[\d]{0,66})" +          // Pode ou nao ter numeros antes da virgula
                        @"(?<temVirgula>(,|\.)?)" +                       // Pode ou nao ter virgula
                        @"(?<numeroParteDecimal>[\d]{0,66})" +         // Pode ou nao ter numeros depois da virgula
                        @"$";                                             // Fim

            if (!Regex.IsMatch(numero, regex))
                throw new FormatException();

            var token = new Regex(regex).Match(numero);
            var sinal = token.Groups["sinal"].ToString();
            var virgula = token.Groups["temVirgula"].ToString();
            var numeroParteInteira = token.Groups["numeroParteInteira"].ToString();
            var numeroParteDecimal = token.Groups["numeroParteDecimal"].ToString();

            if (string.IsNullOrWhiteSpace(virgula) && !string.IsNullOrWhiteSpace(numeroParteDecimal))
                throw new FormatException();

            var numeroEscrito = string.IsNullOrWhiteSpace(sinal) ? string.Empty : sinal == "-" ? " Menos " : " Mais ";

            var parteInteiraSingular = Helpers.NumeroSingular(numeroParteInteira);
            var parteDecimalSingular = Helpers.NumeroSingular(numeroParteDecimal);
            var valorEscrito = string.Empty;

            if (!string.IsNullOrWhiteSpace(numeroParteInteira))
            {
                valorEscrito = EscreveValor(numeroParteInteira, extenso.ZeroExplicitoParteInteira, extenso.DeveUsarConjuncaoDe, extenso.DeveUsarExtensoFeminino, extenso.SepararClassesPorVirgula);

                if (!string.IsNullOrWhiteSpace(virgula) && valorEscrito.EndsWith(" De ") && string.IsNullOrWhiteSpace(extenso.ParteInteiraSingular) && string.IsNullOrWhiteSpace(extenso.ParteInteiraPlural))
                    valorEscrito = valorEscrito.Remove(valorEscrito.Length - 4);

                numeroEscrito += $" {valorEscrito} " + (parteInteiraSingular ? $" {extenso.ParteInteiraSingular} " : $" {extenso.ParteInteiraPlural} ");
            }

            if (!string.IsNullOrWhiteSpace(virgula))
            {
                if (string.IsNullOrWhiteSpace(valorEscrito))
                {
                    if (extenso.ConjuncaoExplicitaSeParteInteiraVazia)
                        numeroEscrito += $" {extenso.Conjuncao} ";
                }
                else
                {
                    numeroEscrito += $" {extenso.Conjuncao} ";
                }
            }

            if (!string.IsNullOrWhiteSpace(numeroParteDecimal))
            {
                valorEscrito = EscreveValor(numeroParteDecimal, extenso.ZeroExplicitoParteDecimal, extenso.DeveUsarConjuncaoDe, extenso.DeveUsarExtensoFeminino, extenso.SepararClassesPorVirgula);
                if (string.IsNullOrWhiteSpace(extenso.ParteInteiraSingular) && string.IsNullOrWhiteSpace(extenso.ParteInteiraPlural))
                    numeroEscrito += $" {valorEscrito} " + (parteInteiraSingular ? $" {extenso.ParteDecimalSingular} " : $" {extenso.ParteDecimalPlural} ");
                else
                    numeroEscrito += $" {valorEscrito} " + (parteDecimalSingular ? $" {extenso.ParteDecimalSingular} " : $" {extenso.ParteDecimalPlural} ");
            }
            else if (string.IsNullOrWhiteSpace(extenso.ParteInteiraSingular) && string.IsNullOrWhiteSpace(extenso.ParteInteiraPlural))
            {
                numeroEscrito += parteInteiraSingular ? $" {extenso.ParteDecimalSingular} " : $" {extenso.ParteDecimalPlural} ";
            }

            return Helpers.RemoveEspacosEmBranco(numeroEscrito);
        }

        private static string EscreveValor(string numero, bool zeroExplicito, bool deveUsarConjuncaoDe, bool extensoFeminino, bool separarClassesPorVirgula)
        {
            var numeroEscrito = string.Empty;

            if (zeroExplicito)
            {
                var index = 0;

                for (; index < numero.Length && numero[index] == '0'; index++)
                    numeroEscrito += EscrevePorExtenso(0, Nomenclatura.NumerosMasculino);

                numero = numero.Substring(index);
            }
            else if (Helpers.NumeroApenasZeros(numero))
            {
                numeroEscrito += EscrevePorExtenso(0, Nomenclatura.NumerosMasculino);
                return numeroEscrito;
            }
            else
            {
                numero = Helpers.RemoveZerosAEsquerda(numero);
            }

            while (numero.Count() % 3 != 0)
                numero = numero.Insert(0, "0");

            var arrayDeNumeros = Helpers.ObtemArrayNumerico(numero);

            var quantidadeDeCasas = arrayDeNumeros.Count();

            for (int i = quantidadeDeCasas - 1; i >= 0; i--)
            {
                var valor = int.Parse(arrayDeNumeros[i]);
                if (valor != 0)
                {
                    if ((Helpers.NumeroComecaComZero(arrayDeNumeros[i]) || Helpers.NumeroTerminaEmCentenaCheia(arrayDeNumeros[i])) && i == 0 && quantidadeDeCasas > 1)
                        numeroEscrito += " E ";
                    else if (separarClassesPorVirgula && quantidadeDeCasas != i + 1)
                        numeroEscrito += ", ";

                    numeroEscrito += (extensoFeminino && i < 2) ? EscrevePorExtenso(valor, Nomenclatura.NumerosFeminino) : EscrevePorExtenso(valor, Nomenclatura.NumerosMasculino);
                    numeroEscrito += i < 2 ? $" {Nomenclatura.Classes[i]}" : valor == 1 ? $" {Nomenclatura.Classes[i]}ão" : $" {Nomenclatura.Classes[i]}ões";
                }
            }

            numeroEscrito = numeroEscrito.Trim();

            if (deveUsarConjuncaoDe && (numeroEscrito.EndsWith("ão") || numeroEscrito.EndsWith("ões") || numeroEscrito.EndsWith("ão,") || numeroEscrito.EndsWith("ões,")))
                numeroEscrito += " De ";

            return numeroEscrito;
        }

        private static string EscrevePorExtenso(int valor, Dictionary<int, string> valorPorExtenso)
        {
            var unidadePorExtenso = string.Empty;
            var ordensNumericas = Helpers.ObterOrdemNumerica(valor);
            var valorUnidade = ordensNumericas[0];
            var valorDezena = ordensNumericas[1];
            var valorCentena = ordensNumericas[2];

            if (valorCentena > 0)
            {
                if (valorCentena == valor)
                    return valorCentena == 100 ? $" {valorPorExtenso[valorCentena * -1]}" : $" {valorPorExtenso[valorCentena]}";
                else
                    unidadePorExtenso += $" {valorPorExtenso[valorCentena]} E ";
            }

            if (valorDezena > 0)
            {
                if (valorDezena == valorDezena + valorUnidade)
                    return unidadePorExtenso += $" {valorPorExtenso[valorDezena]}";
                else if (valorDezena == 10)
                    return unidadePorExtenso += $" {valorPorExtenso[valorDezena + valorUnidade]}";
                else if (valorDezena != 0)
                    unidadePorExtenso += $" {valorPorExtenso[valorDezena]} E ";
            }

            unidadePorExtenso += $" {valorPorExtenso[valorUnidade]}";

            return unidadePorExtenso;
        }
    }
}
