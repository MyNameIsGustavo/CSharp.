using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Imc
{
    public partial class Form1 : Form
    {
        double imc, peso, altura;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void mskbxAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("Digite números valídos");
            }

        }
        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxPeso.Text, out peso))
            {
                MessageBox.Show("Digite números valídos");
            }

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(mskbxAltura.Text, out altura) && double.TryParse(mskbxPeso.Text, out peso))
            {
                imc = peso / (altura * altura);
                imc = Math.Round(imc, 1);
            }
            if (imc < 18.5)
            {
                MessageBox.Show("A sua classificação na tabela IMC é de Magreza e o seu grau de obesidade é igual a 0.");
            }
            else{
                if(imc >= 18.5 && imc <= 24.9)
                {
                    MessageBox.Show("A sua classificação na tabela IMC é de Normal e o seu grau de obesidade é igual a 0.");
                }
                else{
                    if (imc >= 25.0 && imc <= 29.9)
                    {
                        MessageBox.Show("A sua classificação na tabela IMC é de Sobrepeso e o seu grau de obesidade é igual a 1.");
                    }
                    else{
                        if(imc >= 30.0 && imc <= 39.9)
                        {
                            MessageBox.Show("A sua classificação na tabela IMC é de Obesidade e o seu grau de obesidade é igual a 2.");
                        }
                        else{
                            if(imc >= 40.0)
                            {
                                MessageBox.Show("A sua classificação na tabela IMC é de Obesidade Grave e o seu grau de obesidade é igual a 3.");
                            }
                        }
                    }
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
