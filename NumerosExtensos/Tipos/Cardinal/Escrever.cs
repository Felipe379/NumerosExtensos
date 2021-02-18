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
                        @"(?<numeroAntesDaVirgula>[\d]{0,66})" +          // Pode ou nao ter numeros antes da virgula
                        @"(?<temVirgula>(,|\.)?)" +                       // Pode ou nao ter virgula
                        @"(?<numeroDepoisDaVirgula>[\d]{0,66})" +         // Pode ou nao ter numeros depois da virgula
                        @"$";                                             // Fim

            if (!Regex.IsMatch(numero, regex))
                throw new FormatException();

            var token = new Regex(regex).Match(numero);
            var sinal = token.Groups["sinal"].ToString();
            var virgula = token.Groups["temVirgula"].ToString();
            var numeroAntesDaVirgula = token.Groups["numeroAntesDaVirgula"].ToString();
            var numeroDepoisDaVirgula = token.Groups["numeroDepoisDaVirgula"].ToString();

            if (string.IsNullOrWhiteSpace(virgula) && !string.IsNullOrWhiteSpace(numeroDepoisDaVirgula))
                throw new FormatException();

            var numeroEscrito = string.IsNullOrWhiteSpace(sinal) ? string.Empty : sinal == "-" ? " Menos " : " Mais ";

            var antesDaVirgulaSingular = Helpers.NumeroSingular(numeroAntesDaVirgula);
            var depoisDaVirgulaSingular = Helpers.NumeroSingular(numeroDepoisDaVirgula);

            if (!string.IsNullOrWhiteSpace(numeroAntesDaVirgula))
            {
                var antesDaVirgula = EscreveValor(numeroAntesDaVirgula, extenso.ZeroExplicitoAntesDaVirgula, extenso.DeveUsarConjuncaoDe, extenso.DeveUsarExtensoFeminino);

                if (!string.IsNullOrWhiteSpace(virgula) && antesDaVirgula.EndsWith(" De ") && string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaSingular) && string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaPlural))
                    antesDaVirgula = antesDaVirgula.Remove(antesDaVirgula.Length - 4);

                numeroEscrito += $" {antesDaVirgula} " + (antesDaVirgulaSingular ? $" {extenso.AntesDaVirgulaSingular} " : $" {extenso.AntesDaVirgulaPlural} ");
            }

            if (!string.IsNullOrWhiteSpace(virgula))
                numeroEscrito += $" {extenso.Conector} ";

            if (!string.IsNullOrWhiteSpace(numeroDepoisDaVirgula))
            {
                var depoisDaVirgula = EscreveValor(numeroDepoisDaVirgula, extenso.ZeroExplicitoDepoisDaVirgula, extenso.DeveUsarConjuncaoDe, extenso.DeveUsarExtensoFeminino);
                if (string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaSingular) && string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaPlural))
                    numeroEscrito += $" {depoisDaVirgula} " + (antesDaVirgulaSingular ? $" {extenso.DepoisDaVirgulaSingular} " : $" {extenso.DepoisDaVirgulaPlural} ");
                else
                    numeroEscrito += $" {depoisDaVirgula} " + (depoisDaVirgulaSingular ? $" {extenso.DepoisDaVirgulaSingular} " : $" {extenso.DepoisDaVirgulaPlural} ");
            }
            else if (string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaSingular) && string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaPlural))
            {
                numeroEscrito += antesDaVirgulaSingular ? $" {extenso.DepoisDaVirgulaSingular} " : $" {extenso.DepoisDaVirgulaPlural} ";
            }

            return Helpers.RemoveEspacosEmBranco(numeroEscrito);
        }

        private static string EscreveValor(string numero, bool zeroExplicito, bool deveUsarConjuncaoDe, bool extensoFeminino)
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

                    numeroEscrito += (extensoFeminino && i < 2) ? EscrevePorExtenso(valor, Nomenclatura.NumerosFeminino) : EscrevePorExtenso(valor, Nomenclatura.NumerosMasculino);
                    numeroEscrito += i < 2 ? $" {Nomenclatura.Classes[i]} " : valor == 1 ? $" {Nomenclatura.Classes[i]}ão " : $" {Nomenclatura.Classes[i]}ões ";
                }
            }

            if (numeroEscrito.StartsWith("E "))
                numeroEscrito = numeroEscrito.Remove(0, 2).Trim();
            else
                numeroEscrito = numeroEscrito.Trim();

            if (deveUsarConjuncaoDe && (numeroEscrito.EndsWith("ão") || numeroEscrito.EndsWith("ões")))
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
                    return valorCentena == 100 ? $" {valorPorExtenso[valorCentena * -1]} " : $" {valorPorExtenso[valorCentena]} ";
                else
                    unidadePorExtenso += $" {valorPorExtenso[valorCentena]} E ";
            }

            if (valorDezena > 0)
            {
                if (valorDezena == valorDezena + valorUnidade)
                    return unidadePorExtenso += $" {valorPorExtenso[valorDezena]} ";
                else if (valorDezena == 10)
                    return unidadePorExtenso += $" {valorPorExtenso[valorDezena + valorUnidade]} ";
                else if (valorDezena != 0)
                    unidadePorExtenso += $" {valorPorExtenso[valorDezena]} E ";
            }

            unidadePorExtenso += $" {valorPorExtenso[valorUnidade]} ";

            return unidadePorExtenso;
        }
    }
}
