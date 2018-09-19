﻿using System;
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
        private double resultado;


        private Boolean PressionouIgual; 
            
            

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtDisplay.Clear();
            numero1 = 0;
            numero2 = 0;
            resultado = 0;
            operacao = string.Empty;
            PressionouIgual = false;
        }



        private void AdicionarCaracterNumerico(string caracter)
        {
            if(PressionouIgual == true)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
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
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace("." , ","));
                }
                else
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
 
                operacao = caracter;
                txtDisplay.Clear();

            }
            else
            {
                MessageBox.Show("Você de inserir um valor");
            }
        }

        private void Calcular()
        {
            switch(operacao)
            {
               
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Divisão por zero!");
                        break;
                    }
                        resultado = numero1 / numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "^":
                    resultado = CalcularPotencia();
                    break;
            }
            txtDisplay.Text = resultado.ToString().Replace(",",".") ;
        }
        private Double CalcularPotencia()
        {
             return  Math.Pow(numero1, numero2);
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

            if (PressionouIgual)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
                return;
            }
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                }

                Calcular();
                PressionouIgual = true;

            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {
                txtDisplay.Text = "0.";
                PressionouIgual = false;
                return;
            }
            if (txtDisplay.Text.Trim().Equals(string.Empty)) txtDisplay.Text = "0.";
            if (txtDisplay.Text.Trim().Contains(".")) return;
            txtDisplay.Text = txtDisplay.Text +  ".";
         
     
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (operacao.Equals(string.Empty)|| PressionouIgual)
            {
                LimparCampos();
            }
            else
            {
                txtDisplay.Clear();
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ",")) * (-1)).ToString().Replace(",", ".");
            }
        }

        private void btnRemoveUltimoDigito_Click(object sender, EventArgs e)
        {
            int tam = txtDisplay.Text.Trim().Length;
            string texto = txtDisplay.Text.Trim();
            txtDisplay.Clear();
            for (int i = 0; i< tam -1;i++)
            {
                txtDisplay.Text = txtDisplay.Text + texto[i];
            }
        }

        private void btnElevaAoQuadrado_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
               numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".",","));
                numero2 = 2;
                var result = CalcularPotencia();
                txtDisplay.Text = result.ToString().Replace(",", ".");
                PressionouIgual = true;
            }
        }

        private void btnPotenciacao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("^");
        }
    }
}
