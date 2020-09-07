using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoRomanoTests
    {
        private readonly Extenso _extenso = new Extenso(PresetOptions.Presets[Preset.Romanos]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorOrdinalCorretamente => new List<object[]>
        {
            new object[] { "1", "I" },
            new object[] { "2", "II" },
            new object[] { "3", "III" },
            new object[] { "4", "IV" },
            new object[] { "5", "V" },
            new object[] { "6", "VI" },
            new object[] { "9", "IX" },
            new object[] { "27", "XXVII" },
            new object[] { "48", "XLVIII" },
            new object[] { "49", "XLIX" },
            new object[] { "59", "LIX" },
            new object[] { "93", "XCIII" },
            new object[] { "141","CXLI" },
            new object[] { "163", "CLXIII" },
            new object[] { "402", "CDII" },
            new object[] { "575", "DLXXV" },
            new object[] { "911", "CMXI" },
            new object[] { "1024", "MXXIV" },
            new object[] { "3000", "MMM" },
            new object[] { "3999", "MMMCMXCIX" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorOrdinalCorretamente))]
        public void DeveEscreverValorOrdinalCorretamente(string valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor);

            Assert.Equal(expected, actual);
        }
    }
}
