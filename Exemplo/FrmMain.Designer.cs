namespace Exemplo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Escrever = new System.Windows.Forms.Button();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_NumeroPorExtenso = new System.Windows.Forms.TextBox();
            this.txt_AntesDaVirgulaSingular = new System.Windows.Forms.TextBox();
            this.txt_AntesDaVirgulaPlural = new System.Windows.Forms.TextBox();
            this.txt_Conector = new System.Windows.Forms.TextBox();
            this.txt_DepoisDaVirgulaSingular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DepoisDaVirgulaPlural = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_ZeroExplicitoAntesDaVirgula = new System.Windows.Forms.CheckBox();
            this.chk_ZeroExplicitoDepoisDaVirgula = new System.Windows.Forms.CheckBox();
            this.chk_ExtensoEmFeminino = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Presets = new System.Windows.Forms.ComboBox();
            this.chk_PrefixoDe = new System.Windows.Forms.CheckBox();
            this.grpb_casing = new System.Windows.Forms.GroupBox();
            this.rdb_Frase = new System.Windows.Forms.RadioButton();
            this.rdb_Uppercase = new System.Windows.Forms.RadioButton();
            this.rdb_Lowercase = new System.Windows.Forms.RadioButton();
            this.rdb_Pascalcase = new System.Windows.Forms.RadioButton();
            this.rdb_Ordinal = new System.Windows.Forms.RadioButton();
            this.rdb_Cardinal = new System.Windows.Forms.RadioButton();
            this.grpb_tipo = new System.Windows.Forms.GroupBox();
            this.rdb_Romano = new System.Windows.Forms.RadioButton();
            this.grpb_casing.SuspendLayout();
            this.grpb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Escrever
            // 
            this.btn_Escrever.Location = new System.Drawing.Point(518, 10);
            this.btn_Escrever.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Escrever.Name = "btn_Escrever";
            this.btn_Escrever.Size = new System.Drawing.Size(290, 27);
            this.btn_Escrever.TabIndex = 0;
            this.btn_Escrever.Text = "Escrever";
            this.btn_Escrever.UseVisualStyleBackColor = true;
            this.btn_Escrever.Click += new System.EventHandler(this.btn_Escrever_Click);
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(14, 14);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Numero.MaxLength = 134;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Numero.Size = new System.Drawing.Size(489, 23);
            this.txt_Numero.TabIndex = 1;
            // 
            // txt_NumeroPorExtenso
            // 
            this.txt_NumeroPorExtenso.Location = new System.Drawing.Point(14, 55);
            this.txt_NumeroPorExtenso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_NumeroPorExtenso.Multiline = true;
            this.txt_NumeroPorExtenso.Name = "txt_NumeroPorExtenso";
            this.txt_NumeroPorExtenso.ReadOnly = true;
            this.txt_NumeroPorExtenso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_NumeroPorExtenso.Size = new System.Drawing.Size(489, 350);
            this.txt_NumeroPorExtenso.TabIndex = 2;
            // 
            // txt_AntesDaVirgulaSingular
            // 
            this.txt_AntesDaVirgulaSingular.Location = new System.Drawing.Point(663, 234);
            this.txt_AntesDaVirgulaSingular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_AntesDaVirgulaSingular.Name = "txt_AntesDaVirgulaSingular";
            this.txt_AntesDaVirgulaSingular.Size = new System.Drawing.Size(145, 23);
            this.txt_AntesDaVirgulaSingular.TabIndex = 4;
            // 
            // txt_AntesDaVirgulaPlural
            // 
            this.txt_AntesDaVirgulaPlural.Location = new System.Drawing.Point(663, 264);
            this.txt_AntesDaVirgulaPlural.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_AntesDaVirgulaPlural.Name = "txt_AntesDaVirgulaPlural";
            this.txt_AntesDaVirgulaPlural.Size = new System.Drawing.Size(145, 23);
            this.txt_AntesDaVirgulaPlural.TabIndex = 5;
            // 
            // txt_Conector
            // 
            this.txt_Conector.Location = new System.Drawing.Point(663, 294);
            this.txt_Conector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Conector.Name = "txt_Conector";
            this.txt_Conector.Size = new System.Drawing.Size(145, 23);
            this.txt_Conector.TabIndex = 6;
            // 
            // txt_DepoisDaVirgulaSingular
            // 
            this.txt_DepoisDaVirgulaSingular.Location = new System.Drawing.Point(663, 324);
            this.txt_DepoisDaVirgulaSingular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DepoisDaVirgulaSingular.Name = "txt_DepoisDaVirgulaSingular";
            this.txt_DepoisDaVirgulaSingular.Size = new System.Drawing.Size(145, 23);
            this.txt_DepoisDaVirgulaSingular.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Singular antes da vírgula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plural antes da vírgula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plural depois da vírgula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Singular depois da vírgula";
            // 
            // txt_DepoisDaVirgulaPlural
            // 
            this.txt_DepoisDaVirgulaPlural.Location = new System.Drawing.Point(663, 354);
            this.txt_DepoisDaVirgulaPlural.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DepoisDaVirgulaPlural.Name = "txt_DepoisDaVirgulaPlural";
            this.txt_DepoisDaVirgulaPlural.Size = new System.Drawing.Size(145, 23);
            this.txt_DepoisDaVirgulaPlural.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Conector por extenso";
            // 
            // chk_ZeroExplicitoAntesDaVirgula
            // 
            this.chk_ZeroExplicitoAntesDaVirgula.AutoSize = true;
            this.chk_ZeroExplicitoAntesDaVirgula.Location = new System.Drawing.Point(518, 155);
            this.chk_ZeroExplicitoAntesDaVirgula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ZeroExplicitoAntesDaVirgula.Name = "chk_ZeroExplicitoAntesDaVirgula";
            this.chk_ZeroExplicitoAntesDaVirgula.Size = new System.Drawing.Size(184, 19);
            this.chk_ZeroExplicitoAntesDaVirgula.TabIndex = 14;
            this.chk_ZeroExplicitoAntesDaVirgula.Text = "Zero explícito antes da vírgula";
            this.chk_ZeroExplicitoAntesDaVirgula.UseVisualStyleBackColor = true;
            // 
            // chk_ZeroExplicitoDepoisDaVirgula
            // 
            this.chk_ZeroExplicitoDepoisDaVirgula.AutoSize = true;
            this.chk_ZeroExplicitoDepoisDaVirgula.Location = new System.Drawing.Point(518, 181);
            this.chk_ZeroExplicitoDepoisDaVirgula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ZeroExplicitoDepoisDaVirgula.Name = "chk_ZeroExplicitoDepoisDaVirgula";
            this.chk_ZeroExplicitoDepoisDaVirgula.Size = new System.Drawing.Size(191, 19);
            this.chk_ZeroExplicitoDepoisDaVirgula.TabIndex = 15;
            this.chk_ZeroExplicitoDepoisDaVirgula.Text = "Zero explícito depois da vírgula";
            this.chk_ZeroExplicitoDepoisDaVirgula.UseVisualStyleBackColor = true;
            // 
            // chk_ExtensoEmFeminino
            // 
            this.chk_ExtensoEmFeminino.AutoSize = true;
            this.chk_ExtensoEmFeminino.Location = new System.Drawing.Point(518, 132);
            this.chk_ExtensoEmFeminino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ExtensoEmFeminino.Name = "chk_ExtensoEmFeminino";
            this.chk_ExtensoEmFeminino.Size = new System.Drawing.Size(132, 19);
            this.chk_ExtensoEmFeminino.TabIndex = 16;
            this.chk_ExtensoEmFeminino.Text = "Gênero no feminino";
            this.chk_ExtensoEmFeminino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pré-definições";
            // 
            // cbo_Presets
            // 
            this.cbo_Presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Presets.FormattingEnabled = true;
            this.cbo_Presets.Location = new System.Drawing.Point(663, 382);
            this.cbo_Presets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Presets.Name = "cbo_Presets";
            this.cbo_Presets.Size = new System.Drawing.Size(145, 23);
            this.cbo_Presets.TabIndex = 18;
            this.cbo_Presets.SelectedIndexChanged += new System.EventHandler(this.cbo_Presets_SelectedIndexChanged);
            // 
            // chk_PrefixoDe
            // 
            this.chk_PrefixoDe.AutoSize = true;
            this.chk_PrefixoDe.Location = new System.Drawing.Point(518, 208);
            this.chk_PrefixoDe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_PrefixoDe.Name = "chk_PrefixoDe";
            this.chk_PrefixoDe.Size = new System.Drawing.Size(153, 19);
            this.chk_PrefixoDe.TabIndex = 19;
            this.chk_PrefixoDe.Text = "Deve usar o prefixo \"de\"";
            this.chk_PrefixoDe.UseVisualStyleBackColor = true;
            // 
            // grpb_casing
            // 
            this.grpb_casing.Controls.Add(this.rdb_Frase);
            this.grpb_casing.Controls.Add(this.rdb_Uppercase);
            this.grpb_casing.Controls.Add(this.rdb_Lowercase);
            this.grpb_casing.Controls.Add(this.rdb_Pascalcase);
            this.grpb_casing.Location = new System.Drawing.Point(511, 45);
            this.grpb_casing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpb_casing.Name = "grpb_casing";
            this.grpb_casing.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpb_casing.Size = new System.Drawing.Size(196, 80);
            this.grpb_casing.TabIndex = 6;
            this.grpb_casing.TabStop = false;
            this.grpb_casing.Text = "Casing";
            // 
            // rdb_Frase
            // 
            this.rdb_Frase.AutoSize = true;
            this.rdb_Frase.Location = new System.Drawing.Point(99, 48);
            this.rdb_Frase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Frase.Name = "rdb_Frase";
            this.rdb_Frase.Size = new System.Drawing.Size(52, 19);
            this.rdb_Frase.TabIndex = 7;
            this.rdb_Frase.Text = "Frase";
            this.rdb_Frase.UseVisualStyleBackColor = true;
            // 
            // rdb_Uppercase
            // 
            this.rdb_Uppercase.AutoSize = true;
            this.rdb_Uppercase.Checked = true;
            this.rdb_Uppercase.Location = new System.Drawing.Point(7, 22);
            this.rdb_Uppercase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Uppercase.Name = "rdb_Uppercase";
            this.rdb_Uppercase.Size = new System.Drawing.Size(80, 19);
            this.rdb_Uppercase.TabIndex = 6;
            this.rdb_Uppercase.TabStop = true;
            this.rdb_Uppercase.Text = "Uppercase";
            this.rdb_Uppercase.UseVisualStyleBackColor = true;
            // 
            // rdb_Lowercase
            // 
            this.rdb_Lowercase.AutoSize = true;
            this.rdb_Lowercase.Location = new System.Drawing.Point(7, 48);
            this.rdb_Lowercase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Lowercase.Name = "rdb_Lowercase";
            this.rdb_Lowercase.Size = new System.Drawing.Size(80, 19);
            this.rdb_Lowercase.TabIndex = 5;
            this.rdb_Lowercase.Text = "Lowercase";
            this.rdb_Lowercase.UseVisualStyleBackColor = true;
            // 
            // rdb_Pascalcase
            // 
            this.rdb_Pascalcase.AutoSize = true;
            this.rdb_Pascalcase.Location = new System.Drawing.Point(99, 22);
            this.rdb_Pascalcase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Pascalcase.Name = "rdb_Pascalcase";
            this.rdb_Pascalcase.Size = new System.Drawing.Size(81, 19);
            this.rdb_Pascalcase.TabIndex = 4;
            this.rdb_Pascalcase.Text = "Pascalcase";
            this.rdb_Pascalcase.UseVisualStyleBackColor = true;
            // 
            // rdb_Ordinal
            // 
            this.rdb_Ordinal.AutoSize = true;
            this.rdb_Ordinal.Location = new System.Drawing.Point(7, 48);
            this.rdb_Ordinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Ordinal.Name = "rdb_Ordinal";
            this.rdb_Ordinal.Size = new System.Drawing.Size(64, 19);
            this.rdb_Ordinal.TabIndex = 4;
            this.rdb_Ordinal.Text = "Ordinal";
            this.rdb_Ordinal.UseVisualStyleBackColor = true;
            this.rdb_Ordinal.CheckedChanged += new System.EventHandler(this.rdb_Ordinal_CheckedChanged);
            // 
            // rdb_Cardinal
            // 
            this.rdb_Cardinal.AutoSize = true;
            this.rdb_Cardinal.Checked = true;
            this.rdb_Cardinal.Location = new System.Drawing.Point(7, 22);
            this.rdb_Cardinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Cardinal.Name = "rdb_Cardinal";
            this.rdb_Cardinal.Size = new System.Drawing.Size(69, 19);
            this.rdb_Cardinal.TabIndex = 5;
            this.rdb_Cardinal.TabStop = true;
            this.rdb_Cardinal.Text = "Cardinal";
            this.rdb_Cardinal.UseVisualStyleBackColor = true;
            this.rdb_Cardinal.CheckedChanged += new System.EventHandler(this.rdb_Cardinal_CheckedChanged);
            // 
            // grpb_tipo
            // 
            this.grpb_tipo.Controls.Add(this.rdb_Romano);
            this.grpb_tipo.Controls.Add(this.rdb_Cardinal);
            this.grpb_tipo.Controls.Add(this.rdb_Ordinal);
            this.grpb_tipo.Location = new System.Drawing.Point(720, 45);
            this.grpb_tipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpb_tipo.Name = "grpb_tipo";
            this.grpb_tipo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpb_tipo.Size = new System.Drawing.Size(89, 106);
            this.grpb_tipo.TabIndex = 3;
            this.grpb_tipo.TabStop = false;
            this.grpb_tipo.Text = "Tipo";
            // 
            // rdb_Romano
            // 
            this.rdb_Romano.AutoSize = true;
            this.rdb_Romano.Location = new System.Drawing.Point(7, 75);
            this.rdb_Romano.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_Romano.Name = "rdb_Romano";
            this.rdb_Romano.Size = new System.Drawing.Size(70, 19);
            this.rdb_Romano.TabIndex = 6;
            this.rdb_Romano.Text = "Romano";
            this.rdb_Romano.UseVisualStyleBackColor = true;
            this.rdb_Romano.CheckedChanged += new System.EventHandler(this.rdb_Romano_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 418);
            this.Controls.Add(this.grpb_casing);
            this.Controls.Add(this.chk_PrefixoDe);
            this.Controls.Add(this.cbo_Presets);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_ExtensoEmFeminino);
            this.Controls.Add(this.chk_ZeroExplicitoDepoisDaVirgula);
            this.Controls.Add(this.chk_ZeroExplicitoAntesDaVirgula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DepoisDaVirgulaPlural);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DepoisDaVirgulaSingular);
            this.Controls.Add(this.txt_Conector);
            this.Controls.Add(this.txt_AntesDaVirgulaPlural);
            this.Controls.Add(this.txt_AntesDaVirgulaSingular);
            this.Controls.Add(this.grpb_tipo);
            this.Controls.Add(this.txt_NumeroPorExtenso);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.btn_Escrever);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Escrever por extenso";
            this.grpb_casing.ResumeLayout(false);
            this.grpb_casing.PerformLayout();
            this.grpb_tipo.ResumeLayout(false);
            this.grpb_tipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Escrever;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_NumeroPorExtenso;
        private System.Windows.Forms.TextBox txt_AntesDaVirgulaSingular;
        private System.Windows.Forms.TextBox txt_AntesDaVirgulaPlural;
        private System.Windows.Forms.TextBox txt_Conector;
        private System.Windows.Forms.TextBox txt_DepoisDaVirgulaSingular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DepoisDaVirgulaPlural;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_ZeroExplicitoAntesDaVirgula;
        private System.Windows.Forms.CheckBox chk_ZeroExplicitoDepoisDaVirgula;
        private System.Windows.Forms.CheckBox chk_ExtensoEmFeminino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Presets;
        private System.Windows.Forms.CheckBox chk_PrefixoDe;
        private System.Windows.Forms.GroupBox grpb_casing;
        private System.Windows.Forms.RadioButton rdb_Lowercase;
        private System.Windows.Forms.RadioButton rdb_Pascalcase;
        private System.Windows.Forms.RadioButton rdb_Frase;
        private System.Windows.Forms.RadioButton rdb_Uppercase;
        private System.Windows.Forms.RadioButton rdb_Ordinal;
        private System.Windows.Forms.RadioButton rdb_Cardinal;
        private System.Windows.Forms.GroupBox grpb_tipo;
        private System.Windows.Forms.RadioButton rdb_Romano;
    }
}

