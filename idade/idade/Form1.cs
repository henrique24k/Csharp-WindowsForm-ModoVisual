using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string maioridade(int idade)
        {
            if(idade >= 18)
            {
                return "Maior de Idade";
            }
            else
            {
                return "Menor de idade";
            }
        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            int idade;
            idade = int.Parse(txtIdade.Text);
            txtSituacao.Text = maioridade(idade);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtSituacao.Clear();
            txtIdade.Focus();


        }
    }
}
