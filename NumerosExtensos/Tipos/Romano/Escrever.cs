﻿using System;
using System.Text.RegularExpressions;

namespace NumerosExtensos.Tipos.Romano
{
    public class Escrever
    {
        public static string Numero(string numero)
        {
            var regex = @"^" +                                            // Inicio
                        @"([0-3]?[0-9]?[0-9]?[0-9]?)" +                   // Valor entre 0 e 3999
                        @"$";                                             // Fim

            if (!Regex.IsMatch(numero, regex))
                throw new FormatException();

            var numeroEscrito = EscreveValor(numero);

            return numeroEscrito;
        }

        private static string EscreveValor(string numero)
        {
            int valor = int.Parse(numero);

            var ordemNumerica = Helpers.ObterOrdemNumerica(valor);
            var valorUnidade = ordemNumerica[0];
            var valorDezena = ordemNumerica[1];
            var valorCentena = ordemNumerica[2];
            var valorMilhares = ordemNumerica[3];

            var numeroRomano = string.Empty;
            numeroRomano += ObtemNumeraisRomanos(valorMilhares);
            numeroRomano += ObtemNumeraisRomanos(valorCentena);
            numeroRomano += ObtemNumeraisRomanos(valorDezena);
            numeroRomano += ObtemNumeraisRomanos(valorUnidade);

            return numeroRomano;
        }

        private static string ObtemNumeraisRomanos(int? value)
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