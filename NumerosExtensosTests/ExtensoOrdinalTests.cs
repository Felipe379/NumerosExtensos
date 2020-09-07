using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoOrdinalTests
    {
        private readonly Extenso _extenso = new Extenso(PresetOptions.Presets[Preset.Ordinal]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorOrdinalCorretamente => new List<object[]>
        {
            new object[] { "0", "NEUTRO" },
            new object[] { "1", "PRIMEIRO" },
            new object[] { "21", "VIGÉSIMO PRIMEIRO" },
            new object[] { "321", "TRICENTÉSIMO VIGÉSIMO PRIMEIRO" },
            new object[] { "4321", "QUARTO MILÉSIMO TRICENTÉSIMO VIGÉSIMO PRIMEIRO" },
            new object[] { "54321", "QUINQUAGÉSIMO QUARTO MILÉSIMO TRICENTÉSIMO VIGÉSIMO PRIMEIRO" },
            new object[] { "654321", "SEXCENTÉSIMO QUINQUAGÉSIMO QUARTO MILÉSIMO TRICENTÉSIMO VIGÉSIMO PRIMEIRO" },
            new object[] { "7654321", "SÉTIMO MILIONÉSIMO SEXCENTÉSIMO QUINQUAGÉSIMO QUARTO MILÉSIMO TRICENTÉSIMO VIGÉSIMO PRIMEIRO" },
            new object[] { "123748", "CENTÉSIMO VIGÉSIMO TERCEIRO MILÉSIMO SEPTLINGENTÉSIMO QUADRAGÉSIMO OITAVO" },
            new object[] { "1002", "MILÉSIMO SEGUNDO" },
            new object[] { "10000", "DÉCIMO MILÉSIMO" },
            new object[] { "57", "QUINQUAGÉSIMO SÉTIMO" },
            new object[] { "1000", "MILÉSIMO" },
            new object[] { "5129", "QUINTO MILÉSIMO CENTÉSIMO VIGÉSIMO NONO" },
            new object[] { "18446744073709551615", "DÉCIMO OITAVO QUINTILIONÉSIMO QUADRIGENTÉSIMO QUADRAGÉSIMO SEXTO QUATRILIONÉSIMO SEPTLINGENTÉSIMO QUADRAGÉSIMO QUARTO TRILIONÉSIMO SEPTUAGÉSIMO TERCEIRO BILIONÉSIMO SEPTLINGENTÉSIMO NONO MILIONÉSIMO QUINGENTÉSIMO QUINQUAGÉSIMO PRIMEIRO MILÉSIMO SEXCENTÉSIMO DÉCIMO QUINTO" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorOrdinalCorretamente))]
        public void DeveEscreverValorOrdinalCorretamente(string valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor).ToUpper();

            Assert.Equal(expected, actual);
        }
    }
}
