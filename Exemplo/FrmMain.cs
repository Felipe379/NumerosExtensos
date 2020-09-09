using NumerosExtensos;
using NumerosExtensos.Enums;
using System;
using System.Windows.Forms;
using System.Globalization;
using NumerosExtensos.Options;

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
                extensoOptions.CardinaisOptions = new CardinaisOptions
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
                extensoOptions.OrdinaisOptions = new OrdinaisOptions
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
                rdb_Cardinal.Checked = true;
                chk_ExtensoEmFeminino.Checked = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.DeveUsarExtensoFeminino;
                chk_ZeroExplicitoAntesDaVirgula.Checked = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.ZeroExplicitoAntesDaVirgula;
                chk_ZeroExplicitoDepoisDaVirgula.Checked = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.ZeroExplicitoDepoisDaVirgula;
                chk_ConjuncaoDe.Checked = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.DeveUsarConjuncaoDe;
                txt_AntesDaVirgulaSingular.Text = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.AntesDaVirgulaSingular;
                txt_AntesDaVirgulaPlural.Text = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.AntesDaVirgulaPlural;
                txt_Conector.Text = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.Conector;
                txt_DepoisDaVirgulaSingular.Text = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.DepoisDaVirgulaSingular;
                txt_DepoisDaVirgulaPlural.Text = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].CardinaisOptions.DepoisDaVirgulaPlural;
            }
            else if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].Tipo == TipoNumerais.Ordinais)
            {
                rdb_Ordinal.Checked = true;
                chk_ExtensoEmFeminino.Checked = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].OrdinaisOptions.DeveUsarExtensoFeminino;
                txt_DepoisDaVirgulaSingular.Text = OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].OrdinaisOptions.Singular;
            }
            else if (OpcoesPredefinidas.Predefinicoes[tipoPredefinicao].Tipo == TipoNumerais.Romanos)
                rdb_Romano.Checked = true;
        }

        private Predefinicoes ObtemTipoPreset(int cboIndex)
        {
            switch (cboIndex)
            {
                case 1:
                    return Predefinicoes.Cardinais;
                case 2:
                    return Predefinicoes.Ordinais;
                case 3:
                    return Predefinicoes.Romanos;
                case 4:
                    return Predefinicoes.MonetarioBRL;
                case 5:
                    return Predefinicoes.Porcentagem;
                case 6:
                    return Predefinicoes.Metros;
                default:
                    return Predefinicoes.Nenhum;
            }
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
