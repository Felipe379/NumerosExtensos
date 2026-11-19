using NumerosExtensos;
using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Options.Numerais;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            cbo_Casing.PreencherCom<Casing>();
            cbo_Tipo.PreencherCom(TipoNumerais.Cardinais, TipoNumerais.Ordinais, TipoNumerais.Romanos);
            cbo_Presets.PreencherCom<Predefinicoes>();
        }

        private void BtnEscrever_Click(object sender, EventArgs e)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            var extensoOptions = new ExtensoOptions
            {
                Tipo = cbo_Tipo.SelectedItem is TipoNumerais tipo ? tipo : TipoNumerais.Cardinais,
            };

            if (extensoOptions.Tipo == TipoNumerais.Cardinais)
            {
                extensoOptions.NumeraisOptions = new CardinaisOptions
                {
                    DeveUsarExtensoFeminino = chk_ExtensoEmFeminino.Checked,
                    SepararClassesPorVirgula = chk_SepararClassesPorVirgula.Checked,
                    ZeroExplicitoParteInteira = chk_ZeroExplicitoParteInteira.Checked,
                    ZeroExplicitoParteDecimal = chk_ZeroExplicitoParteDecimal.Checked,
                    DeveUsarConjuncaoDe = chk_ConjuncaoDe.Checked,
                    ConjuncaoExplicitaSeParteInteiraVazia = chk_ConjuncaoExplicitaSeParteInteiraVazia.Checked,
                    UmMilExplicito = chk_UmMilExplicito.Checked,
                    ParteInteiraSingular = textInfo.ToTitleCase(txt_ParteInteiraSingular.Text.ToLower().Trim()),
                    ParteInteiraPlural = textInfo.ToTitleCase(txt_ParteInteiraPlural.Text.ToLower().Trim()),
                    Conjuncao = textInfo.ToTitleCase(txt_Conjuncao.Text.ToLower().Trim()),
                    ParteDecimalSingular = textInfo.ToTitleCase(txt_ParteDecimalSingular.Text.ToLower().Trim()),
                    ParteDecimalPlural = textInfo.ToTitleCase(txt_ParteDecimalPlural.Text.ToLower().Trim()),
                };
            }
            else if (extensoOptions.Tipo == TipoNumerais.Ordinais)
            {
                extensoOptions.NumeraisOptions = new OrdinaisOptions
                {
                    DeveUsarExtensoFeminino = chk_ExtensoEmFeminino.Checked,
                    SepararClassesPorVirgula = chk_SepararClassesPorVirgula.Checked,
                    Singular = textInfo.ToTitleCase(txt_ParteDecimalSingular.Text.ToLower().Trim())
                };
            }

            try
            {
                var extenso = new Extenso();
                var escrever = extenso.Escrever(extensoOptions);
                var numeroPorExtenso = escrever.Numero(txt_Numero.Text.Trim());

                if (!string.IsNullOrWhiteSpace(numeroPorExtenso) && cbo_Casing.SelectedItem is Casing casing)
                {
                    numeroPorExtenso = casing switch
                    {
                        Casing.Uppercase => numeroPorExtenso.ToUpper(),
                        Casing.Lowercase => numeroPorExtenso.ToLower(),
                        Casing.Frase => char.ToUpperInvariant(numeroPorExtenso[0]) + numeroPorExtenso.Substring(1).ToLower(),
                        _ => numeroPorExtenso // Pascalcase: o Escrever já devolve nesse formato
                    };
                }

                txt_NumeroPorExtenso.Text = numeroPorExtenso;
            }
            catch (Exception ex)
            {
                txt_NumeroPorExtenso.Text = ex.ToString();
            }
        }

        private void CboPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Presets.SelectedItem is not Predefinicoes tipoPredefinicao)
                return;

            var predefinicao = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao];

            if (predefinicao.Tipo == TipoNumerais.Cardinais)
            {
                if (predefinicao.NumeraisOptions is CardinaisOptions cardinaisOptions)
                {
                    cbo_Tipo.SelectedItem = TipoNumerais.Cardinais;
                    chk_ExtensoEmFeminino.Checked = cardinaisOptions.DeveUsarExtensoFeminino;
                    chk_ZeroExplicitoParteInteira.Checked = cardinaisOptions.ZeroExplicitoParteInteira;
                    chk_ZeroExplicitoParteDecimal.Checked = cardinaisOptions.ZeroExplicitoParteDecimal;
                    chk_SepararClassesPorVirgula.Checked = cardinaisOptions.SepararClassesPorVirgula;
                    chk_ConjuncaoDe.Checked = cardinaisOptions.DeveUsarConjuncaoDe;
                    chk_ConjuncaoExplicitaSeParteInteiraVazia.Checked = cardinaisOptions.ConjuncaoExplicitaSeParteInteiraVazia;
                    chk_UmMilExplicito.Checked = cardinaisOptions.UmMilExplicito;
                    txt_ParteInteiraSingular.Text = cardinaisOptions.ParteInteiraSingular;
                    txt_ParteInteiraPlural.Text = cardinaisOptions.ParteInteiraPlural;
                    txt_Conjuncao.Text = cardinaisOptions.Conjuncao;
                    txt_ParteDecimalSingular.Text = cardinaisOptions.ParteDecimalSingular;
                    txt_ParteDecimalPlural.Text = cardinaisOptions.ParteDecimalPlural;
                }
                else
                {
                    txt_NumeroPorExtenso.Text = "NumeraisOptions não é um objeto do tipo esperado.";
                }
            }
            else if (predefinicao.Tipo == TipoNumerais.Ordinais)
            {
                if (predefinicao.NumeraisOptions is OrdinaisOptions ordinaisOptions)
                {
                    cbo_Tipo.SelectedItem = TipoNumerais.Ordinais;
                    chk_ExtensoEmFeminino.Checked = ordinaisOptions.DeveUsarExtensoFeminino;
                    chk_SepararClassesPorVirgula.Checked = ordinaisOptions.SepararClassesPorVirgula;
                    txt_ParteDecimalSingular.Text = ordinaisOptions.Singular;
                }
                else
                {
                    txt_NumeroPorExtenso.Text = "NumeraisOptions não é um objeto do tipo esperado.";
                }
            }
            else if (predefinicao.Tipo == TipoNumerais.Romanos)
            {
                cbo_Tipo.SelectedItem = TipoNumerais.Romanos;
            }
        }

        private void CboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = cbo_Tipo.SelectedItem is TipoNumerais selecionado ? selecionado : TipoNumerais.Cardinais;

            if (tipo == TipoNumerais.Cardinais)
            {
                chk_ExtensoEmFeminino.Enabled = true;
                chk_SepararClassesPorVirgula.Enabled = true;
                chk_ZeroExplicitoParteInteira.Enabled = true;
                chk_ZeroExplicitoParteDecimal.Enabled = true;
                chk_ConjuncaoDe.Enabled = true;
                chk_ConjuncaoExplicitaSeParteInteiraVazia.Enabled = true;
                chk_UmMilExplicito.Enabled = true;
                txt_Conjuncao.Enabled = true;
                txt_ParteInteiraSingular.Enabled = true;
                txt_ParteInteiraPlural.Enabled = true;
                txt_ParteDecimalSingular.Enabled = true;
                txt_ParteDecimalPlural.Enabled = true;
            }
            else if (tipo == TipoNumerais.Ordinais)
            {
                chk_ExtensoEmFeminino.Enabled = true;
                chk_SepararClassesPorVirgula.Enabled = true;
                chk_ZeroExplicitoParteInteira.Enabled = false;
                chk_ZeroExplicitoParteDecimal.Enabled = false;
                chk_ConjuncaoDe.Enabled = false;
                chk_ConjuncaoExplicitaSeParteInteiraVazia.Enabled = false;
                chk_UmMilExplicito.Enabled = false;
                txt_Conjuncao.Enabled = false;
                txt_ParteInteiraSingular.Enabled = false;
                txt_ParteInteiraPlural.Enabled = false;
                txt_ParteDecimalSingular.Enabled = true;
                txt_ParteDecimalPlural.Enabled = false;
            }
            else
            {
                chk_ExtensoEmFeminino.Enabled = false;
                chk_SepararClassesPorVirgula.Enabled = false;
                chk_ZeroExplicitoParteInteira.Enabled = false;
                chk_ZeroExplicitoParteDecimal.Enabled = false;
                chk_ConjuncaoDe.Enabled = false;
                chk_ConjuncaoExplicitaSeParteInteiraVazia.Enabled = false;
                chk_UmMilExplicito.Enabled = false;
                txt_Conjuncao.Enabled = false;
                txt_ParteInteiraSingular.Enabled = false;
                txt_ParteInteiraPlural.Enabled = false;
                txt_ParteDecimalSingular.Enabled = false;
                txt_ParteDecimalPlural.Enabled = false;
            }
        }
    }
}
