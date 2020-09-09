using NumerosExtensos;
using NumerosExtensos.Enums;
using System;
using System.Windows.Forms;
using System.Globalization;

namespace Exemplo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            cbo_Presets.Items.Add("Nenhum");
            cbo_Presets.Items.Add("Número Cardinal");
            cbo_Presets.Items.Add("Número Ordinal");
            cbo_Presets.Items.Add("Número Romano");
            cbo_Presets.Items.Add("Real");
            cbo_Presets.Items.Add("Porcentagem");
            cbo_Presets.Items.Add("Metro");

            cbo_Presets.SelectedIndex = 0;
        }

        private void btn_Escrever_Click(object sender, EventArgs e)
        {
            var extensoOptions = new ExtensoOptions
            {
                Tipo = ObtemTipoNumeral(),
                DeveUsarExtensoFeminino = chk_ExtensoEmFeminino.Checked,
                ZeroExplicitoAntesDaVirgula = chk_ZeroExplicitoAntesDaVirgula.Checked,
                ZeroExplicitoDepoisDaVirgula = chk_ZeroExplicitoDepoisDaVirgula.Checked,
                DeveUsarConjuncaoDe = chk_ConjuncaoDe.Checked,
                AntesDaVirgulaSingular = txt_AntesDaVirgulaSingular.Text.ToLower().Trim(),
                AntesDaVirgulaPlural = txt_AntesDaVirgulaPlural.Text.ToLower().Trim(),
                Conector = txt_Conector.Text.ToLower().Trim(),
                DepoisDaVirgulaSingular = txt_DepoisDaVirgulaSingular.Text.ToLower().Trim(),
                DepoisDaVirgulaPlural = txt_DepoisDaVirgulaPlural.Text.ToLower().Trim(),
            };

            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            extensoOptions.AntesDaVirgulaSingular = textInfo.ToTitleCase(extensoOptions.AntesDaVirgulaSingular);
            extensoOptions.AntesDaVirgulaPlural = textInfo.ToTitleCase(extensoOptions.AntesDaVirgulaPlural);
            extensoOptions.DepoisDaVirgulaSingular = textInfo.ToTitleCase(extensoOptions.DepoisDaVirgulaSingular);
            extensoOptions.DepoisDaVirgulaPlural = textInfo.ToTitleCase(extensoOptions.DepoisDaVirgulaPlural);
            extensoOptions.Conector = textInfo.ToTitleCase(extensoOptions.Conector);

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
            var tipoPreset = ObtemTipoPreset(cbo_Presets.SelectedIndex);

            if (PresetOptions.Presets[tipoPreset].Tipo == TipoNumerais.Cardinais)
                rdb_Cardinal.Checked = true;
            else if (PresetOptions.Presets[tipoPreset].Tipo == TipoNumerais.Ordinais)
                rdb_Ordinal.Checked = true;
            else if (PresetOptions.Presets[tipoPreset].Tipo == TipoNumerais.Romanos)
                rdb_Romano.Checked = true;

            chk_ExtensoEmFeminino.Checked = PresetOptions.Presets[tipoPreset].DeveUsarExtensoFeminino;
            chk_ZeroExplicitoAntesDaVirgula.Checked = PresetOptions.Presets[tipoPreset].ZeroExplicitoAntesDaVirgula;
            chk_ZeroExplicitoDepoisDaVirgula.Checked = PresetOptions.Presets[tipoPreset].ZeroExplicitoDepoisDaVirgula;
            chk_ConjuncaoDe.Checked = PresetOptions.Presets[tipoPreset].DeveUsarConjuncaoDe;
            txt_AntesDaVirgulaSingular.Text = PresetOptions.Presets[tipoPreset].AntesDaVirgulaSingular;
            txt_AntesDaVirgulaPlural.Text = PresetOptions.Presets[tipoPreset].AntesDaVirgulaPlural;
            txt_Conector.Text = PresetOptions.Presets[tipoPreset].Conector;
            txt_DepoisDaVirgulaSingular.Text = PresetOptions.Presets[tipoPreset].DepoisDaVirgulaSingular;
            txt_DepoisDaVirgulaPlural.Text = PresetOptions.Presets[tipoPreset].DepoisDaVirgulaPlural;
        }

        private Preset ObtemTipoPreset(int cboIndex)
        {
            switch (cboIndex)
            {
                case 1:
                    return Preset.Cardinal;
                case 2:
                    return Preset.Ordinal;
                case 3:
                    return Preset.Romanos;
                case 4:
                    return Preset.MonetarioBRL;
                case 5:
                    return Preset.Porcentagem;
                case 6:
                    return Preset.Metro;
                default:
                    return Preset.Nenhum;
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
                txt_DepoisDaVirgulaPlural.Enabled = true;
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
