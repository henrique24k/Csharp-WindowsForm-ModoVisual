using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoPessoais
{
    public partial class Form1 : Form
    {
        Usuario user1 = new Usuario(); // objeto

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            user1.nome = txtNome.Text; // aqui usamos as "variaveis" que criamos na nossa classe.
            user1.sobrenome = txtSobrenome.Text;
            user1.idade = int.Parse(txtIdade.Text);
            user1.cpf = txtCpf.Text;

            user1.Alert();
            txtNomeCompleto.Text = user1.NomeCompleto(user1.nome, user1.sobrenome);

            lblIdade.Text = user1.SituacaoIdade(user1.idade);

            bool verifica = true;

            verifica = user1.validaCPF(user1.cpf);

            if (verifica == true)
            {
                lblCpf.Text = "CPF válido!";
            }
            else
            {
                lblCpf.Text = "CPF inválido!";
            }

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtIdade.Clear();
            txtCpf.Clear();
            txtNomeCompleto.Clear();
            txtNome.Focus();
        }
    }
}
