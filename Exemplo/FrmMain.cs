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
            cbo_Presets.Items.Add("Nenhum");
            cbo_Presets.Items.Add("Números Cardinais");
            cbo_Presets.Items.Add("Números Ordinais");
            cbo_Presets.Items.Add("Números Romanos");
            cbo_Presets.Items.Add("Monetário BRL");
            cbo_Presets.Items.Add("Porcentagem");
            cbo_Presets.Items.Add("Metros");

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
                    ZeroExplicitoAntesDaVirgula = chk_ZeroExplicitoAntesDaVirgula.Checked,
                    ZeroExplicitoDepoisDaVirgula = chk_ZeroExplicitoDepoisDaVirgula.Checked,
                    DeveUsarConjuncaoDe = chk_ConjuncaoDe.Checked,
                    AntesDaVirgulaSingular = textInfo.ToTitleCase(txt_AntesDaVirgulaSingular.Text.ToLower().Trim()),
                    AntesDaVirgulaPlural = textInfo.ToTitleCase(txt_AntesDaVirgulaPlural.Text.ToLower().Trim()),
                    Conector = textInfo.ToTitleCase(txt_Conector.Text.ToLower().Trim()),
                    DepoisDaVirgulaSingular = textInfo.ToTitleCase(txt_DepoisDaVirgulaSingular.Text.ToLower().Trim()),
                    DepoisDaVirgulaPlural = textInfo.ToTitleCase(txt_DepoisDaVirgulaPlural.Text.ToLower().Trim()),
                };
            }
            else if (extensoOptions.Tipo == TipoNumerais.Ordinais)
            {
                extensoOptions.NumeraisOptions = new OrdinaisOptions
                {
                    DeveUsarExtensoFeminino = chk_ExtensoEmFeminino.Checked,
                    Singular = textInfo.ToTitleCase(txt_DepoisDaVirgulaSingular.Text.ToLower().Trim())
                };
            }

            try
            {
                var extenso = new Extenso(extensoOptions);
                var numeroPorExtenso = extenso.EscreverNumero(txt_Numero.Text.Trim());

                if (!string.IsNullOrWhiteSpace(numeroPorExtenso))
                {
                    if (rdb_Lowercase.Checked)
                        numeroPorExtenso = numeroPorExtenso.ToLower();
                    else if (rdb_Uppercase.Checked)
                        numeroPorExtenso = numeroPorExtenso.ToUpper();
                    else if (rdb_Frase.Checked)
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

                    rdb_Cardinal.Checked = true;
                    chk_ExtensoEmFeminino.Checked = cardinaisOptions.DeveUsarExtensoFeminino;
                    chk_ZeroExplicitoAntesDaVirgula.Checked = cardinaisOptions.ZeroExplicitoAntesDaVirgula;
                    chk_ZeroExplicitoDepoisDaVirgula.Checked = cardinaisOptions.ZeroExplicitoDepoisDaVirgula;
                    chk_ConjuncaoDe.Checked = cardinaisOptions.DeveUsarConjuncaoDe;
                    txt_AntesDaVirgulaSingular.Text = cardinaisOptions.AntesDaVirgulaSingular;
                    txt_AntesDaVirgulaPlural.Text = cardinaisOptions.AntesDaVirgulaPlural;
                    txt_Conector.Text = cardinaisOptions.Conector;
                    txt_DepoisDaVirgulaSingular.Text = cardinaisOptions.DepoisDaVirgulaSingular;
                    txt_DepoisDaVirgulaPlural.Text = cardinaisOptions.DepoisDaVirgulaPlural;
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

                    rdb_Ordinal.Checked = true;
                    chk_ExtensoEmFeminino.Checked = ordinaisOptions.DeveUsarExtensoFeminino;
                    txt_DepoisDaVirgulaSingular.Text = ordinaisOptions.Singular;
                }
                else
                {
                    txt_NumeroPorExtenso.Text = "NumeraisOptions não é um objeto do tipo esperado.";
                }
            }
            else if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].Tipo == TipoNumerais.Romanos)
            {
                rdb_Romano.Checked = true;
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

        private void rdb_Cardinal_CheckedChanged(object sender, EventArgs e)
        {
            ObtemTipoNumeral();
        }

        private void rdb_Ordinal_CheckedChanged(object sender, EventArgs e)
        {
            ObtemTipoNumeral();
        }

        private void rdb_Romano_CheckedChanged(object sender, EventArgs e)
        {
            ObtemTipoNumeral();
        }

        private TipoNumerais ObtemTipoNumeral()
        {
            if (rdb_Ordinal.Checked)
            {
                chk_ExtensoEmFeminino.Enabled = true;
                chk_ZeroExplicitoAntesDaVirgula.Enabled = false;
                chk_ZeroExplicitoDepoisDaVirgula.Enabled = false;
                chk_ConjuncaoDe.Enabled = false;
                txt_Conector.Enabled = false;
                txt_AntesDaVirgulaSingular.Enabled = false;
                txt_AntesDaVirgulaPlural.Enabled = false;
                txt_DepoisDaVirgulaSingular.Enabled = true;
                txt_DepoisDaVirgulaPlural.Enabled = false;
                return TipoNumerais.Ordinais;
            }
            else if (rdb_Cardinal.Checked)
            {
                chk_ExtensoEmFeminino.Enabled = true;
                chk_ZeroExplicitoAntesDaVirgula.Enabled = true;
                chk_ZeroExplicitoDepoisDaVirgula.Enabled = true;
                chk_ConjuncaoDe.Enabled = true;
                txt_Conector.Enabled = true;
                txt_AntesDaVirgulaSingular.Enabled = true;
                txt_AntesDaVirgulaPlural.Enabled = true;
                txt_DepoisDaVirgulaSingular.Enabled = true;
                txt_DepoisDaVirgulaPlural.Enabled = true;
                return TipoNumerais.Cardinais;
            }
            else
            {
                chk_ExtensoEmFeminino.Enabled = false;
                chk_ZeroExplicitoAntesDaVirgula.Enabled = false;
                chk_ZeroExplicitoDepoisDaVirgula.Enabled = false;
                chk_ConjuncaoDe.Enabled = false;
                txt_Conector.Enabled = false;
                txt_AntesDaVirgulaSingular.Enabled = false;
                txt_AntesDaVirgulaPlural.Enabled = false;
                txt_DepoisDaVirgulaSingular.Enabled = false;
                txt_DepoisDaVirgulaPlural.Enabled = false;
                return TipoNumerais.Romanos;
            }
        }

    }
}
