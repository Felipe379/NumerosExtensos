﻿using NumerosExtensos;
using NumerosExtensos.Enums;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoCardinalTests
    {
        private readonly Extenso _extenso = new Extenso(PresetOptions.Presets[Preset.Cardinal]);
        public static IEnumerable<object[]> InstanciaParaEscreverValorCardinalCorretamente => new List<object[]>
        {
            new object[] { 0.00M, "ZERO VÍRGULA ZERO ZERO" },
            new object[] { -10M, "MENOS DEZ" },
            new object[] { -10.101M, "MENOS DEZ VÍRGULA CENTO E UM" },
            new object[] { 999999999999999.9999M, "NOVECENTOS E NOVENTA E NOVE TRILHÕES E NOVECENTOS E NOVENTA E NOVE BILHÕES E NOVECENTOS E NOVENTA E NOVE MILHÕES E NOVECENTOS E NOVENTA E NOVE MIL E NOVECENTOS E NOVENTA E NOVE VÍRGULA NOVE MIL E NOVECENTOS E NOVENTA E NOVE" },
            new object[] { 0.06M, "ZERO VÍRGULA ZERO SEIS" },
            new object[] { 0.56M, "ZERO VÍRGULA CINQUENTA E SEIS" },
            new object[] { 0.001M, "ZERO VÍRGULA ZERO ZERO UM" },
            new object[] { 0.1031M, "ZERO VÍRGULA UM MIL E TRINTA E UM" },
            new object[] { 3M, "TRÊS" },
            new object[] { 9.99M, "NOVE VÍRGULA NOVENTA E NOVE" },
            new object[] { 11M, "ONZE" },
            new object[] { 10.01M, "DEZ VÍRGULA ZERO UM" },
            new object[] { 102M, "CENTO E DOIS" },
            new object[] { 127.10M, "CENTO E VINTE E SETE VÍRGULA DEZ" },
            new object[] { 1500M, "UM MIL E QUINHENTOS" },
            new object[] { 1354.44M, "UM MIL E TREZENTOS E CINQUENTA E QUATRO VÍRGULA QUARENTA E QUATRO" },
            new object[] { 13559M, "TREZE MIL E QUINHENTOS E CINQUENTA E NOVE" },
            new object[] { 11111.01M, "ONZE MIL E CENTO E ONZE VÍRGULA ZERO UM" },
            new object[] { 205702M, "DUZENTOS E CINCO MIL E SETECENTOS E DOIS" },
            new object[] { 454001.32M, "QUATROCENTOS E CINQUENTA E QUATRO MIL E UM VÍRGULA TRINTA E DOIS" },
            new object[] { 1000000M, "UM MILHÃO" },
            new object[] { 1000100.09M, "UM MILHÃO E CEM VÍRGULA ZERO NOVE" },
            new object[] { 21080010M, "VINTE E UM MILHÕES E OITENTA MIL E DEZ" },
            new object[] { 12001006.99M, "DOZE MILHÕES E UM MIL E SEIS VÍRGULA NOVENTA E NOVE" },
            new object[] { 110051000M, "CENTO E DEZ MILHÕES E CINQUENTA E UM MIL" },
            new object[] { 202239009.15M, "DUZENTOS E DOIS MILHÕES E DUZENTOS E TRINTA E NOVE MIL E NOVE VÍRGULA QUINZE" },
            new object[] { 1002050000M, "UM BILHÃO E DOIS MILHÕES E CINQUENTA MIL" },
            new object[] { 7050000000.23M, "SETE BILHÕES E CINQUENTA MILHÕES VÍRGULA VINTE E TRÊS" },
            new object[] { 20000000000M, "VINTE BILHÕES" },
            new object[] { 99001001000.1M, "NOVENTA E NOVE BILHÕES E UM MILHÃO E UM MIL VÍRGULA UM" },
            new object[] { 417000010030M, "QUATROCENTOS E DEZESSETE BILHÕES E DEZ MIL E TRINTA" },
            new object[] { 109000600010.65M, "CENTO E NOVE BILHÕES E SEISCENTOS MIL E DEZ VÍRGULA SESSENTA E CINCO" },
            new object[] { 1000000021340M, "UM TRILHÃO E VINTE E UM MIL E TREZENTOS E QUARENTA" },
            new object[] { 4018001619000.01M, "QUATRO TRILHÕES E DEZOITO BILHÕES E UM MILHÃO E SEISCENTOS E DEZENOVE MIL VÍRGULA ZERO UM" },
            new object[] { 16000250090101M, "DEZESSEIS TRILHÕES E DUZENTOS E CINQUENTA MILHÕES E NOVENTA MIL E CENTO E UM" },
            new object[] { 55003001941020.77M, "CINQUENTA E CINCO TRILHÕES E TRÊS BILHÕES E UM MILHÃO E NOVECENTOS E QUARENTA E UM MIL E VINTE VÍRGULA SETENTA E SETE" },
            new object[] { 100000000000000M, "CEM TRILHÕES" },
            new object[] { 855000100001100.89M, "OITOCENTOS E CINQUENTA E CINCO TRILHÕES E CEM MILHÕES E UM MIL E CEM VÍRGULA OITENTA E NOVE" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorCardinalCorretamente))]
        public void DeveEscreverValorCadinalCorretamente(decimal valor, string expected)
        {
            var actual = _extenso.EscreverNumero(valor.ToString()).ToUpper();

            Assert.Equal(expected, actual);
        }
    }
}
