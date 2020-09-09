using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Ordinal
{
    internal class Escrever
    {
        public static string Numero(string numero, ExtensoOptions extenso)
        {
            var regex = @"^" +                                            // Inicio
                        @"(?<numeros>[\d]{0,66})" +                       // Pode ou nao ter numeros
                        @"$";                                             // Fim

            if (!Regex.IsMatch(numero, regex))
                throw new FormatException();

            var numeroEscrito = EscreveValor(numero, extenso.DeveUsarExtensoFeminino);

            if (!string.IsNullOrWhiteSpace(numeroEscrito))
                numeroEscrito += extenso.DepoisDaVirgulaSingular;

            return Helpers.RemoveEspacosEmBranco(numeroEscrito);
        }

        private static string EscreveValor(string numero, bool extensoFeminino)
        {
            var numeroEscrito = string.Empty;
            var genero = extensoFeminino ? "a" : "o";

            if (Helpers.NumeroApenasZeros(numero))
            {
                numeroEscrito += EscrevePorExtenso(0, genero);
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
                if (valor != 0 || quantidadeDeCasas == 1)
                {
                    numeroEscrito += valor != 1 || i == 0 ? EscrevePorExtenso(valor, genero) : string.Empty;
                    numeroEscrito += i != 0 ? $" {Nomenclatura.NomenclaturaClasses[i] + genero} " : string.Empty;
                }
            }

            return numeroEscrito;
        }

        private static string EscrevePorExtenso(int valor, string genero)
        {
            var unidadePorExtenso = string.Empty;
            var ordensNumericas = Helpers.ObterOrdemNumerica(valor);
            var valorUnidade = ordensNumericas[0];
            var valorDezena = ordensNumericas[1];
            var valorCentena = ordensNumericas[2];

            if (valorCentena > 0)
            {
                if (valorCentena == valor)
                    return $" {Nomenclatura.Numeros[valorCentena] + genero} ";
                else
                    unidadePorExtenso += $" {Nomenclatura.Numeros[valorCentena] + genero} ";
            }

            if (valorDezena > 0)
            {
                if (valorDezena == valorDezena + valorUnidade)
                    return unidadePorExtenso += $" {Nomenclatura.Numeros[valorDezena] + genero} ";
                else if (valorDezena != 0)
                    unidadePorExtenso += $" {Nomenclatura.Numeros[valorDezena] + genero} ";
            }

            unidadePorExtenso += $" {Nomenclatura.Numeros[valorUnidade] + genero} ";

            return unidadePorExtenso;
        }
    }
}
