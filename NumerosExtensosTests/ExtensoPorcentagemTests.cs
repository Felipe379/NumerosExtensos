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
            new object[] { "0.00", "ZERO VÍRGULA ZERO ZERO POR CENTO" },
            new object[] { ",05", "VÍRGULA ZERO CINCO POR CENTO" },
            new object[] { ".10", "VÍRGULA DEZ POR CENTO" },
            new object[] { "-10", "MENOS DEZ POR CENTO" },
            new object[] { "-10.11", "MENOS DEZ VÍRGULA ONZE POR CENTO" },
            new object[] { "999999999999999.9999", "NOVECENTOS E NOVENTA E NOVE TRILHÕES E NOVECENTOS E NOVENTA E NOVE BILHÕES E NOVECENTOS E NOVENTA E NOVE MILHÕES E NOVECENTOS E NOVENTA E NOVE MIL E NOVECENTOS E NOVENTA E NOVE VÍRGULA NOVE MIL E NOVECENTOS E NOVENTA E NOVE POR CENTO" },
            new object[] { "0.06", "ZERO VÍRGULA ZERO SEIS POR CENTO" },
            new object[] { "0.56", "ZERO VÍRGULA CINQUENTA E SEIS POR CENTO" },
            new object[] { "0.001", "ZERO VÍRGULA ZERO ZERO UM POR CENTO" },
            new object[] { "0.1031", "ZERO VÍRGULA UM MIL E TRINTA E UM POR CENTO" },
            new object[] { "3", "TRÊS POR CENTO" },
            new object[] { "9.99", "NOVE VÍRGULA NOVENTA E NOVE POR CENTO" },
            new object[] { "11", "ONZE POR CENTO" },
            new object[] { "10.01", "DEZ VÍRGULA ZERO UM POR CENTO" },
            new object[] { "102", "CENTO E DOIS POR CENTO" },
            new object[] { "127.10", "CENTO E VINTE E SETE VÍRGULA DEZ POR CENTO" },
            new object[] { "1500", "UM MIL E QUINHENTOS POR CENTO" },
            new object[] { "1354.44", "UM MIL E TREZENTOS E CINQUENTA E QUATRO VÍRGULA QUARENTA E QUATRO POR CENTO" },
            new object[] { "13559", "TREZE MIL E QUINHENTOS E CINQUENTA E NOVE POR CENTO" },
            new object[] { "11111.01", "ONZE MIL E CENTO E ONZE VÍRGULA ZERO UM POR CENTO" },
            new object[] { "205702", "DUZENTOS E CINCO MIL E SETECENTOS E DOIS POR CENTO" },
            new object[] { "454001.32", "QUATROCENTOS E CINQUENTA E QUATRO MIL E UM VÍRGULA TRINTA E DOIS POR CENTO" },
            new object[] { "1000000", "UM MILHÃO POR CENTO" },
            new object[] { "1000100.09", "UM MILHÃO E CEM VÍRGULA ZERO NOVE POR CENTO" },
            new object[] { "21080010", "VINTE E UM MILHÕES E OITENTA MIL E DEZ POR CENTO" },
            new object[] { "12001006.99", "DOZE MILHÕES E UM MIL E SEIS VÍRGULA NOVENTA E NOVE POR CENTO" },
            new object[] { "110051000", "CENTO E DEZ MILHÕES E CINQUENTA E UM MIL POR CENTO" },
            new object[] { "202239009.15", "DUZENTOS E DOIS MILHÕES E DUZENTOS E TRINTA E NOVE MIL E NOVE VÍRGULA QUINZE POR CENTO" },
            new object[] { "1002050000", "UM BILHÃO E DOIS MILHÕES E CINQUENTA MIL POR CENTO" },
            new object[] { "7050000000.23", "SETE BILHÕES E CINQUENTA MILHÕES VÍRGULA VINTE E TRÊS POR CENTO" },
            new object[] { "20000000000", "VINTE BILHÕES POR CENTO" },
            new object[] { "99001001000.1", "NOVENTA E NOVE BILHÕES E UM MILHÃO E UM MIL VÍRGULA UM POR CENTO" },
            new object[] { "417000010030", "QUATROCENTOS E DEZESSETE BILHÕES E DEZ MIL E TRINTA POR CENTO" },
            new object[] { "109000600010.65", "CENTO E NOVE BILHÕES E SEISCENTOS MIL E DEZ VÍRGULA SESSENTA E CINCO POR CENTO" },
            new object[] { "1000000021340", "UM TRILHÃO E VINTE E UM MIL E TREZENTOS E QUARENTA POR CENTO" },
            new object[] { "4018001619000.01", "QUATRO TRILHÕES E DEZOITO BILHÕES E UM MILHÃO E SEISCENTOS E DEZENOVE MIL VÍRGULA ZERO UM POR CENTO" },
            new object[] { "16000250090101", "DEZESSEIS TRILHÕES E DUZENTOS E CINQUENTA MILHÕES E NOVENTA MIL E CENTO E UM POR CENTO" },
            new object[] { "55003001941020.77", "CINQUENTA E CINCO TRILHÕES E TRÊS BILHÕES E UM MILHÃO E NOVECENTOS E QUARENTA E UM MIL E VINTE VÍRGULA SETENTA E SETE POR CENTO" },
            new object[] { "100000000000000", "CEM TRILHÕES POR CENTO" },
            new object[] { "855000100001100.89", "OITOCENTOS E CINQUENTA E CINCO TRILHÕES E CEM MILHÕES E UM MIL E CEM VÍRGULA OITENTA E NOVE POR CENTO" }
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
