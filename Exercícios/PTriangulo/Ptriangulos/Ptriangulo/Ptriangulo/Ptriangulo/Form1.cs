using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        double LadoA, LadoB, LadoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbxA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbxA.Text,out LadoA))
            {
                MessageBox.Show("Digite Números Validos");
                
            }

        }

        private void txtbxB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbxB.Text, out LadoB))
            {
                MessageBox.Show("Digite Números Validos");
                
            }
        }

        private void txtbxC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbxC.Text, out LadoC))
            {
                MessageBox.Show("Digite Números Validos");
                
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((LadoA < (LadoB + LadoC)) &&
                    (LadoA > Math.Abs(LadoB - LadoC)) &&
                        (LadoB < (LadoA + LadoC)) &&
                                (LadoB > Math.Abs(LadoA - LadoC)) &&
                                    (LadoC < (LadoA + LadoB)) &&
                                        (LadoC > Math.Abs(LadoA - LadoB)))
            {
                
                if ((LadoA == LadoB) && (LadoB == LadoC))
                {
                    MessageBox.Show("Triângulo Equilátero.");
                }
                else
                    if ((LadoA == LadoB) || (LadoB == LadoC) || (LadoA == LadoC))
                    {
                        MessageBox.Show("Triângulo Isósceles.");
                    }
                     else
                         {
                           MessageBox.Show("Triângulo Escaleno.");
                         }      
            }
            else{
                MessageBox.Show("Os números informados não formam um triângulo. Tente Novamente.");
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbxA.Clear();
            txtbxB.Clear();
            txtbxC.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
