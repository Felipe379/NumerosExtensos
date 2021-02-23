using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Options.Numerais;
using System.Collections.Generic;

namespace NumerosExtensos
{
    public class OpcoesPredefinidas
    {
        public static readonly Dictionary<Predefinicoes, ExtensoOptions> Predefinicoes = new Dictionary<Predefinicoes, ExtensoOptions>
        {
            { Enums.Predefinicoes.Nenhum, new ExtensoOptions
                {
                    Tipo = default,
                    NumeraisOptions = new CardinaisOptions()
                }
            },
            { Enums.Predefinicoes.Cardinais, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    NumeraisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        SepararClassesPorVirgula = true,
                        ZeroExplicitoParteInteira = false,
                        ZeroExplicitoParteDecimal = true,
                        DeveUsarConjuncaoDe = false,
                        ConjuncaoExplicitaSeParteInteiraVazia = true,
                        ParteInteiraSingular = "",
                        ParteInteiraPlural= "",
                        Conjuncao = "Vírgula",
                        ParteDecimalSingular = "",
                        ParteDecimalPlural = "",
                    }
                }
            },
            { Enums.Predefinicoes.Ordinais, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Ordinais,
                    NumeraisOptions = new OrdinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        SepararClassesPorVirgula = false,
                    }
                }
            },
            { Enums.Predefinicoes.MonetarioBRL, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    NumeraisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        SepararClassesPorVirgula = false,
                        ZeroExplicitoParteInteira = false,
                        ZeroExplicitoParteDecimal = false,
                        DeveUsarConjuncaoDe = true,
                        ConjuncaoExplicitaSeParteInteiraVazia = false,
                        ParteInteiraSingular = "Real",
                        ParteInteiraPlural= "Reais",
                        Conjuncao = "E",
                        ParteDecimalSingular = "Centavo",
                        ParteDecimalPlural = "Centavos",
                    }
                }
            },
            { Enums.Predefinicoes.Porcentagem, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    NumeraisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        SepararClassesPorVirgula = false,
                        ZeroExplicitoParteInteira = false,
                        ZeroExplicitoParteDecimal = true,
                        DeveUsarConjuncaoDe = false,
                        ConjuncaoExplicitaSeParteInteiraVazia = true,
                        ParteInteiraSingular = "",
                        ParteInteiraPlural= "",
                        Conjuncao = "Vírgula",
                        ParteDecimalSingular = "Por Cento",
                        ParteDecimalPlural = "Por Cento",
                    }
                }
            },
            { Enums.Predefinicoes.Romanos, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Romanos,
                }
            },
            { Enums.Predefinicoes.Metros, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    NumeraisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        SepararClassesPorVirgula = false,
                        ZeroExplicitoParteInteira = true,
                        ZeroExplicitoParteDecimal = true,
                        DeveUsarConjuncaoDe = true,
                        ConjuncaoExplicitaSeParteInteiraVazia = true,
                        ParteInteiraSingular = "",
                        ParteInteiraPlural= "",
                        Conjuncao = "Vírgula",
                        ParteDecimalSingular = "Metro",
                        ParteDecimalPlural = "Metros",
                    }
                }
            }
        };
    }
}
