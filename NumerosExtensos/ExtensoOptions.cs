using NumerosExtensos.Enums;

namespace NumerosExtensos
{
    public class ExtensoOptions
    {
        public TipoNumerais Tipo { get; set; }
        public bool DeveUsarExtensoFeminino { get; set; }
        public bool DeveUsarPrefixoDe { get; set; }
        public bool ZeroExplicitoAntesDaVirgula { get; set; }
        public bool ZeroExplicitoDepoisDaVirgula { get; set; }
        public string AntesDaVirgulaSingular { get; set; }
        public string AntesDaVirgulaPlural { get; set; }
        public string Conector { get; set; }
        public string DepoisDaVirgulaSingular { get; set; }
        public string DepoisDaVirgulaPlural { get; set; }
    }
}
