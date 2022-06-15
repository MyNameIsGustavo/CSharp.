using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    //Declarando as variáveis.
    {
        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        //Alerta de entrada inválida (1).
        {
            if(!Double.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Entrada número 1 inválida!");
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        //Alerta de entrada inválida (2).
        {
            if (!Double.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Entrada número 2 inválida!");
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        //Calculando a soma.
        {
            if (Double.TryParse(txtNumero1.Text, out resultado) &&
                (Double.TryParse(txtNumero2.Text, out resultado)))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos.");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        //Calculando a subtração.
        {
            if (Double.TryParse(txtNumero1.Text, out resultado) &&
                (Double.TryParse(txtNumero2.Text, out resultado)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos.");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        //Calculando a multiplicação.
        {
            if (Double.TryParse(txtNumero1.Text, out resultado) &&
                (Double.TryParse(txtNumero2.Text, out resultado)))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos.");
        }
        private void btnDivir_Click(object sender, EventArgs e)
        //Calculando a divisão.
        {
            if (Double.TryParse(txtNumero1.Text, out resultado) &&
                (Double.TryParse(txtNumero2.Text, out resultado)))
            {
                if (numero2 == 0)
                    MessageBox.Show("A entrada número dois não pode ser zero. Digite um número válido.");
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números inválidos!");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        //Botão de limpar.
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }
        private void btnSair_Click(object sender, EventArgs e)
        //Botão de fechar.
        {
            Close();
        }
    }
}
