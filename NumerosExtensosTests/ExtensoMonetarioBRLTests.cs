using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoMonetarioBRLTests
    {
        private readonly Extenso _extenso = new Extenso(PresetOptions.Presets[Preset.MonetarioBRL]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorMonetarioBRLCorretamente => new List<object[]>
        {
            new object[] { "0.00", "ZERO REAL E ZERO CENTAVO" },
            new object[] { ",05", "E CINCO CENTAVOS" },
            new object[] { ".10", "E DEZ CENTAVOS" },
            new object[] { "-10.00", "MENOS DEZ REAIS E ZERO CENTAVO" },
            new object[] { "-10.11", "MENOS DEZ REAIS E ONZE CENTAVOS" },
            new object[] { "999999999999999.99", "NOVECENTOS E NOVENTA E NOVE TRILHÕES E NOVECENTOS E NOVENTA E NOVE BILHÕES E NOVECENTOS E NOVENTA E NOVE MILHÕES E NOVECENTOS E NOVENTA E NOVE MIL E NOVECENTOS E NOVENTA E NOVE REAIS E NOVENTA E NOVE CENTAVOS" },
            new object[] { "0.06", "ZERO REAL E SEIS CENTAVOS" },
            new object[] { "0.56", "ZERO REAL E CINQUENTA E SEIS CENTAVOS" },
            new object[] { "3", "TRÊS REAIS" },
            new object[] { "9.99", "NOVE REAIS E NOVENTA E NOVE CENTAVOS" },
            new object[] { "11", "ONZE REAIS" },
            new object[] { "10.01", "DEZ REAIS E UM CENTAVO" },
            new object[] { "102", "CENTO E DOIS REAIS" },
            new object[] { "127.10", "CENTO E VINTE E SETE REAIS E DEZ CENTAVOS" },
            new object[] { "1500", "UM MIL E QUINHENTOS REAIS" },
            new object[] { "1354.44", "UM MIL E TREZENTOS E CINQUENTA E QUATRO REAIS E QUARENTA E QUATRO CENTAVOS" },
            new object[] { "13559", "TREZE MIL E QUINHENTOS E CINQUENTA E NOVE REAIS" },
            new object[] { "11111.01", "ONZE MIL E CENTO E ONZE REAIS E UM CENTAVO" },
            new object[] { "205702", "DUZENTOS E CINCO MIL E SETECENTOS E DOIS REAIS" },
            new object[] { "454001.32", "QUATROCENTOS E CINQUENTA E QUATRO MIL E UM REAIS E TRINTA E DOIS CENTAVOS" },
            new object[] { "1000000", "UM MILHÃO DE REAIS" },
            new object[] { "1000100.09", "UM MILHÃO E CEM REAIS E NOVE CENTAVOS" },
            new object[] { "21080010", "VINTE E UM MILHÕES E OITENTA MIL E DEZ REAIS" },
            new object[] { "12001006.99", "DOZE MILHÕES E UM MIL E SEIS REAIS E NOVENTA E NOVE CENTAVOS" },
            new object[] { "110051000", "CENTO E DEZ MILHÕES E CINQUENTA E UM MIL REAIS" },
            new object[] { "202239009.15", "DUZENTOS E DOIS MILHÕES E DUZENTOS E TRINTA E NOVE MIL E NOVE REAIS E QUINZE CENTAVOS" },
            new object[] { "1002050000", "UM BILHÃO E DOIS MILHÕES E CINQUENTA MIL REAIS" },
            new object[] { "7050000000.23", "SETE BILHÕES E CINQUENTA MILHÕES DE REAIS E VINTE E TRÊS CENTAVOS" },
            new object[] { "20000000000", "VINTE BILHÕES DE REAIS" },
            new object[] { "99001001000.10", "NOVENTA E NOVE BILHÕES E UM MILHÃO E UM MIL REAIS E DEZ CENTAVOS" },
            new object[] { "417000010030", "QUATROCENTOS E DEZESSETE BILHÕES E DEZ MIL E TRINTA REAIS" },
            new object[] { "109000600010.65", "CENTO E NOVE BILHÕES E SEISCENTOS MIL E DEZ REAIS E SESSENTA E CINCO CENTAVOS" },
            new object[] { "1000000021340", "UM TRILHÃO E VINTE E UM MIL E TREZENTOS E QUARENTA REAIS" },
            new object[] { "4018001619000.01", "QUATRO TRILHÕES E DEZOITO BILHÕES E UM MILHÃO E SEISCENTOS E DEZENOVE MIL REAIS E UM CENTAVO" },
            new object[] { "16000250090101", "DEZESSEIS TRILHÕES E DUZENTOS E CINQUENTA MILHÕES E NOVENTA MIL E CENTO E UM REAIS" },
            new object[] { "55003001941020.77", "CINQUENTA E CINCO TRILHÕES E TRÊS BILHÕES E UM MILHÃO E NOVECENTOS E QUARENTA E UM MIL E VINTE REAIS E SETENTA E SETE CENTAVOS" },
            new object[] { "100000000000000", "CEM TRILHÕES DE REAIS" },
            new object[] { "855000100001100.89", "OITOCENTOS E CINQUENTA E CINCO TRILHÕES E CEM MILHÕES E UM MIL E CEM REAIS E OITENTA E NOVE CENTAVOS" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorMonetarioBRLCorretamente))]
        public void DeveEscreverValorMonetarioBRLCorretamente(string valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor).ToUpper();

            Assert.Equal(expected, actual);
        }
    }
}
