using NumerosExtensos.Utils;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Romano
{
    public class Escrever : Escrita
    {
        public Escrever()
        {
        }

        public override string Numero(string numero)
        {
            var pattern = @"^" +                                            // Inicio
                          @"([0-3]?[0-9]?[0-9]?[0-9]?)" +                   // Valor entre 0 e 3999
                          @"$";                                             // Fim

            var regex = new Regex(pattern).Match(numero);

            if (!regex.Success || Helpers.NumeroApenasZeros(numero))
                throw new FormatException();

            var numeroEscrito = EscreveValor(numero);

            return numeroEscrito;
        }

        private string EscreveValor(string numero)
        {
            int valor = int.Parse(numero);

            var ordensNumericas = Helpers.ObterOrdemNumerica(valor);
            var numeroRomano = string.Empty;

            foreach (var ordemNumerica in ordensNumericas.Reverse())
            {
                numeroRomano += ObtemNumeraisRomanos(ordemNumerica);
            }

            return numeroRomano;
        }

        private string ObtemNumeraisRomanos(int value)
        {
            var multiplier = 1;
            while (value >= 10)
            {
                value /= 10;
                multiplier *= 10;
            }

            var romanNumber = string.Empty;
            if (value <= 3 || (value < 9 && value > 5))
            {
                if (value > 5)
                {
                    romanNumber += Numerais.Romanos[multiplier * 5];
                    value -= 5;
                }

                for (int i = 0; i < value; i++)
                    romanNumber += Numerais.Romanos[multiplier];
            }
            else if (value == 4)
            {
                romanNumber += $"{Numerais.Romanos[multiplier]}{Numerais.Romanos[multiplier * 5]}";
            }
            else if (value == 9)
            {
                romanNumber += $"{Numerais.Romanos[multiplier]}{Numerais.Romanos[multiplier * 10]}";
            }
            else
            {
                romanNumber += Numerais.Romanos[multiplier * (int)value];
            }

            return romanNumber;
        }
    }
}
