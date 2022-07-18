using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal primeiroValor = 0, segundoValor = 0;
        string operacao = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if(operacao == "SOMA")
            {
                segundoValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(primeiroValor + segundoValor);
            }
            else if (operacao == "SUB")
            {
                segundoValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(primeiroValor - segundoValor);
            }
            else if (operacao == "DIVISÂO")
            {
                segundoValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(primeiroValor / segundoValor);
            }
            else if(operacao == "MULTIPLICAR")
            {
                segundoValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(primeiroValor * segundoValor);
            }
            else
            {
                MessageBox.Show($"Selecione uma Opereção", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            if(txtResultado.Text != null && operacao != "SUB")
            {
                primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = string.Empty;
                operacao = "SUB";
                lbperacao.Text = "-";
            }
            else
            {
                MessageBox.Show($"Selecione uma Opereção", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != null)
            {
                primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = string.Empty;
                operacao = "MULTIPLICAR";
                lbperacao.Text = "X";
            }
            else
            {
                MessageBox.Show($"Selecione uma Opereção", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != null && operacao != "DIVISÂO")
            {
                primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = string.Empty;
                operacao = "DIVISÂO";
                lbperacao.Text = "÷";
            }
            else
            {
                MessageBox.Show($"Selecione uma Opereção", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lbperacao.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            primeiroValor = 0;
            segundoValor = 0;
            lbperacao.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != null && operacao != "SOMA")
            {
                primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = string.Empty;
                operacao = "SOMA";
                lbperacao.Text = "+";
            }
            else
            {
                MessageBox.Show($"Selecione uma Opereção", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }
    }
}
