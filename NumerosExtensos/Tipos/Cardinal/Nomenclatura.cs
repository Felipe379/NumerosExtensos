﻿using System.Collections.Generic;

namespace NumerosExtensos.Tipos.Cardinal
{
    internal class Nomenclatura
    {
        internal Nomenclatura(bool deveUsarExtensoFeminino)
        {
            Numeros = deveUsarExtensoFeminino ? NumerosFeminino : NumerosMasculino;
        }

        private static readonly Dictionary<int, string> NumerosMasculino = new Dictionary<int, string>()
        {
            { -100, "Cem" },
            { -1, "Hum" },
            { 0, "Zero" },
            { 1, "Um"},
            { 2, "Dois"},
            { 3, "Três" },
            { 4, "Quatro" },
            { 5, "Cinco" },
            { 6, "Seis" },
            { 7, "Sete" },
            { 8, "Oito" },
            { 9, "Nove" },
            { 10, "Dez" },
            { 11, "Onze" },
            { 12, "Doze" },
            { 13, "Treze" },
            { 14, "Quatorze" },
            { 15, "Quinze" },
            { 16, "Dezesseis" },
            { 17, "Dezessete" },
            { 18, "Dezoito" },
            { 19, "Dezenove" },
            { 20, "Vinte" },
            { 30, "Trinta" },
            { 40, "Quarenta" },
            { 50, "Cinquenta" },
            { 60, "Sessenta" },
            { 70, "Setenta" },
            { 80, "Oitenta" },
            { 90, "Noventa" },
            { 100, "Cento" },
            { 200, "Duzentos" },
            { 300, "Trezentos" },
            { 400, "Quatrocentos" },
            { 500, "Quinhentos" },
            { 600, "Seiscentos" },
            { 700, "Setecentos" },
            { 800, "Oitocentos" },
            { 900, "Novecentos" },
        };

        private static readonly Dictionary<int, string> NumerosFeminino = new Dictionary<int, string>()
        {
            { -100, "Cem" },
            { -1, "Hum" },
            { 0, "Zero" },
            { 1, "Uma" },
            { 2, "Duas" },
            { 3, "Três" },
            { 4, "Quatro" },
            { 5, "Cinco" },
            { 6, "Seis" },
            { 7, "Sete" },
            { 8, "Oito" },
            { 9, "Nove" },
            { 10, "Dez" },
            { 11, "Onze" },
            { 12, "Doze" },
            { 13, "Treze" },
            { 14, "Quatorze" },
            { 15, "Quinze" },
            { 16, "Dezesseis" },
            { 17, "Dezessete" },
            { 18, "Dezoito" },
            { 19, "Dezenove" },
            { 20, "Vinte" },
            { 30, "Trinta" },
            { 40, "Quarenta" },
            { 50, "Cinquenta" },
            { 60, "Sessenta" },
            { 70, "Setenta" },
            { 80, "Oitenta" },
            { 90, "Noventa" },
            { 100, "Cento" },
            { 200, "Duzentas" },
            { 300, "Trezentas" },
            { 400, "Quatrocentas" },
            { 500, "Quinhentas" },
            { 600, "Seiscentas" },
            { 700, "Setecentas" },
            { 800, "Oitocentas" },
            { 900, "Novecentas" }
        };

        internal readonly Dictionary<int, string> Numeros = new Dictionary<int, string>() { };

        internal readonly Dictionary<int, string> Classes = new Dictionary<int, string>()
        {
            { 0, "" },
            { 1, "Mil" },
            { 2, "Milh" },
            { 3, "Bilh" },
            { 4, "Trilh" },
            { 5, "Quadrilh" },
            { 6, "Quintilh" },
            { 7, "Sextilh" },
            { 8, "Setilh"},
            { 9,  "Octilh" },
            { 10, "Nonilh" },
            { 11, "Decilh" },
            { 12, "Undecilh" },
            { 13, "Dodecilh" },
            { 14, "Tredicilh" },
            { 15, "Quatordecilh" },
            { 16, "Quindecilh" },
            { 17, "Sedecilh" },
            { 18, "Septendecilh" },
            { 19, "Octodecilh" },
            { 20, "Novendecilh" },
            { 21, "Vigintilh" }
        };
    }
}
