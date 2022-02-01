using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO3
{
    public partial class Form1 : Form
    {
        decimal n1, n2, n3, result;
        Operations op = new Operations();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            errorsValidation();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanFields();
        }

        private void textBN1_TextChanged(object sender, EventArgs e)
        {
            textBResult.Clear();
        }

        private void textBN2_TextChanged(object sender, EventArgs e)
        {
            textBResult.Clear();
        }

        private void textBN3_TextChanged(object sender, EventArgs e)
        {
            textBResult.Clear();
        }

        private void textBN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void verticalCentered()
        {
            textBResult.ForeColor = Color.Red;
            textBResult.TextAlign = HorizontalAlignment.Center;
            int a = textBResult.Size.Height;
            float c = textBResult.Font.Height;
            for (int i = 0; i < (int)(a / c) / 3; i++)
            {
                textBResult.Text += "\r\n";
            }
        }

        private void errorsValidation()
        {
            if(textBN1.Text == "" || textBN2.Text == "" || textBN3.Text == "")
            {
                verticalCentered();
                textBResult.Text += "preencha todos os campos";
            }
            else
            {
                n1 = decimal.Parse(textBN1.Text);
                n2 = decimal.Parse(textBN2.Text);
                n3 = decimal.Parse(textBN3.Text);

                if(n1 > 10 || n2 > 10 || n3 > 10 || n1 < 0 || n2 < 0 || n3 < 0)
                {
                    verticalCentered();
                    textBResult.Text += "insira uma nota válida";
                }
                else
                {
                    finalCalc();
                }
            }
        }

        private void finalCalc()
        {
            n1 = decimal.Parse(textBN1.Text);
            n2 = decimal.Parse(textBN2.Text);
            n3 = decimal.Parse(textBN3.Text);
            result = op.MediaAritimetica(n1, n2, n3);
            verticalCentered();
            lblMedia.Text = result.ToString("N1");

            if (result >= 7)
            {
                lblMedia.ForeColor = Color.Green;
                textBResult.ForeColor = Color.Green;
                textBResult.Text += "aluno aprovado!";
            }
            else if(result < 7 && result >= 4)
            {
                lblMedia.ForeColor = Color.OrangeRed;
                textBResult.ForeColor = Color.OrangeRed;
                textBResult.Text += "aluno em recupração";
            }
            else if(result < 4)
            {
                lblMedia.ForeColor = Color.Red;
                textBResult.Text += "aluno reprovado";
            }
        }

        private void cleanFields()
        {
            textBN1.Clear();
            textBN2.Clear();
            textBN3.Clear();
            lblMedia.Text = "";
            textBResult.Clear();
            textBN1.Focus();
        }
    }
}
