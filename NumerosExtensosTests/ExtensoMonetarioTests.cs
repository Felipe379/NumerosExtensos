using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoMonetarioTests
    {
        private readonly Extenso _extenso = new Extenso(PresetOptions.Presets[Preset.MonetarioBRL]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorMonetarioBRLCorretamente => new List<object[]>
        {
            new object[] { 0.00M, "ZERO REAL E ZERO CENTAVO" },
            new object[] { -10.00M, "MENOS DEZ REAIS E ZERO CENTAVO" },
            new object[] { -10.11M, "MENOS DEZ REAIS E ONZE CENTAVOS" },
            new object[] { 999999999999999.99M, "NOVECENTOS E NOVENTA E NOVE TRILHÕES E NOVECENTOS E NOVENTA E NOVE BILHÕES E NOVECENTOS E NOVENTA E NOVE MILHÕES E NOVECENTOS E NOVENTA E NOVE MIL E NOVECENTOS E NOVENTA E NOVE REAIS E NOVENTA E NOVE CENTAVOS" },
            new object[] { 0.06M, "ZERO REAL E SEIS CENTAVOS" },
            new object[] { 0.56M, "ZERO REAL E CINQUENTA E SEIS CENTAVOS" },
            new object[] { 3M, "TRÊS REAIS" },
            new object[] { 9.99M, "NOVE REAIS E NOVENTA E NOVE CENTAVOS" },
            new object[] { 11M, "ONZE REAIS" },
            new object[] { 10.01M, "DEZ REAIS E UM CENTAVO" },
            new object[] { 102M, "CENTO E DOIS REAIS" },
            new object[] { 127.10M, "CENTO E VINTE E SETE REAIS E DEZ CENTAVOS" },
            new object[] { 1500M, "UM MIL E QUINHENTOS REAIS" },
            new object[] { 1354.44M, "UM MIL E TREZENTOS E CINQUENTA E QUATRO REAIS E QUARENTA E QUATRO CENTAVOS" },
            new object[] { 13559M, "TREZE MIL E QUINHENTOS E CINQUENTA E NOVE REAIS" },
            new object[] { 11111.01M, "ONZE MIL E CENTO E ONZE REAIS E UM CENTAVO" },
            new object[] { 205702M, "DUZENTOS E CINCO MIL E SETECENTOS E DOIS REAIS" },
            new object[] { 454001.32M, "QUATROCENTOS E CINQUENTA E QUATRO MIL E UM REAIS E TRINTA E DOIS CENTAVOS" },
            new object[] { 1000000M, "UM MILHÃO DE REAIS" },
            new object[] { 1000100.09M, "UM MILHÃO E CEM REAIS E NOVE CENTAVOS" },
            new object[] { 21080010M, "VINTE E UM MILHÕES E OITENTA MIL E DEZ REAIS" },
            new object[] { 12001006.99M, "DOZE MILHÕES E UM MIL E SEIS REAIS E NOVENTA E NOVE CENTAVOS" },
            new object[] { 110051000M, "CENTO E DEZ MILHÕES E CINQUENTA E UM MIL REAIS" },
            new object[] { 202239009.15M, "DUZENTOS E DOIS MILHÕES E DUZENTOS E TRINTA E NOVE MIL E NOVE REAIS E QUINZE CENTAVOS" },
            new object[] { 1002050000M, "UM BILHÃO E DOIS MILHÕES E CINQUENTA MIL REAIS" },
            new object[] { 7050000000.23M, "SETE BILHÕES E CINQUENTA MILHÕES DE REAIS E VINTE E TRÊS CENTAVOS" },
            new object[] { 20000000000M, "VINTE BILHÕES DE REAIS" },
            new object[] { 99001001000.10M, "NOVENTA E NOVE BILHÕES E UM MILHÃO E UM MIL REAIS E DEZ CENTAVOS" },
            new object[] { 417000010030M, "QUATROCENTOS E DEZESSETE BILHÕES E DEZ MIL E TRINTA REAIS" },
            new object[] { 109000600010.65M, "CENTO E NOVE BILHÕES E SEISCENTOS MIL E DEZ REAIS E SESSENTA E CINCO CENTAVOS" },
            new object[] { 1000000021340M, "UM TRILHÃO E VINTE E UM MIL E TREZENTOS E QUARENTA REAIS" },
            new object[] { 4018001619000.01M, "QUATRO TRILHÕES E DEZOITO BILHÕES E UM MILHÃO E SEISCENTOS E DEZENOVE MIL REAIS E UM CENTAVO" },
            new object[] { 16000250090101M, "DEZESSEIS TRILHÕES E DUZENTOS E CINQUENTA MILHÕES E NOVENTA MIL E CENTO E UM REAIS" },
            new object[] { 55003001941020.77M, "CINQUENTA E CINCO TRILHÕES E TRÊS BILHÕES E UM MILHÃO E NOVECENTOS E QUARENTA E UM MIL E VINTE REAIS E SETENTA E SETE CENTAVOS" },
            new object[] { 100000000000000M, "CEM TRILHÕES DE REAIS" },
            new object[] { 855000100001100.89M, "OITOCENTOS E CINQUENTA E CINCO TRILHÕES E CEM MILHÕES E UM MIL E CEM REAIS E OITENTA E NOVE CENTAVOS" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorMonetarioBRLCorretamente))]
        public void DeveEscreverValorMonetarioBRLCorretamente(decimal valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor.ToString()).ToUpper();

            Assert.Equal(expected, actual);
        }
    }
}
