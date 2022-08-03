using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introPoo
{
    public partial class Form1 : Form
    {
        Pessoa p1 = new Pessoa();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            p1.nome = txtNome.Text;
            p1.sobrenome = txtSobrenome.Text;
            p1.idade = int.Parse(txtIdade.Text);

            p1.Falar();
            txtExibir.Text = p1.nomeCompleto(p1.nome, p1.sobrenome);

            lblSituacao.Text = p1.situacao(p1.idade);



        }
    }
}
