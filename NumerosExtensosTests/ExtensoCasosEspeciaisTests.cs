using NumerosExtensos;
using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Options.Numerais;
using System;
using System.Collections.Generic;
using Xunit;

namespace NumerosExtensosTests
{
    public class ExtensoCasosEspeciaisTests
    {
        private readonly Extenso _extenso = new();
        public static IEnumerable<object[]> InstanciaParaEscreverValorDeTipoNumericoCorretamente => new List<object[]>
        {
            new object[] { 1e20, null, (ushort)1, "CEM QUINTILHÕES" },
            new object[] { 16777216f, null, (ushort)1, "DEZESSEIS MILHÕES, SETECENTOS E SETENTA E SETE MIL, DUZENTOS E DEZESSEIS" },
            new object[] { -0.001, (ushort)2, (ushort)1, "ZERO VÍRGULA ZERO ZERO" },
            new object[] { 0, null, (ushort)0, "ZERO" },
            new object[] { 0.5m, null, (ushort)0, "VÍRGULA CINCO" }
        };

        public static IEnumerable<object[]> InstanciaParaLancarArgumentOutOfRangeException => new List<object[]>
        {
            new object[] { double.MaxValue, null, (ushort)1 },
            new object[] { 1.5m, (ushort)67, (ushort)1 },
            new object[] { 5, null, (ushort)67 }
        };

        public static IEnumerable<object[]> InstanciaParaLancarFormatException => new List<object[]>
        {
            new object[] { Predefinicoes.Cardinais, "" },
            new object[] { Predefinicoes.Ordinais, "" },
            new object[] { Predefinicoes.Romanos, "" }
        };

        [Theory]
        [MemberData(nameof(InstanciaParaEscreverValorDeTipoNumericoCorretamente))]
        public void DeveEscreverValorDeTipoNumericoCorretamente(object valor, ushort? precisaoDecimal, ushort zerosEsquerda, string expected)
        {
            var actual = _extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.Cardinais]).Numero(valor, precisaoDecimal, zerosEsquerda).ToUpper();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(InstanciaParaLancarArgumentOutOfRangeException))]
        public void DeveLancarArgumentOutOfRangeExceptionParaParametrosForaDoIntervalo(object valor, ushort? precisaoDecimal, ushort zerosEsquerda)
        {
            var escrita = _extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.Cardinais]);

            Assert.Throws<ArgumentOutOfRangeException>(() => escrita.Numero(valor, precisaoDecimal, zerosEsquerda));
        }

        [Theory]
        [MemberData(nameof(InstanciaParaLancarFormatException))]
        public void DeveLancarFormatExceptionParaValorVazio(Predefinicoes predefinicao, string valor)
        {
            var escrita = _extenso.Escrever(OpcoesPredefinidas.Predefinicoes[predefinicao]);

            Assert.Throws<FormatException>(() => escrita.Numero(valor));
        }

        [Fact]
        public void DeveEscreverCardinalFemininoComClassesDeMilhaoNoMasculino()
        {
            var options = new ExtensoOptions
            {
                Tipo = TipoNumerais.Cardinais,
                NumeraisOptions = new CardinaisOptions { DeveUsarExtensoFeminino = true }
            };

            var actual = _extenso.Escrever(options).Numero("2200000").ToUpper();

            Assert.Equal("DOIS MILHÕES DUZENTAS MIL", actual);
        }

        [Fact]
        public void DeveConsiderarAlteracaoDoGeneroAposInstanciarCardinal()
        {
            var options = new ExtensoOptions
            {
                Tipo = TipoNumerais.Cardinais,
                NumeraisOptions = new CardinaisOptions()
            };
            var escrita = (NumerosExtensos.Tipos.Cardinal.Escrever)_extenso.Escrever(options);

            escrita.CardinaisOptions.DeveUsarExtensoFeminino = true;
            var actual = escrita.Numero("2").ToUpper();

            Assert.Equal("DUAS", actual);
        }

        [Fact]
        public void DeveSepararSingularDoOrdinalPorEspaco()
        {
            var options = new ExtensoOptions
            {
                Tipo = TipoNumerais.Ordinais,
                NumeraisOptions = new OrdinaisOptions { Singular = "Colocado" }
            };

            var actual = _extenso.Escrever(options).Numero("15").ToUpper();

            Assert.Equal("DÉCIMO QUINTO COLOCADO", actual);
        }

        [Fact]
        public void DeveLancarArgumentNullExceptionParaValorNulo()
        {
            var escrita = _extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.Cardinais]);

            Assert.Throws<ArgumentNullException>(() => escrita.Numero((object)null));
        }

        [Fact]
        public void DeveLancarArgumentNullExceptionParaOpcoesNulas()
        {
            Assert.Throws<ArgumentNullException>(() => _extenso.Escrever(null));
        }

        [Fact]
        public void DeveLancarInvalidOperationExceptionComMensagemParaOpcoesDoTipoErrado()
        {
            var options = new ExtensoOptions { Tipo = TipoNumerais.Cardinais };

            var exception = Assert.Throws<InvalidOperationException>(() => _extenso.Escrever(options));

            Assert.Contains(nameof(CardinaisOptions), exception.Message);
        }

        [Fact]
        public void DeveManterOpcaoPredefinidaOriginalAposAlteracaoDeOutroConsumidor()
        {
            var opcoes = (CardinaisOptions)OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL].NumeraisOptions;
            opcoes.ParteInteiraPlural = "Dólares";

            var actual = _extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL]).Numero("5").ToUpper();

            Assert.Equal("CINCO REAIS", actual);
        }
    }
}
