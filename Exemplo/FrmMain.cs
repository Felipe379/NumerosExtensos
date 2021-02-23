using NumerosExtensos.Enums;
using NumerosExtensos.Options.Numerais;
using NumerosExtensos.Options;
using NumerosExtensos;
using System.Globalization;
using System.Windows.Forms;
using System;

namespace Exemplo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            cbo_Casing.Items.AddRange(new[] { "Uppercase", "Lowercase", "Frase", "Pascalcase" });
            cbo_Tipo.Items.AddRange(new[] { "Cardinal", "Ordinal", "Romano" });
            cbo_Presets.Items.AddRange(new[] { "Nenhum", "Números Cardinais", "Números Ordinais", "Números Romanos", "Monetário BRL", "Porcentagem", "Metros" });

            cbo_Casing.SelectedIndex = 0;
            cbo_Tipo.SelectedIndex = 0;
            cbo_Presets.SelectedIndex = 0;
        }

        private void btn_Escrever_Click(object sender, EventArgs e)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            var extensoOptions = new ExtensoOptions
            {
                Tipo = ObtemTipoNumeral(),
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
                var extenso = new Extenso(extensoOptions);
                var numeroPorExtenso = extenso.EscreverNumero(txt_Numero.Text.Trim());

                if (!string.IsNullOrWhiteSpace(numeroPorExtenso))
                {
                    if (cbo_Casing.SelectedIndex == 0)
                        numeroPorExtenso = numeroPorExtenso.ToUpper();
                    else if (cbo_Casing.SelectedIndex == 1)
                        numeroPorExtenso = numeroPorExtenso.ToLower();
                    else if (cbo_Casing.SelectedIndex == 2)
                        numeroPorExtenso = char.ToUpperInvariant(numeroPorExtenso[0]) + numeroPorExtenso.Substring(1).ToLower();
                }

                txt_NumeroPorExtenso.Text = numeroPorExtenso;
            }
            catch (Exception ex)
            {
                txt_NumeroPorExtenso.Text = ex.ToString();
            }
        }

        private void cbo_Presets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoPredefinicao = ObtemTipoPreset(cbo_Presets.SelectedIndex);

            if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].Tipo == TipoNumerais.Cardinais)
            {
                if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].NumeraisOptions is CardinaisOptions)
                {
                    var cardinaisOptions = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].NumeraisOptions as CardinaisOptions;

                    cbo_Tipo.SelectedIndex = 0;
                    chk_ExtensoEmFeminino.Checked = cardinaisOptions.DeveUsarExtensoFeminino;
                    chk_ZeroExplicitoParteInteira.Checked = cardinaisOptions.ZeroExplicitoParteInteira;
                    chk_ZeroExplicitoParteDecimal.Checked = cardinaisOptions.ZeroExplicitoParteDecimal;
                    chk_SepararClassesPorVirgula.Checked = cardinaisOptions.SepararClassesPorVirgula;
                    chk_ConjuncaoDe.Checked = cardinaisOptions.DeveUsarConjuncaoDe;
                    chk_ConjuncaoExplicitaSeParteInteiraVazia.Checked = cardinaisOptions.ConjuncaoExplicitaSeParteInteiraVazia;
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
            else if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].Tipo == TipoNumerais.Ordinais)
            {
                if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].NumeraisOptions is OrdinaisOptions)
                {
                    var ordinaisOptions = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].NumeraisOptions as OrdinaisOptions;

                    cbo_Tipo.SelectedIndex = 1;
                    chk_ExtensoEmFeminino.Checked = ordinaisOptions.DeveUsarExtensoFeminino;
                    chk_SepararClassesPorVirgula.Checked = ordinaisOptions.SepararClassesPorVirgula;
                    txt_ParteDecimalSingular.Text = ordinaisOptions.Singular;
                }
                else
                {
                    txt_NumeroPorExtenso.Text = "NumeraisOptions não é um objeto do tipo esperado.";
                }
            }
            else if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].Tipo == TipoNumerais.Romanos)
            {
                cbo_Tipo.SelectedIndex = 2;
            }
        }

        private Predefinicoes ObtemTipoPreset(int cboIndex)
        {
            return cboIndex switch
            {
                1 => Predefinicoes.Cardinais,
                2 => Predefinicoes.Ordinais,
                3 => Predefinicoes.Romanos,
                4 => Predefinicoes.MonetarioBRL,
                5 => Predefinicoes.Porcentagem,
                6 => Predefinicoes.Metros,
                _ => Predefinicoes.Nenhum
            };
        }

        private void cbo_Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtemTipoNumeral();
        }

        private TipoNumerais ObtemTipoNumeral()
        {
            if (cbo_Tipo.SelectedIndex == 0)
            {
                chk_ExtensoEmFeminino.Enabled = true;
                chk_SepararClassesPorVirgula.Enabled = true;
                chk_ZeroExplicitoParteInteira.Enabled = true;
                chk_ZeroExplicitoParteDecimal.Enabled = true;
                chk_ConjuncaoDe.Enabled = true;
                chk_ConjuncaoExplicitaSeParteInteiraVazia.Enabled = true;
                txt_Conjuncao.Enabled = true;
                txt_ParteInteiraSingular.Enabled = true;
                txt_ParteInteiraPlural.Enabled = true;
                txt_ParteDecimalSingular.Enabled = true;
                txt_ParteDecimalPlural.Enabled = true;
                return TipoNumerais.Cardinais;
            }
            else if (cbo_Tipo.SelectedIndex == 1)
            {
                chk_ExtensoEmFeminino.Enabled = true;
                chk_SepararClassesPorVirgula.Enabled = true;
                chk_ZeroExplicitoParteInteira.Enabled = false;
                chk_ZeroExplicitoParteDecimal.Enabled = false;
                chk_ConjuncaoDe.Enabled = false;
                chk_ConjuncaoExplicitaSeParteInteiraVazia.Enabled = false;
                txt_Conjuncao.Enabled = false;
                txt_ParteInteiraSingular.Enabled = false;
                txt_ParteInteiraPlural.Enabled = false;
                txt_ParteDecimalSingular.Enabled = true;
                txt_ParteDecimalPlural.Enabled = false;
                return TipoNumerais.Ordinais;
            }
            else
            {
                chk_ExtensoEmFeminino.Enabled = false;
                chk_SepararClassesPorVirgula.Enabled = false;
                chk_ZeroExplicitoParteInteira.Enabled = false;
                chk_ZeroExplicitoParteDecimal.Enabled = false;
                chk_ConjuncaoDe.Enabled = false;
                chk_ConjuncaoExplicitaSeParteInteiraVazia.Enabled = false;
                txt_Conjuncao.Enabled = false;
                txt_ParteInteiraSingular.Enabled = false;
                txt_ParteInteiraPlural.Enabled = false;
                txt_ParteDecimalSingular.Enabled = false;
                txt_ParteDecimalPlural.Enabled = false;
                return TipoNumerais.Romanos;
            }
        }
    }
}
