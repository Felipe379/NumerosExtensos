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
            btn_Escrever = new System.Windows.Forms.Button();
            txt_Numero = new System.Windows.Forms.TextBox();
            txt_NumeroPorExtenso = new System.Windows.Forms.TextBox();
            txt_ParteInteiraSingular = new System.Windows.Forms.TextBox();
            txt_ParteInteiraPlural = new System.Windows.Forms.TextBox();
            txt_Conjuncao = new System.Windows.Forms.TextBox();
            txt_ParteDecimalSingular = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txt_ParteDecimalPlural = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            chk_ZeroExplicitoParteInteira = new System.Windows.Forms.CheckBox();
            chk_ZeroExplicitoParteDecimal = new System.Windows.Forms.CheckBox();
            chk_ExtensoEmFeminino = new System.Windows.Forms.CheckBox();
            label6 = new System.Windows.Forms.Label();
            cbo_Presets = new System.Windows.Forms.ComboBox();
            chk_ConjuncaoDe = new System.Windows.Forms.CheckBox();
            chk_SepararClassesPorVirgula = new System.Windows.Forms.CheckBox();
            cbo_Casing = new System.Windows.Forms.ComboBox();
            cbo_Tipo = new System.Windows.Forms.ComboBox();
            chk_ConjuncaoExplicitaSeParteInteiraVazia = new System.Windows.Forms.CheckBox();
            chk_UmMilExplicito = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // btn_Escrever
            // 
            btn_Escrever.Location = new System.Drawing.Point(518, 10);
            btn_Escrever.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Escrever.Name = "btn_Escrever";
            btn_Escrever.Size = new System.Drawing.Size(290, 27);
            btn_Escrever.TabIndex = 0;
            btn_Escrever.Text = "Escrever";
            btn_Escrever.UseVisualStyleBackColor = true;
            btn_Escrever.Click += BtnEscrever_Click;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new System.Drawing.Point(14, 14);
            txt_Numero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_Numero.MaxLength = 134;
            txt_Numero.Name = "txt_Numero";
            txt_Numero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txt_Numero.Size = new System.Drawing.Size(489, 23);
            txt_Numero.TabIndex = 1;
            // 
            // txt_NumeroPorExtenso
            // 
            txt_NumeroPorExtenso.Location = new System.Drawing.Point(14, 55);
            txt_NumeroPorExtenso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_NumeroPorExtenso.Multiline = true;
            txt_NumeroPorExtenso.Name = "txt_NumeroPorExtenso";
            txt_NumeroPorExtenso.ReadOnly = true;
            txt_NumeroPorExtenso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txt_NumeroPorExtenso.Size = new System.Drawing.Size(489, 375);
            txt_NumeroPorExtenso.TabIndex = 2;
            // 
            // txt_ParteInteiraSingular
            // 
            txt_ParteInteiraSingular.Location = new System.Drawing.Point(664, 259);
            txt_ParteInteiraSingular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_ParteInteiraSingular.Name = "txt_ParteInteiraSingular";
            txt_ParteInteiraSingular.Size = new System.Drawing.Size(145, 23);
            txt_ParteInteiraSingular.TabIndex = 4;
            // 
            // txt_ParteInteiraPlural
            // 
            txt_ParteInteiraPlural.Location = new System.Drawing.Point(664, 289);
            txt_ParteInteiraPlural.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_ParteInteiraPlural.Name = "txt_ParteInteiraPlural";
            txt_ParteInteiraPlural.Size = new System.Drawing.Size(145, 23);
            txt_ParteInteiraPlural.TabIndex = 5;
            // 
            // txt_Conjuncao
            // 
            txt_Conjuncao.Location = new System.Drawing.Point(664, 319);
            txt_Conjuncao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_Conjuncao.Name = "txt_Conjuncao";
            txt_Conjuncao.Size = new System.Drawing.Size(145, 23);
            txt_Conjuncao.TabIndex = 6;
            // 
            // txt_ParteDecimalSingular
            // 
            txt_ParteDecimalSingular.Location = new System.Drawing.Point(664, 349);
            txt_ParteDecimalSingular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_ParteDecimalSingular.Name = "txt_ParteDecimalSingular";
            txt_ParteDecimalSingular.Size = new System.Drawing.Size(145, 23);
            txt_ParteDecimalSingular.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(508, 263);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 15);
            label1.TabIndex = 8;
            label1.Text = "Singular da parte inteira";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(508, 293);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 15);
            label2.TabIndex = 9;
            label2.Text = "Plural da parte inteira";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(508, 383);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 15);
            label3.TabIndex = 11;
            label3.Text = "Plural da parte decimal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(508, 353);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(141, 15);
            label4.TabIndex = 10;
            label4.Text = "Singular da parte decimal";
            // 
            // txt_ParteDecimalPlural
            // 
            txt_ParteDecimalPlural.Location = new System.Drawing.Point(664, 379);
            txt_ParteDecimalPlural.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_ParteDecimalPlural.Name = "txt_ParteDecimalPlural";
            txt_ParteDecimalPlural.Size = new System.Drawing.Size(145, 23);
            txt_ParteDecimalPlural.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(508, 323);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(130, 15);
            label5.TabIndex = 13;
            label5.Text = "Conjunção por extenso";
            // 
            // chk_ZeroExplicitoParteInteira
            // 
            chk_ZeroExplicitoParteInteira.AutoSize = true;
            chk_ZeroExplicitoParteInteira.Location = new System.Drawing.Point(518, 134);
            chk_ZeroExplicitoParteInteira.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_ZeroExplicitoParteInteira.Name = "chk_ZeroExplicitoParteInteira";
            chk_ZeroExplicitoParteInteira.Size = new System.Drawing.Size(180, 19);
            chk_ZeroExplicitoParteInteira.TabIndex = 14;
            chk_ZeroExplicitoParteInteira.Text = "Zero explícito na parte inteira";
            chk_ZeroExplicitoParteInteira.UseVisualStyleBackColor = true;
            // 
            // chk_ZeroExplicitoParteDecimal
            // 
            chk_ZeroExplicitoParteDecimal.AutoSize = true;
            chk_ZeroExplicitoParteDecimal.Location = new System.Drawing.Point(518, 159);
            chk_ZeroExplicitoParteDecimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_ZeroExplicitoParteDecimal.Name = "chk_ZeroExplicitoParteDecimal";
            chk_ZeroExplicitoParteDecimal.Size = new System.Drawing.Size(189, 19);
            chk_ZeroExplicitoParteDecimal.TabIndex = 15;
            chk_ZeroExplicitoParteDecimal.Text = "Zero explícito na parte decimal";
            chk_ZeroExplicitoParteDecimal.UseVisualStyleBackColor = true;
            // 
            // chk_ExtensoEmFeminino
            // 
            chk_ExtensoEmFeminino.AutoSize = true;
            chk_ExtensoEmFeminino.Location = new System.Drawing.Point(518, 84);
            chk_ExtensoEmFeminino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_ExtensoEmFeminino.Name = "chk_ExtensoEmFeminino";
            chk_ExtensoEmFeminino.Size = new System.Drawing.Size(132, 19);
            chk_ExtensoEmFeminino.TabIndex = 16;
            chk_ExtensoEmFeminino.Text = "Gênero no feminino";
            chk_ExtensoEmFeminino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(508, 410);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 15);
            label6.TabIndex = 17;
            label6.Text = "Predefinições";
            // 
            // cbo_Presets
            // 
            cbo_Presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbo_Presets.FormattingEnabled = true;
            cbo_Presets.Location = new System.Drawing.Point(664, 407);
            cbo_Presets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbo_Presets.Name = "cbo_Presets";
            cbo_Presets.Size = new System.Drawing.Size(145, 23);
            cbo_Presets.TabIndex = 18;
            cbo_Presets.SelectedIndexChanged += CboPresets_SelectedIndexChanged;
            // 
            // chk_ConjuncaoDe
            // 
            chk_ConjuncaoDe.AutoSize = true;
            chk_ConjuncaoDe.Location = new System.Drawing.Point(518, 184);
            chk_ConjuncaoDe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_ConjuncaoDe.Name = "chk_ConjuncaoDe";
            chk_ConjuncaoDe.Size = new System.Drawing.Size(171, 19);
            chk_ConjuncaoDe.TabIndex = 19;
            chk_ConjuncaoDe.Text = "Deve usar a conjunção \"de\"";
            chk_ConjuncaoDe.UseVisualStyleBackColor = true;
            // 
            // chk_SepararClassesPorVirgula
            // 
            chk_SepararClassesPorVirgula.AutoSize = true;
            chk_SepararClassesPorVirgula.Location = new System.Drawing.Point(518, 109);
            chk_SepararClassesPorVirgula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_SepararClassesPorVirgula.Name = "chk_SepararClassesPorVirgula";
            chk_SepararClassesPorVirgula.Size = new System.Drawing.Size(164, 19);
            chk_SepararClassesPorVirgula.TabIndex = 19;
            chk_SepararClassesPorVirgula.Text = "Separar classes por vírgula";
            chk_SepararClassesPorVirgula.UseVisualStyleBackColor = true;
            // 
            // cbo_Casing
            // 
            cbo_Casing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbo_Casing.FormattingEnabled = true;
            cbo_Casing.Location = new System.Drawing.Point(518, 55);
            cbo_Casing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbo_Casing.Name = "cbo_Casing";
            cbo_Casing.Size = new System.Drawing.Size(138, 23);
            cbo_Casing.TabIndex = 18;
            // 
            // cbo_Tipo
            // 
            cbo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbo_Tipo.FormattingEnabled = true;
            cbo_Tipo.Location = new System.Drawing.Point(664, 55);
            cbo_Tipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbo_Tipo.Name = "cbo_Tipo";
            cbo_Tipo.Size = new System.Drawing.Size(145, 23);
            cbo_Tipo.TabIndex = 18;
            cbo_Tipo.SelectedIndexChanged += CboTipos_SelectedIndexChanged;
            // 
            // chk_ConjuncaoExplicitaSeParteInteiraVazia
            // 
            chk_ConjuncaoExplicitaSeParteInteiraVazia.AutoSize = true;
            chk_ConjuncaoExplicitaSeParteInteiraVazia.Location = new System.Drawing.Point(518, 209);
            chk_ConjuncaoExplicitaSeParteInteiraVazia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_ConjuncaoExplicitaSeParteInteiraVazia.Name = "chk_ConjuncaoExplicitaSeParteInteiraVazia";
            chk_ConjuncaoExplicitaSeParteInteiraVazia.Size = new System.Drawing.Size(241, 19);
            chk_ConjuncaoExplicitaSeParteInteiraVazia.TabIndex = 19;
            chk_ConjuncaoExplicitaSeParteInteiraVazia.Text = "Conjunção explícito se parte inteira vazia";
            chk_ConjuncaoExplicitaSeParteInteiraVazia.UseVisualStyleBackColor = true;
            // 
            // chk_UmMilExplicito
            // 
            chk_UmMilExplicito.AutoSize = true;
            chk_UmMilExplicito.Location = new System.Drawing.Point(518, 234);
            chk_UmMilExplicito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chk_UmMilExplicito.Name = "chk_UmMilExplicito";
            chk_UmMilExplicito.Size = new System.Drawing.Size(165, 19);
            chk_UmMilExplicito.TabIndex = 20;
            chk_UmMilExplicito.Text = "Escreve \"Um mil\" explícito";
            chk_UmMilExplicito.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(822, 442);
            Controls.Add(chk_UmMilExplicito);
            Controls.Add(chk_ConjuncaoExplicitaSeParteInteiraVazia);
            Controls.Add(cbo_Tipo);
            Controls.Add(cbo_Casing);
            Controls.Add(chk_SepararClassesPorVirgula);
            Controls.Add(chk_ConjuncaoDe);
            Controls.Add(cbo_Presets);
            Controls.Add(label6);
            Controls.Add(chk_ExtensoEmFeminino);
            Controls.Add(chk_ZeroExplicitoParteDecimal);
            Controls.Add(chk_ZeroExplicitoParteInteira);
            Controls.Add(label5);
            Controls.Add(txt_ParteDecimalPlural);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ParteDecimalSingular);
            Controls.Add(txt_Conjuncao);
            Controls.Add(txt_ParteInteiraPlural);
            Controls.Add(txt_ParteInteiraSingular);
            Controls.Add(txt_NumeroPorExtenso);
            Controls.Add(txt_Numero);
            Controls.Add(btn_Escrever);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "Escrever por extenso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Escrever;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_NumeroPorExtenso;
        private System.Windows.Forms.TextBox txt_ParteInteiraSingular;
        private System.Windows.Forms.TextBox txt_ParteInteiraPlural;
        private System.Windows.Forms.TextBox txt_Conjuncao;
        private System.Windows.Forms.TextBox txt_ParteDecimalSingular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ParteDecimalPlural;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_ZeroExplicitoParteInteira;
        private System.Windows.Forms.CheckBox chk_ZeroExplicitoParteDecimal;
        private System.Windows.Forms.CheckBox chk_ExtensoEmFeminino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Presets;
        private System.Windows.Forms.CheckBox chk_ConjuncaoDe;
        private System.Windows.Forms.CheckBox chk_SepararClassesPorVirgula;
        private System.Windows.Forms.ComboBox cbo_Casing;
        private System.Windows.Forms.ComboBox cbo_Tipo;
        private System.Windows.Forms.CheckBox chk_ConjuncaoExplicitaSeParteInteiraVazia;
        private System.Windows.Forms.CheckBox chk_UmMilExplicito;
    }
}

