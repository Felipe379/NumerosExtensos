using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Utils
{
    internal class Helpers
    {
        public static int[] ObterOrdemNumerica(int valor)
        {
            if (valor > 9999 || valor < 0)
                throw new NotSupportedException();

            var quantidadeClasses = 4;

            var ordemNumerica = new int[quantidadeClasses];

            for (int i = 0, valorMaximoClasseAtual = 10, classeAnterior = 1; i < quantidadeClasses; i++, classeAnterior = valorMaximoClasseAtual, valorMaximoClasseAtual *= 10)
            {
                ordemNumerica[i] = (valor % valorMaximoClasseAtual) - (valor % classeAnterior);
            }

            return ordemNumerica;
        }

        public static string RemoveZerosAEsquerda(string numero)
        {
            var index = 0;

            while (index < numero.Length && numero[index] == '0')
                index++;

            return numero.Substring(index);
        }

        public static string RemoveEspacosEmBranco(string numero) => Regex.Replace(numero, @"\s+", " ").Trim();

        public static bool NumeroSingular(string numero) => Regex.IsMatch(numero, @"^([0]*(1)?)$");

        public static bool NumeroApenasZeros(string numero) => Regex.IsMatch(numero, @"^([0]*?)$");

        public static bool NumeroTerminaEmCentenaCheia(string numero) => Regex.IsMatch(numero, @"^([1-9]{1}0{2})$");

        public static bool NumeroComecaComZero(string numero) => Regex.IsMatch(numero, @"^([0]{1}[\d]{2})$");

        public static string[] ObtemArrayNumerico(string numero) => Regex.Replace(numero, ".{1,3}", "$0,", RegexOptions.RightToLeft)
                                                                         .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                                                                         .Reverse()
                                                                         .ToArray();
    }
}
