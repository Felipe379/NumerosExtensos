using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoPorcentagemTests
    {
        private readonly Extenso _extenso = new Extenso(PresetOptions.Presets[Preset.Porcentagem]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorPorcentagemCorretamente => new List<object[]>
        {
            new object[] { 0.00M, "ZERO V�RGULA ZERO ZERO POR CENTO" },
            new object[] { -10M, "MENOS DEZ POR CENTO" },
            new object[] { -10.11M, "MENOS DEZ V�RGULA ONZE POR CENTO" },
            new object[] { 999999999999999.9999M, "NOVECENTOS E NOVENTA E NOVE TRILH�ES E NOVECENTOS E NOVENTA E NOVE BILH�ES E NOVECENTOS E NOVENTA E NOVE MILH�ES E NOVECENTOS E NOVENTA E NOVE MIL E NOVECENTOS E NOVENTA E NOVE V�RGULA NOVE MIL E NOVECENTOS E NOVENTA E NOVE POR CENTO" },
            new object[] { 0.06M, "ZERO V�RGULA ZERO SEIS POR CENTO" },
            new object[] { 0.56M, "ZERO V�RGULA CINQUENTA E SEIS POR CENTO" },
            new object[] { 0.001M, "ZERO V�RGULA ZERO ZERO UM POR CENTO" },
            new object[] { 0.1031M, "ZERO V�RGULA UM MIL E TRINTA E UM POR CENTO" },
            new object[] { 3M, "TR�S POR CENTO" },
            new object[] { 9.99M, "NOVE V�RGULA NOVENTA E NOVE POR CENTO" },
            new object[] { 11M, "ONZE POR CENTO" },
            new object[] { 10.01M, "DEZ V�RGULA ZERO UM POR CENTO" },
            new object[] { 102M, "CENTO E DOIS POR CENTO" },
            new object[] { 127.10M, "CENTO E VINTE E SETE V�RGULA DEZ POR CENTO" },
            new object[] { 1500M, "UM MIL E QUINHENTOS POR CENTO" },
            new object[] { 1354.44M, "UM MIL E TREZENTOS E CINQUENTA E QUATRO V�RGULA QUARENTA E QUATRO POR CENTO" },
            new object[] { 13559M, "TREZE MIL E QUINHENTOS E CINQUENTA E NOVE POR CENTO" },
            new object[] { 11111.01M, "ONZE MIL E CENTO E ONZE V�RGULA ZERO UM POR CENTO" },
            new object[] { 205702M, "DUZENTOS E CINCO MIL E SETECENTOS E DOIS POR CENTO" },
            new object[] { 454001.32M, "QUATROCENTOS E CINQUENTA E QUATRO MIL E UM V�RGULA TRINTA E DOIS POR CENTO" },
            new object[] { 1000000M, "UM MILH�O POR CENTO" },
            new object[] { 1000100.09M, "UM MILH�O E CEM V�RGULA ZERO NOVE POR CENTO" },
            new object[] { 21080010M, "VINTE E UM MILH�ES E OITENTA MIL E DEZ POR CENTO" },
            new object[] { 12001006.99M, "DOZE MILH�ES E UM MIL E SEIS V�RGULA NOVENTA E NOVE POR CENTO" },
            new object[] { 110051000M, "CENTO E DEZ MILH�ES E CINQUENTA E UM MIL POR CENTO" },
            new object[] { 202239009.15M, "DUZENTOS E DOIS MILH�ES E DUZENTOS E TRINTA E NOVE MIL E NOVE V�RGULA QUINZE POR CENTO" },
            new object[] { 1002050000M, "UM BILH�O E DOIS MILH�ES E CINQUENTA MIL POR CENTO" },
            new object[] { 7050000000.23M, "SETE BILH�ES E CINQUENTA MILH�ES V�RGULA VINTE E TR�S POR CENTO" },
            new object[] { 20000000000M, "VINTE BILH�ES POR CENTO" },
            new object[] { 99001001000.1M, "NOVENTA E NOVE BILH�ES E UM MILH�O E UM MIL V�RGULA UM POR CENTO" },
            new object[] { 417000010030M, "QUATROCENTOS E DEZESSETE BILH�ES E DEZ MIL E TRINTA POR CENTO" },
            new object[] { 109000600010.65M, "CENTO E NOVE BILH�ES E SEISCENTOS MIL E DEZ V�RGULA SESSENTA E CINCO POR CENTO" },
            new object[] { 1000000021340M, "UM TRILH�O E VINTE E UM MIL E TREZENTOS E QUARENTA POR CENTO" },
            new object[] { 4018001619000.01M, "QUATRO TRILH�ES E DEZOITO BILH�ES E UM MILH�O E SEISCENTOS E DEZENOVE MIL V�RGULA ZERO UM POR CENTO" },
            new object[] { 16000250090101M, "DEZESSEIS TRILH�ES E DUZENTOS E CINQUENTA MILH�ES E NOVENTA MIL E CENTO E UM POR CENTO" },
            new object[] { 55003001941020.77M, "CINQUENTA E CINCO TRILH�ES E TR�S BILH�ES E UM MILH�O E NOVECENTOS E QUARENTA E UM MIL E VINTE V�RGULA SETENTA E SETE POR CENTO" },
            new object[] { 100000000000000M, "CEM TRILH�ES POR CENTO" },
            new object[] { 855000100001100.89M, "OITOCENTOS E CINQUENTA E CINCO TRILH�ES E CEM MILH�ES E UM MIL E CEM V�RGULA OITENTA E NOVE POR CENTO" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorPorcentagemCorretamente))]
        public void DeveEscreverValorPorcentagemCorretamente(decimal valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor.ToString()).ToUpper();

            Assert.Equal(expected, actual);
        }
    }
}
