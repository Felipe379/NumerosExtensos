using System;
using System.Collections.Generic;
using System.Text;

namespace NumerosExtensos
{
    public class ExtensoOptions
    {
        // Fonte: https://pt.wikipedia.org/wiki/Numerais_em_l%C3%ADngua_portuguesa
        public enum TipoNumerais
        {
            Cardinais,
            Ordinais,
            Multiplicativos,
            Fracionarios,
            Coletivos,
            Romanos
        }

        public TipoNumerais Tipo;
        public bool DeveUsarExtensoFeminino;
        public bool DeveUsarPrefixoDe;
        public bool ZeroExplicitoAntesDaVirgula;
        public bool ZeroExplicitoDepoisDaVirgula;
        public string AntesDaVirgulaSingular;
        public string AntesDaVirgulaPlural;
        public string Conector;
        public string DepoisDaVirgulaSingular;
        public string DepoisDaVirgulaPlural;
    }
}
