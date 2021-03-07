namespace NumerosExtensos.Options.Numerais
{
    public class CardinaisOptions : NumeraisOptions
    {
        public bool DeveUsarConjuncaoDe { get; set; }
        public bool ZeroExplicitoParteInteira { get; set; }
        public bool ZeroExplicitoParteDecimal { get; set; }
        public bool ConjuncaoExplicitaSeParteInteiraVazia { get; set; }
        public bool UmMilExplicito { get; set; }
        public string ParteInteiraSingular { get; set; }
        public string ParteInteiraPlural { get; set; }
        public string Conjuncao { get; set; }
        public string ParteDecimalSingular { get; set; }
        public string ParteDecimalPlural { get; set; }
    }
}
