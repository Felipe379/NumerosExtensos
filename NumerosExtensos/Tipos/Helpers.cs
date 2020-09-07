using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos
{
    internal class Helpers
    {
        public static int[] ObterOrdemNumerica(int valor)
        {
            if (valor > 9999 || valor < 0)
                throw new NotSupportedException();

            var valorUnidade = valor % 10;
            var valorDezena = (valor % 100) - (valor % 10);
            var valorCentena = (valor % 1000) - (valor % 100);
            var valorMilhares = valor - (valor % 1000);

            return new int[] { valorUnidade, valorDezena, valorCentena, valorMilhares };
        }

        public static string RemoveEspacosEmBranco(string numero) => Regex.Replace(numero, @"\s+", " ").Trim();

        public static bool NumeroSingular(string numero) => Regex.IsMatch(numero, @"^([0]*(1)?)$");

        public static string[] ObtemArrayNumerico(string numero) => Regex.Replace(numero, ".{3}", "$0,")
                                                                         .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                                                                         .Reverse()
                                                                         .ToArray();
    }
}
