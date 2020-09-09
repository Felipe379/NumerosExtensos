using NumerosExtensos.Enums;
using NumerosExtensos.Options;
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
                }
            },
            { Enums.Predefinicoes.Cardinais, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    CardinaisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        ZeroExplicitoAntesDaVirgula = false,
                        ZeroExplicitoDepoisDaVirgula = true,
                        DeveUsarConjuncaoDe = false,
                        AntesDaVirgulaSingular = "",
                        AntesDaVirgulaPlural= "",
                        Conector = "Vírgula",
                        DepoisDaVirgulaSingular = "",
                        DepoisDaVirgulaPlural = "",
                    }
                }
            },
            { Enums.Predefinicoes.Ordinais, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Ordinais,
                    OrdinaisOptions = new OrdinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                    }
                }
            },
            { Enums.Predefinicoes.MonetarioBRL, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    CardinaisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        ZeroExplicitoAntesDaVirgula = false,
                        ZeroExplicitoDepoisDaVirgula = false,
                        DeveUsarConjuncaoDe = true,
                        AntesDaVirgulaSingular = "Real",
                        AntesDaVirgulaPlural= "Reais",
                        Conector = "E",
                        DepoisDaVirgulaSingular = "Centavo",
                        DepoisDaVirgulaPlural = "Centavos",
                    }
                }
            },
            { Enums.Predefinicoes.Porcentagem, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    CardinaisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        ZeroExplicitoAntesDaVirgula = false,
                        ZeroExplicitoDepoisDaVirgula = true,
                        DeveUsarConjuncaoDe = false,
                        AntesDaVirgulaSingular = "",
                        AntesDaVirgulaPlural= "",
                        Conector = "Vírgula",
                        DepoisDaVirgulaSingular = "Por Cento",
                        DepoisDaVirgulaPlural = "Por Cento",
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
                    CardinaisOptions = new CardinaisOptions
                    {
                        DeveUsarExtensoFeminino = false,
                        ZeroExplicitoAntesDaVirgula = false,
                        ZeroExplicitoDepoisDaVirgula = true,
                        DeveUsarConjuncaoDe = true,
                        AntesDaVirgulaSingular = "",
                        AntesDaVirgulaPlural= "",
                        Conector = "Vírgula",
                        DepoisDaVirgulaSingular = "Metro",
                        DepoisDaVirgulaPlural = "Metros",
                    }
                }
            }
        };
    }
}
