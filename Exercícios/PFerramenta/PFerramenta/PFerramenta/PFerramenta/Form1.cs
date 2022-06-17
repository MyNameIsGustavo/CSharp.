using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramenta
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=APOLO;Initial Catalog=LP2;User ID=BD2121034; Password=Banana123");

                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch(Exception ex)
            {   
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void cadastroFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmFerramenta"];

            if (fc != null)
                fc.Close();

            FrmFerramenta frm1 = new FrmFerramenta();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmSobre"];

            if (fc != null)
                fc.Close();

            frmSobre frm1 = new frmSobre();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }
    }
}
