namespace TI_AED_LABAED_Forms
{
    partial class FormCalculator
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
            this.txt_posfixa = new MetroFramework.Controls.MetroTextBox();
            this.btn_dividir = new MetroFramework.Controls.MetroButton();
            this.btn_multiplicar = new MetroFramework.Controls.MetroButton();
            this.btn_subtrair = new MetroFramework.Controls.MetroButton();
            this.btn_somar = new MetroFramework.Controls.MetroButton();
            this.btn_elevar = new MetroFramework.Controls.MetroButton();
            this.btn_seis = new MetroFramework.Controls.MetroButton();
            this.btn_sete = new MetroFramework.Controls.MetroButton();
            this.btn_oito = new MetroFramework.Controls.MetroButton();
            this.btn_nove = new MetroFramework.Controls.MetroButton();
            this.btn_dois = new MetroFramework.Controls.MetroButton();
            this.btn_tres = new MetroFramework.Controls.MetroButton();
            this.btn_quatro = new MetroFramework.Controls.MetroButton();
            this.btn_cinco = new MetroFramework.Controls.MetroButton();
            this.btn_um = new MetroFramework.Controls.MetroButton();
            this.btn_zero = new MetroFramework.Controls.MetroButton();
            this.btn_igual = new MetroFramework.Controls.MetroButton();
            this.btn_raiz = new MetroFramework.Controls.MetroButton();
            this.txt_resultado = new MetroFramework.Controls.MetroTextBox();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_abreparenteses = new MetroFramework.Controls.MetroButton();
            this.btn_fechaparenteses = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txt_posfixa
            // 
            // 
            // 
            // 
            this.txt_posfixa.CustomButton.Image = null;
            this.txt_posfixa.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txt_posfixa.CustomButton.Name = "";
            this.txt_posfixa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_posfixa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_posfixa.CustomButton.TabIndex = 1;
            this.txt_posfixa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_posfixa.CustomButton.UseSelectable = true;
            this.txt_posfixa.CustomButton.Visible = false;
            this.txt_posfixa.Enabled = false;
            this.txt_posfixa.Lines = new string[] {
        " "};
            this.txt_posfixa.Location = new System.Drawing.Point(25, 34);
            this.txt_posfixa.MaxLength = 32767;
            this.txt_posfixa.Name = "txt_posfixa";
            this.txt_posfixa.PasswordChar = '\0';
            this.txt_posfixa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_posfixa.SelectedText = "";
            this.txt_posfixa.SelectionLength = 0;
            this.txt_posfixa.SelectionStart = 0;
            this.txt_posfixa.ShortcutsEnabled = true;
            this.txt_posfixa.Size = new System.Drawing.Size(244, 23);
            this.txt_posfixa.TabIndex = 18;
            this.txt_posfixa.Text = " ";
            this.txt_posfixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_posfixa.UseSelectable = true;
            this.txt_posfixa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_posfixa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(25, 89);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(44, 37);
            this.btn_dividir.TabIndex = 11;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseSelectable = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(75, 89);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(44, 37);
            this.btn_multiplicar.TabIndex = 12;
            this.btn_multiplicar.Text = "*";
            this.btn_multiplicar.UseSelectable = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(125, 89);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(44, 37);
            this.btn_subtrair.TabIndex = 13;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.UseSelectable = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(175, 89);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(44, 37);
            this.btn_somar.TabIndex = 14;
            this.btn_somar.Text = "+";
            this.btn_somar.UseSelectable = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // btn_elevar
            // 
            this.btn_elevar.Location = new System.Drawing.Point(225, 89);
            this.btn_elevar.Name = "btn_elevar";
            this.btn_elevar.Size = new System.Drawing.Size(44, 37);
            this.btn_elevar.TabIndex = 15;
            this.btn_elevar.Text = "^";
            this.btn_elevar.UseSelectable = true;
            this.btn_elevar.Click += new System.EventHandler(this.btn_elevar_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Location = new System.Drawing.Point(125, 175);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(44, 37);
            this.btn_seis.TabIndex = 6;
            this.btn_seis.Text = "6";
            this.btn_seis.UseSelectable = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_sete
            // 
            this.btn_sete.Location = new System.Drawing.Point(25, 132);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(44, 37);
            this.btn_sete.TabIndex = 7;
            this.btn_sete.Text = "7";
            this.btn_sete.UseSelectable = true;
            this.btn_sete.Click += new System.EventHandler(this.btn_sete_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.Location = new System.Drawing.Point(75, 132);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(44, 37);
            this.btn_oito.TabIndex = 8;
            this.btn_oito.Text = "8";
            this.btn_oito.UseSelectable = true;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.Location = new System.Drawing.Point(125, 132);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(44, 37);
            this.btn_nove.TabIndex = 9;
            this.btn_nove.Text = "9";
            this.btn_nove.UseSelectable = true;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.Location = new System.Drawing.Point(75, 218);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(44, 37);
            this.btn_dois.TabIndex = 2;
            this.btn_dois.Text = "2";
            this.btn_dois.UseSelectable = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.Location = new System.Drawing.Point(125, 218);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(44, 37);
            this.btn_tres.TabIndex = 3;
            this.btn_tres.Text = "3";
            this.btn_tres.UseSelectable = true;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.Location = new System.Drawing.Point(25, 175);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(44, 37);
            this.btn_quatro.TabIndex = 4;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseSelectable = true;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Location = new System.Drawing.Point(75, 175);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(44, 37);
            this.btn_cinco.TabIndex = 5;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseSelectable = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_um
            // 
            this.btn_um.Location = new System.Drawing.Point(25, 218);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(44, 37);
            this.btn_um.TabIndex = 1;
            this.btn_um.Text = "1";
            this.btn_um.UseSelectable = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(25, 261);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(144, 37);
            this.btn_zero.TabIndex = 0;
            this.btn_zero.Text = "0";
            this.btn_zero.UseSelectable = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(175, 261);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(94, 37);
            this.btn_igual.TabIndex = 17;
            this.btn_igual.Text = "=";
            this.btn_igual.UseSelectable = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_raiz
            // 
            this.btn_raiz.Location = new System.Drawing.Point(225, 175);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(44, 37);
            this.btn_raiz.TabIndex = 16;
            this.btn_raiz.Text = "R";
            this.btn_raiz.UseSelectable = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_raiz_Click);
            // 
            // txt_resultado
            // 
            // 
            // 
            // 
            this.txt_resultado.CustomButton.Image = null;
            this.txt_resultado.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txt_resultado.CustomButton.Name = "";
            this.txt_resultado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_resultado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_resultado.CustomButton.TabIndex = 1;
            this.txt_resultado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_resultado.CustomButton.UseSelectable = true;
            this.txt_resultado.CustomButton.Visible = false;
            this.txt_resultado.Lines = new string[] {
        " "};
            this.txt_resultado.Location = new System.Drawing.Point(25, 60);
            this.txt_resultado.MaxLength = 32767;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.PasswordChar = '\0';
            this.txt_resultado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_resultado.SelectedText = "";
            this.txt_resultado.SelectionLength = 0;
            this.txt_resultado.SelectionStart = 0;
            this.txt_resultado.ShortcutsEnabled = true;
            this.txt_resultado.Size = new System.Drawing.Size(244, 23);
            this.txt_resultado.TabIndex = 19;
            this.txt_resultado.Text = " ";
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_resultado.UseSelectable = true;
            this.txt_resultado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_resultado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_resultado_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(175, 175);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(44, 37);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "C";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(175, 218);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 37);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "BACK";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_abreparenteses
            // 
            this.btn_abreparenteses.Location = new System.Drawing.Point(175, 132);
            this.btn_abreparenteses.Name = "btn_abreparenteses";
            this.btn_abreparenteses.Size = new System.Drawing.Size(44, 37);
            this.btn_abreparenteses.TabIndex = 22;
            this.btn_abreparenteses.Text = "(";
            this.btn_abreparenteses.UseSelectable = true;
            this.btn_abreparenteses.Click += new System.EventHandler(this.btn_abreparenteses_Click);
            // 
            // btn_fechaparenteses
            // 
            this.btn_fechaparenteses.Location = new System.Drawing.Point(225, 132);
            this.btn_fechaparenteses.Name = "btn_fechaparenteses";
            this.btn_fechaparenteses.Size = new System.Drawing.Size(44, 37);
            this.btn_fechaparenteses.TabIndex = 23;
            this.btn_fechaparenteses.Text = ")";
            this.btn_fechaparenteses.UseSelectable = true;
            this.btn_fechaparenteses.Click += new System.EventHandler(this.btn_fechaparenteses_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(292, 321);
            this.Controls.Add(this.btn_fechaparenteses);
            this.Controls.Add(this.btn_abreparenteses);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_elevar);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.txt_posfixa);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "FormCalculator";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.Enter += new System.EventHandler(this.btn_igual_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_posfixa;
        private MetroFramework.Controls.MetroButton btn_dividir;
        private MetroFramework.Controls.MetroButton btn_multiplicar;
        private MetroFramework.Controls.MetroButton btn_subtrair;
        private MetroFramework.Controls.MetroButton btn_somar;
        private MetroFramework.Controls.MetroButton btn_elevar;
        private MetroFramework.Controls.MetroButton btn_seis;
        private MetroFramework.Controls.MetroButton btn_sete;
        private MetroFramework.Controls.MetroButton btn_oito;
        private MetroFramework.Controls.MetroButton btn_nove;
        private MetroFramework.Controls.MetroButton btn_dois;
        private MetroFramework.Controls.MetroButton btn_tres;
        private MetroFramework.Controls.MetroButton btn_quatro;
        private MetroFramework.Controls.MetroButton btn_cinco;
        private MetroFramework.Controls.MetroButton btn_um;
        private MetroFramework.Controls.MetroButton btn_zero;
        private MetroFramework.Controls.MetroButton btn_igual;
        private MetroFramework.Controls.MetroButton btn_raiz;
        private MetroFramework.Controls.MetroTextBox txt_resultado;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_abreparenteses;
        private MetroFramework.Controls.MetroButton btn_fechaparenteses;
    }
}

