﻿namespace NumerosExtensos.Options.Numerais
{
    /// <summary>
    /// Define as opções para o tipo de numeral cardinal.
    /// </summary>
    public class CardinaisOptions : NumeraisOptions
    {
        /// <summary>
        /// Define se deve utilizar a conjunção "DE" entre o número escrito e a parte escrita (singular ou plural).
        /// <br />
        /// Exemplo: 3000000 -> Três milhões DE reais.
        /// </summary>
        public bool DeveUsarConjuncaoDe { get; set; }

        /// <summary>
        /// Define se deve escrever zeros explicitamente na parte inteira.
        /// <br />
        /// Exemplo: 045 -> ZERO quarenta e cinco.
        /// </summary>
        public bool ZeroExplicitoParteInteira { get; set; }

        /// <summary>
        /// Define se deve escrever zeros explicitamente na parte decimal.
        /// <br />
        /// Exemplo: 1.045 -> Um vírgula ZERO quarenta e cinco.
        /// </summary>
        public bool ZeroExplicitoParteDecimal { get; set; }

        /// <summary>
        /// Define se deve escrever o valor que foi definido em "Conjuncao" mesmo que a parte inteira esteja vazia.
        /// <br />
        /// Exemplo: .21 -> VÍRGULA vinte e um.
        /// </summary>
        public bool ConjuncaoExplicitaSeParteInteiraVazia { get; set; }

        /// <summary>
        /// Define se deve escrever valores de 1000 explicitamente.
        /// <br />
        /// Exemplo: 1005 -> UM MIL e cinco.
        /// </summary>
        public bool UmMilExplicito { get; set; }

        /// <summary>
        /// Define o que deve ser escrito após o valor inteiro caso este esteja no singular.
        /// <br />
        /// Exemplo: 1 -> Um REAL
        /// </summary>
        public string ParteInteiraSingular { get; set; }

        /// <summary>
        /// Define o que deve ser escrito após o valor inteiro caso este esteja no plural.
        /// <br />
        /// Exemplo: 1000 -> Mil REAIS
        /// </summary>
        public string ParteInteiraPlural { get; set; }

        /// <summary>
        /// Define o que deve ser escrito na conjunção.
        /// <br />
        /// Exemplo: 1.5 -> Um VÍRGULA cinco por cento.
        /// </summary>
        public string Conjuncao { get; set; }

        /// <summary>
        /// Define o que deve ser escrito após o valor decimal caso este esteja no singular.
        /// <br />
        /// Exemplo: 0.01 -> Zero real vírgula um CENTAVO.
        /// </summary>
        public string ParteDecimalSingular { get; set; }

        /// <summary>
        /// Define o que deve ser escrito após o valor decimal caso este esteja no plural.
        /// <br />
        /// Exemplo: 1.11 -> Um real vírgula onze CENTAVOS.
        /// </summary>
        public string ParteDecimalPlural { get; set; }
    }
}
