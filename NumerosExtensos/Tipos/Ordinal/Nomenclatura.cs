using System.Collections.Generic;

namespace NumerosExtensos.Tipos.Ordinal
{
    public class Nomenclatura
    {
        internal static readonly Dictionary<int?, string> Numeros = new Dictionary<int?, string>()
        {
            { 0, "Neutr" },
            { 1, "Primeir"},
            { 2, "Segund"},
            { 3, "Terceir" },
            { 4, "Quart" },
            { 5, "Quint" },
            { 6, "Sext" },
            { 7, "Sétim" },
            { 8, "Oitav" },
            { 9, "Non" },
            { 10, "Décim" },
            { 20, "Vigésim" },
            { 30, "Trigésim" },
            { 40, "Quadragésim" },
            { 50, "Quinquagésim" },
            { 60, "Sexagésim" },
            { 70, "Septuagésim" },
            { 80, "Octogésim" },
            { 90, "Nonagésim" },
            { 100, "Centésim" },
            { 200, "Ducentésim" },
            { 300, "Tricentésim" },
            { 400, "Quadrigentésim" },
            { 500, "Quingentésim" },
            { 600, "Sexcentésim" },
            { 700, "Septlingentésim" },
            { 800, "Octigentésim" },
            { 900, "Nonigentésim" },
        };

        internal static readonly Dictionary<int?, string> NomenclaturaClasses = new Dictionary<int?, string>()
        {
            { 0, "" },
            { 1, "Milésim" },
            { 2, "Milionésim" },
            { 3, "Bilionésim" },
            { 4, "Trilionésim" },
            { 5, "Quatrilionésim" },
            { 6, "Quintilionésim" },
            { 7, "Sextilionésim" },
            { 8, "Septilionésim"},
            { 9,  "Octilionésim" },
            { 10, "Nonilionésim" },
            { 11, "Decilionésim" },
            { 12, "Undecilionésim" },
            { 13, "Duodecilionésim" },
            { 14, "Tredecilionésimo" },
            { 15, "Quatuordecilionésim" },
            { 16, "Quindecilionésim" },
            { 17, "Sexdecilionésim" },
            { 18, "Septendecilionésim" },
            { 19, "Octodecilionésim" },
            { 20, "Novendecilionésim" },
            { 21, "Vigintilionésim" }
        };
    }
}
