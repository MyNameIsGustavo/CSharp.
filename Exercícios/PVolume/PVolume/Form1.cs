﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            Double raio;

            if (!Double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
                // textBox1.Focus();
            }
            else
                if (raio <=0)
            {
                MessageBox.Show("O raio deve ser maior que zero.");
                // textBox1.Focus();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            Double altura;

            if (!Double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
                // textBox2.Focus();
            }
            else
                if (altura <= 0)
            {
                MessageBox.Show("A altura deve ser maior que zero.");
                // textBox2.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double raio;

            if (!Double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
                textBox1.Focus();
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("O raio deve ser maior que zero.");
         
                textBox1.Focus();
            }
            else // Testando a altura.
            {
                Double altura;

                if (!Double.TryParse(textBox2.Text, out altura))
                {
                    MessageBox.Show("Altura inválida!");
                    textBox2.Focus();
                }
                else
                    if (altura <= 0)
                {
                    MessageBox.Show("A altura deve ser maior que zero.");
                    textBox2.Focus();
                }
                else // Calculando...
                {
                    // Formula: Volume = PI * Raio^2 * Altura

                    Double volume;

                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    textBox3.Text = volume.ToString("N2");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
