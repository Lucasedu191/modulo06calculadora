using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo6Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Double numero1;
        private Double numero2;
        private String operacao;

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtDisplay.Clear();
            numero1 = 0;
            numero2 = 0;
            operacao = string.Empty;
        }



        private void AdicionarCaracterNumerico(string caracter)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + caracter;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + caracter;
            }
        }
        private void AdicionarCaractereOperacao(string caracter)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                operacao = caracter;
                txtDisplay.Clear();
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("9");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("/");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("*");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("-");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("+");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                numero2 = Convert.ToDouble(txtDisplay.Text.Trim());

            }
        }
    }
}
