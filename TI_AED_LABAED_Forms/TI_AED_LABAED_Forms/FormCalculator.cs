using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace TI_AED_LABAED_Forms
{
    public partial class FormCalculator :  MetroForm
    {
        public FormCalculator()
        {
            InitializeComponent();
            txt_resultado.Text = null;
            txt_posfixa.Text = null;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            var equacao = txt_resultado.Text.Replace(" ", ""); //remove espaços em "branco" da string
            //equacao = equacao.Replace(",",".");  //troca ',' por '.' 
            try
            {
                txt_posfixa.Text = Calculadora.PosFixa(equacao);
                txt_resultado.Text = Calculadora.CalculaPosFixa(txt_posfixa.Text).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Equção incorreta", "My Application",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
    
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            InsertText( "0");
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            InsertText( "1");
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            InsertText( "2");
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            InsertText( "3");
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            InsertText( "4");
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            InsertText( "5");
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            InsertText( "6");
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            InsertText( "7");
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            InsertText( "8");
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            InsertText( "9");
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            InsertText( "R");
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            InsertText( "/");
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            InsertText( "*");
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            InsertText( "-");
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            InsertText( "+");
        }

        private void btn_elevar_Click(object sender, EventArgs e)
        {
            InsertText( "^");
        }
        private void btn_abreparenteses_Click(object sender, EventArgs e)
        {
            InsertText( "(");
        }

        private void btn_fechaparenteses_Click(object sender, EventArgs e)
        {
            InsertText(")");
        }
        private void FormCalculator_Load(object sender, EventArgs e)
        {
            txt_resultado.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = null;
            txt_posfixa.Text = null;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != " " && txt_resultado.Text != "")
            {
                var equacao = txt_resultado.Text.Replace(" ", ""); //remove espaços em "branco" da string
                txt_resultado.Text = equacao.Remove(equacao.Length - 1, 1);
            }
            
        }

        private void txt_resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if e.KeyChar (tecla presscionada) não for número && não for backspace, o evento e.Handled recebe true e a tecla pesscionada é ignorada; caso contrário, a tecla prescionada é aceita
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar ==(char)Keys.Back) && !(e.KeyChar.ToString() == "+") && !(e.KeyChar.ToString() == "-") && !(e.KeyChar.ToString() == "*") 
                && !(e.KeyChar.ToString() == "/") && !(e.KeyChar.ToString() == "R") && !(e.KeyChar.ToString() == "^") && !(e.KeyChar.ToString() == "(") && !(e.KeyChar.ToString() == ")"))
            {
                e.Handled = true;
            }

            if (txt_resultado.Text != " " && txt_resultado.Text != "")
            {
                if (char.IsNumber(Convert.ToChar(txt_resultado.Text.Substring(txt_resultado.Text.Length - 1, 1))) && char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(Convert.ToChar(txt_resultado.Text.Substring(txt_resultado.Text.Length - 1, 1))) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(Convert.ToChar(txt_resultado.Text.Substring(txt_resultado.Text.Length - 1, 1))) && (e.KeyChar == '(' || e.KeyChar == ')'))
                {
                    e.Handled = true;
                }
            }           
                 
        }

        private void InsertText(string text)
        {
           
            if (txt_resultado.Text != " " && txt_resultado.Text != "")
            {
                if (char.IsNumber(Convert.ToChar(txt_resultado.Text.Substring(txt_resultado.Text.Length - 1, 1))) && !char.IsNumber(Convert.ToChar(text)))
                {
                    txt_resultado.Text += text;
                }
                else if (!char.IsNumber(Convert.ToChar(txt_resultado.Text.Substring(txt_resultado.Text.Length - 1, 1))) && char.IsNumber(Convert.ToChar(text)))
                {
                    txt_resultado.Text += text;
                }
                else if (!char.IsNumber(Convert.ToChar(txt_resultado.Text.Substring(txt_resultado.Text.Length - 1, 1))) && (text == "(" || text ==")") )
                {
                    txt_resultado.Text += text;
                }
            }
            else txt_resultado.Text = text;
        }

     
    }
}
