using NumerosExtensos.Enums;
using System.Collections.Generic;

namespace NumerosExtensos
{
    public class PresetOptions
    {
        public static readonly Dictionary<Preset, ExtensoOptions> Presets = new Dictionary<Preset, ExtensoOptions>
        {
            { Preset.Nenhum, new ExtensoOptions
                {
                    Tipo = default,
                    DeveUsarExtensoFeminino = false,
                    ZeroExplicitoAntesDaVirgula = false,
                    ZeroExplicitoDepoisDaVirgula = false,
                    DeveUsarPrefixoDe = false,
                    AntesDaVirgulaSingular = "",
                    AntesDaVirgulaPlural= "",
                    Conector = "",
                    DepoisDaVirgulaSingular = "",
                    DepoisDaVirgulaPlural = "",
                }
            },
            { Preset.Cardinal, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    DeveUsarExtensoFeminino = false,
                    ZeroExplicitoAntesDaVirgula = false,
                    ZeroExplicitoDepoisDaVirgula = true,
                    DeveUsarPrefixoDe = false,
                    AntesDaVirgulaSingular = "",
                    AntesDaVirgulaPlural= "",
                    Conector = "Vírgula",
                    DepoisDaVirgulaSingular = "",
                    DepoisDaVirgulaPlural = "",
                }
            },
            { Preset.Ordinal, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Ordinais,
                    DeveUsarExtensoFeminino = false,
                }
            },
            { Preset.MonetarioBRL, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    DeveUsarExtensoFeminino = false,
                    ZeroExplicitoAntesDaVirgula = false,
                    ZeroExplicitoDepoisDaVirgula = false,
                    DeveUsarPrefixoDe = true,
                    AntesDaVirgulaSingular = "Real",
                    AntesDaVirgulaPlural= "Reais",
                    Conector = "E",
                    DepoisDaVirgulaSingular = "Centavo",
                    DepoisDaVirgulaPlural = "Centavos",
                }
            },
            { Preset.Porcentagem, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    DeveUsarExtensoFeminino = false,
                    ZeroExplicitoAntesDaVirgula = false,
                    ZeroExplicitoDepoisDaVirgula = true,
                    DeveUsarPrefixoDe = false,
                    AntesDaVirgulaSingular = "",
                    AntesDaVirgulaPlural= "",
                    Conector = "Vírgula",
                    DepoisDaVirgulaSingular = "Por Cento",
                    DepoisDaVirgulaPlural = "Por Cento",
                }
            },
            { Preset.Romanos, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Romanos,
                    DeveUsarExtensoFeminino = false,
                    ZeroExplicitoAntesDaVirgula = false,
                    ZeroExplicitoDepoisDaVirgula = false,
                    DeveUsarPrefixoDe = false,
                    AntesDaVirgulaSingular = "",
                    AntesDaVirgulaPlural= "",
                    Conector = "",
                    DepoisDaVirgulaSingular = "",
                    DepoisDaVirgulaPlural = "",
                }
            },
            { Preset.Metro, new ExtensoOptions
                {
                    Tipo = TipoNumerais.Cardinais,
                    DeveUsarExtensoFeminino = false,
                    ZeroExplicitoAntesDaVirgula = false,
                    ZeroExplicitoDepoisDaVirgula = true,
                    DeveUsarPrefixoDe = false,
                    AntesDaVirgulaSingular = "",
                    AntesDaVirgulaPlural= "",
                    Conector = "Vírgula",
                    DepoisDaVirgulaSingular = "Metro",
                    DepoisDaVirgulaPlural = "Metros",
                }
            }
        };
    }
}
