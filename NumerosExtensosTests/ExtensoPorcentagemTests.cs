using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoPorcentagemTests
    {
        private readonly Extenso _extenso = new Extenso(OpcoesPredefinidas.Predefinicoes[Predefinicoes.Porcentagem]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorPorcentagemCorretamente => new List<object[]>
        {
            new object[] { "0.00", "ZERO V�RGULA ZERO ZERO POR CENTO" },
            new object[] { ",05", "V�RGULA ZERO CINCO POR CENTO" },
            new object[] { ".10", "V�RGULA DEZ POR CENTO" },
            new object[] { "-10", "MENOS DEZ POR CENTO" },
            new object[] { "-10.11", "MENOS DEZ V�RGULA ONZE POR CENTO" },
            new object[] { "999999999999999.9999", "NOVECENTOS E NOVENTA E NOVE TRILH�ES NOVECENTOS E NOVENTA E NOVE BILH�ES NOVECENTOS E NOVENTA E NOVE MILH�ES NOVECENTOS E NOVENTA E NOVE MIL NOVECENTOS E NOVENTA E NOVE V�RGULA NOVE MIL NOVECENTOS E NOVENTA E NOVE POR CENTO" },
            new object[] { "0.06", "ZERO V�RGULA ZERO SEIS POR CENTO" },
            new object[] { "0.56", "ZERO V�RGULA CINQUENTA E SEIS POR CENTO" },
            new object[] { "0.001", "ZERO V�RGULA ZERO ZERO UM POR CENTO" },
            new object[] { "0.1031", "ZERO V�RGULA UM MIL E TRINTA E UM POR CENTO" },
            new object[] { "3", "TR�S POR CENTO" },
            new object[] { "9.99", "NOVE V�RGULA NOVENTA E NOVE POR CENTO" },
            new object[] { "11", "ONZE POR CENTO" },
            new object[] { "10.01", "DEZ V�RGULA ZERO UM POR CENTO" },
            new object[] { "102", "CENTO E DOIS POR CENTO" },
            new object[] { "127.10", "CENTO E VINTE E SETE V�RGULA DEZ POR CENTO" },
            new object[] { "1500", "UM MIL E QUINHENTOS POR CENTO" },
            new object[] { "1354.44", "UM MIL TREZENTOS E CINQUENTA E QUATRO V�RGULA QUARENTA E QUATRO POR CENTO" },
            new object[] { "13559", "TREZE MIL QUINHENTOS E CINQUENTA E NOVE POR CENTO" },
            new object[] { "11111.01", "ONZE MIL CENTO E ONZE V�RGULA ZERO UM POR CENTO" },
            new object[] { "205702", "DUZENTOS E CINCO MIL SETECENTOS E DOIS POR CENTO" },
            new object[] { "454001.32", "QUATROCENTOS E CINQUENTA E QUATRO MIL E UM V�RGULA TRINTA E DOIS POR CENTO" },
            new object[] { "1000000", "UM MILH�O POR CENTO" },
            new object[] { "1000100.09", "UM MILH�O E CEM V�RGULA ZERO NOVE POR CENTO" },
            new object[] { "21080010", "VINTE E UM MILH�ES OITENTA MIL E DEZ POR CENTO" },
            new object[] { "12001006.99", "DOZE MILH�ES UM MIL E SEIS V�RGULA NOVENTA E NOVE POR CENTO" },
            new object[] { "110051000", "CENTO E DEZ MILH�ES CINQUENTA E UM MIL POR CENTO" },
            new object[] { "202239009.15", "DUZENTOS E DOIS MILH�ES DUZENTOS E TRINTA E NOVE MIL E NOVE V�RGULA QUINZE POR CENTO" },
            new object[] { "1002050000", "UM BILH�O DOIS MILH�ES CINQUENTA MIL POR CENTO" },
            new object[] { "7050000000.23", "SETE BILH�ES CINQUENTA MILH�ES V�RGULA VINTE E TR�S POR CENTO" },
            new object[] { "20000000000", "VINTE BILH�ES POR CENTO" },
            new object[] { "99001001000.1", "NOVENTA E NOVE BILH�ES UM MILH�O UM MIL V�RGULA UM POR CENTO" },
            new object[] { "417000010030", "QUATROCENTOS E DEZESSETE BILH�ES DEZ MIL E TRINTA POR CENTO" },
            new object[] { "109000600010.65", "CENTO E NOVE BILH�ES SEISCENTOS MIL E DEZ V�RGULA SESSENTA E CINCO POR CENTO" },
            new object[] { "1000000021340", "UM TRILH�O VINTE E UM MIL TREZENTOS E QUARENTA POR CENTO" },
            new object[] { "4018001619000.01", "QUATRO TRILH�ES DEZOITO BILH�ES UM MILH�O SEISCENTOS E DEZENOVE MIL V�RGULA ZERO UM POR CENTO" },
            new object[] { "16000250090101", "DEZESSEIS TRILH�ES DUZENTOS E CINQUENTA MILH�ES NOVENTA MIL CENTO E UM POR CENTO" },
            new object[] { "55003001941020.77", "CINQUENTA E CINCO TRILH�ES TR�S BILH�ES UM MILH�O NOVECENTOS E QUARENTA E UM MIL E VINTE V�RGULA SETENTA E SETE POR CENTO" },
            new object[] { "100000000000000", "CEM TRILH�ES POR CENTO" },
            new object[] { "855000100001100.89", "OITOCENTOS E CINQUENTA E CINCO TRILH�ES CEM MILH�ES UM MIL E CEM V�RGULA OITENTA E NOVE POR CENTO" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorPorcentagemCorretamente))]
        public void DeveEscreverValorPorcentagemCorretamente(string valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor).ToUpper();

            Assert.Equal(expected, actual);
        }
    }
}
