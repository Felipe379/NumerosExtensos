using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Cardinal
{
    public class Escrever
    {
        public static string Numero(string numero, ExtensoOptions extenso)
        {
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

            var antesDaVirgula = EscreveValor(numeroAntesDaVirgula, extenso.ZeroExplicitoAntesDaVirgula, extenso.DeveUsarPrefixoDe, extenso.DeveUsarExtensoFeminino);
            var depoisDaVirgula = EscreveValor(numeroDepoisDaVirgula, extenso.ZeroExplicitoDepoisDaVirgula, extenso.DeveUsarPrefixoDe, extenso.DeveUsarExtensoFeminino);

            var antesDaVirgulaSingular = Helpers.NumeroSingular(numeroAntesDaVirgula);
            var depoisDaVirgulaSingular = Helpers.NumeroSingular(numeroDepoisDaVirgula);

            numeroEscrito += $" {antesDaVirgula} " + (antesDaVirgulaSingular ? $" {extenso.AntesDaVirgulaSingular} " : $" {extenso.AntesDaVirgulaPlural} ");

            if (!string.IsNullOrWhiteSpace(virgula))
                numeroEscrito += $" {extenso.Conector} {depoisDaVirgula} " + (depoisDaVirgulaSingular ? $" {extenso.DepoisDaVirgulaSingular} " : $" {extenso.DepoisDaVirgulaPlural} ");
            else if (string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaSingular) || string.IsNullOrWhiteSpace(extenso.AntesDaVirgulaPlural))
                numeroEscrito += depoisDaVirgulaSingular ? $" {extenso.DepoisDaVirgulaSingular} " : $" {extenso.DepoisDaVirgulaPlural} ";

            return Helpers.RemoveEspacosEmBranco(numeroEscrito);
        }

        private static string EscreveValor(string numero, bool zeroExplicito, bool deveUsarPrefixoDe, bool extensoFeminino)
        {
            var numeroEscrito = string.Empty;

            if (zeroExplicito)
            {
                var index = 0;

                for (; index < numero.Length && numero[index] == '0'; index++)
                    numeroEscrito += EscrevePorExtenso(0, false);

                numero = numero.Substring(index);
            }

            while (numero.Count() % 3 != 0)
                numero = numero.Insert(0, "0");

            var arrayDeNumeros = Regex.Replace(numero, ".{3}", "$0,")
                                      .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                                      .Reverse()
                                      .ToArray();

            var quantidadeDeCasas = arrayDeNumeros.Count();

            for (int i = quantidadeDeCasas - 1; i >= 0; i--)
            {
                var valor = int.Parse(arrayDeNumeros[i]);
                if (valor != 0 || (quantidadeDeCasas == 1 && !zeroExplicito))
                {
                    numeroEscrito += (extensoFeminino && i < 2) ? EscrevePorExtenso(valor, true) : EscrevePorExtenso(valor, false);
                    numeroEscrito += i < 2 ? $" {Nomenclatura.Classes[i]} " : valor == 1 ? $" {Nomenclatura.Classes[i]}ão " : $" {Nomenclatura.Classes[i]}ões ";
                    numeroEscrito += " E ";
                }
            }

            if (numeroEscrito.EndsWith("E "))
                numeroEscrito = numeroEscrito.Substring(0, numeroEscrito.Length - 2).Trim();

            if (deveUsarPrefixoDe && (numeroEscrito.EndsWith("ão") || numeroEscrito.EndsWith("ões")))
                numeroEscrito += " De ";

            return numeroEscrito;
        }

        private static string EscrevePorExtenso(int? valor, bool extensoFeminino)
        {
            var unidadePorExtenso = string.Empty;
            var ordemNumerica = Helpers.ObterOrdemNumerica(valor);
            var valorUnidade = ordemNumerica[0];
            var valorDezena = ordemNumerica[1];
            var valorCentena = ordemNumerica[2];
            var valorPorExtenso = extensoFeminino ? Nomenclatura.NumerosFeminino : Nomenclatura.NumerosMasculino;

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
