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
            this.txt_ParteInteiraSingular = new System.Windows.Forms.TextBox();
            this.txt_ParteInteiraPlural = new System.Windows.Forms.TextBox();
            this.txt_Conjuncao = new System.Windows.Forms.TextBox();
            this.txt_ParteDecimalSingular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ParteDecimalPlural = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_ZeroExplicitoParteInteira = new System.Windows.Forms.CheckBox();
            this.chk_ZeroExplicitoParteDecimal = new System.Windows.Forms.CheckBox();
            this.chk_ExtensoEmFeminino = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Presets = new System.Windows.Forms.ComboBox();
            this.chk_ConjuncaoDe = new System.Windows.Forms.CheckBox();
            this.chk_SepararClassesPorVirgula = new System.Windows.Forms.CheckBox();
            this.cbo_Casing = new System.Windows.Forms.ComboBox();
            this.cbo_Tipo = new System.Windows.Forms.ComboBox();
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia = new System.Windows.Forms.CheckBox();
            this.chk_UmMilExplicito = new System.Windows.Forms.CheckBox();
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
            this.txt_NumeroPorExtenso.Size = new System.Drawing.Size(489, 375);
            this.txt_NumeroPorExtenso.TabIndex = 2;
            // 
            // txt_ParteInteiraSingular
            // 
            this.txt_ParteInteiraSingular.Location = new System.Drawing.Point(664, 259);
            this.txt_ParteInteiraSingular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParteInteiraSingular.Name = "txt_ParteInteiraSingular";
            this.txt_ParteInteiraSingular.Size = new System.Drawing.Size(145, 23);
            this.txt_ParteInteiraSingular.TabIndex = 4;
            // 
            // txt_ParteInteiraPlural
            // 
            this.txt_ParteInteiraPlural.Location = new System.Drawing.Point(664, 289);
            this.txt_ParteInteiraPlural.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParteInteiraPlural.Name = "txt_ParteInteiraPlural";
            this.txt_ParteInteiraPlural.Size = new System.Drawing.Size(145, 23);
            this.txt_ParteInteiraPlural.TabIndex = 5;
            // 
            // txt_Conjuncao
            // 
            this.txt_Conjuncao.Location = new System.Drawing.Point(664, 319);
            this.txt_Conjuncao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Conjuncao.Name = "txt_Conjuncao";
            this.txt_Conjuncao.Size = new System.Drawing.Size(145, 23);
            this.txt_Conjuncao.TabIndex = 6;
            // 
            // txt_ParteDecimalSingular
            // 
            this.txt_ParteDecimalSingular.Location = new System.Drawing.Point(664, 349);
            this.txt_ParteDecimalSingular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParteDecimalSingular.Name = "txt_ParteDecimalSingular";
            this.txt_ParteDecimalSingular.Size = new System.Drawing.Size(145, 23);
            this.txt_ParteDecimalSingular.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Singular da parte inteira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plural da parte inteira";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plural da parte decimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Singular da parte decimal";
            // 
            // txt_ParteDecimalPlural
            // 
            this.txt_ParteDecimalPlural.Location = new System.Drawing.Point(664, 379);
            this.txt_ParteDecimalPlural.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParteDecimalPlural.Name = "txt_ParteDecimalPlural";
            this.txt_ParteDecimalPlural.Size = new System.Drawing.Size(145, 23);
            this.txt_ParteDecimalPlural.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Conjunção por extenso";
            // 
            // chk_ZeroExplicitoParteInteira
            // 
            this.chk_ZeroExplicitoParteInteira.AutoSize = true;
            this.chk_ZeroExplicitoParteInteira.Location = new System.Drawing.Point(518, 134);
            this.chk_ZeroExplicitoParteInteira.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ZeroExplicitoParteInteira.Name = "chk_ZeroExplicitoParteInteira";
            this.chk_ZeroExplicitoParteInteira.Size = new System.Drawing.Size(180, 19);
            this.chk_ZeroExplicitoParteInteira.TabIndex = 14;
            this.chk_ZeroExplicitoParteInteira.Text = "Zero explícito na parte inteira";
            this.chk_ZeroExplicitoParteInteira.UseVisualStyleBackColor = true;
            // 
            // chk_ZeroExplicitoParteDecimal
            // 
            this.chk_ZeroExplicitoParteDecimal.AutoSize = true;
            this.chk_ZeroExplicitoParteDecimal.Location = new System.Drawing.Point(518, 159);
            this.chk_ZeroExplicitoParteDecimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ZeroExplicitoParteDecimal.Name = "chk_ZeroExplicitoParteDecimal";
            this.chk_ZeroExplicitoParteDecimal.Size = new System.Drawing.Size(189, 19);
            this.chk_ZeroExplicitoParteDecimal.TabIndex = 15;
            this.chk_ZeroExplicitoParteDecimal.Text = "Zero explícito na parte decimal";
            this.chk_ZeroExplicitoParteDecimal.UseVisualStyleBackColor = true;
            // 
            // chk_ExtensoEmFeminino
            // 
            this.chk_ExtensoEmFeminino.AutoSize = true;
            this.chk_ExtensoEmFeminino.Location = new System.Drawing.Point(518, 84);
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
            this.label6.Location = new System.Drawing.Point(508, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Predefinições";
            // 
            // cbo_Presets
            // 
            this.cbo_Presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Presets.FormattingEnabled = true;
            this.cbo_Presets.Location = new System.Drawing.Point(664, 407);
            this.cbo_Presets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Presets.Name = "cbo_Presets";
            this.cbo_Presets.Size = new System.Drawing.Size(145, 23);
            this.cbo_Presets.TabIndex = 18;
            this.cbo_Presets.SelectedIndexChanged += new System.EventHandler(this.cbo_Presets_SelectedIndexChanged);
            // 
            // chk_ConjuncaoDe
            // 
            this.chk_ConjuncaoDe.AutoSize = true;
            this.chk_ConjuncaoDe.Location = new System.Drawing.Point(518, 184);
            this.chk_ConjuncaoDe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ConjuncaoDe.Name = "chk_ConjuncaoDe";
            this.chk_ConjuncaoDe.Size = new System.Drawing.Size(171, 19);
            this.chk_ConjuncaoDe.TabIndex = 19;
            this.chk_ConjuncaoDe.Text = "Deve usar a conjunção \"de\"";
            this.chk_ConjuncaoDe.UseVisualStyleBackColor = true;
            // 
            // chk_SepararClassesPorVirgula
            // 
            this.chk_SepararClassesPorVirgula.AutoSize = true;
            this.chk_SepararClassesPorVirgula.Location = new System.Drawing.Point(518, 109);
            this.chk_SepararClassesPorVirgula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_SepararClassesPorVirgula.Name = "chk_SepararClassesPorVirgula";
            this.chk_SepararClassesPorVirgula.Size = new System.Drawing.Size(164, 19);
            this.chk_SepararClassesPorVirgula.TabIndex = 19;
            this.chk_SepararClassesPorVirgula.Text = "Separar classes por vírgula";
            this.chk_SepararClassesPorVirgula.UseVisualStyleBackColor = true;
            // 
            // cbo_Casing
            // 
            this.cbo_Casing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Casing.FormattingEnabled = true;
            this.cbo_Casing.Location = new System.Drawing.Point(518, 55);
            this.cbo_Casing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Casing.Name = "cbo_Casing";
            this.cbo_Casing.Size = new System.Drawing.Size(138, 23);
            this.cbo_Casing.TabIndex = 18;
            // 
            // cbo_Tipo
            // 
            this.cbo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Tipo.FormattingEnabled = true;
            this.cbo_Tipo.Location = new System.Drawing.Point(664, 55);
            this.cbo_Tipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Tipo.Name = "cbo_Tipo";
            this.cbo_Tipo.Size = new System.Drawing.Size(145, 23);
            this.cbo_Tipo.TabIndex = 18;
            this.cbo_Tipo.SelectedIndexChanged += new System.EventHandler(this.cbo_Tipos_SelectedIndexChanged);
            // 
            // chk_ConjuncaoExplicitaSeParteInteiraVazia
            // 
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.AutoSize = true;
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.Location = new System.Drawing.Point(518, 209);
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.Name = "chk_ConjuncaoExplicitaSeParteInteiraVazia";
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.Size = new System.Drawing.Size(247, 19);
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.TabIndex = 19;
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.Text = "Conjunção explícitao se parte inteira vazia";
            this.chk_ConjuncaoExplicitaSeParteInteiraVazia.UseVisualStyleBackColor = true;
            // 
            // chk_UmMilExplicito
            // 
            this.chk_UmMilExplicito.AutoSize = true;
            this.chk_UmMilExplicito.Location = new System.Drawing.Point(518, 234);
            this.chk_UmMilExplicito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_UmMilExplicito.Name = "chk_UmMilExplicito";
            this.chk_UmMilExplicito.Size = new System.Drawing.Size(165, 19);
            this.chk_UmMilExplicito.TabIndex = 20;
            this.chk_UmMilExplicito.Text = "Escreve \"Um mil\" explícito";
            this.chk_UmMilExplicito.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 442);
            this.Controls.Add(this.chk_UmMilExplicito);
            this.Controls.Add(this.chk_ConjuncaoExplicitaSeParteInteiraVazia);
            this.Controls.Add(this.cbo_Tipo);
            this.Controls.Add(this.cbo_Casing);
            this.Controls.Add(this.chk_SepararClassesPorVirgula);
            this.Controls.Add(this.chk_ConjuncaoDe);
            this.Controls.Add(this.cbo_Presets);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_ExtensoEmFeminino);
            this.Controls.Add(this.chk_ZeroExplicitoParteDecimal);
            this.Controls.Add(this.chk_ZeroExplicitoParteInteira);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ParteDecimalPlural);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ParteDecimalSingular);
            this.Controls.Add(this.txt_Conjuncao);
            this.Controls.Add(this.txt_ParteInteiraPlural);
            this.Controls.Add(this.txt_ParteInteiraSingular);
            this.Controls.Add(this.txt_NumeroPorExtenso);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.btn_Escrever);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Escrever por extenso";
            this.ResumeLayout(false);
            this.PerformLayout();

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

