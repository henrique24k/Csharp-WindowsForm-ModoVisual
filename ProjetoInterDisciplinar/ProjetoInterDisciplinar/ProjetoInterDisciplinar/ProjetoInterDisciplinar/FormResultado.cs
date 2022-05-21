using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterDisciplinar
{
    public partial class FormResultado : Form
    {
        public FormResultado()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o Quiz?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRefazer_Click(object sender, EventArgs e)
        {
            FormPrincipal home = new FormPrincipal();
            home.Show();
            this.Hide();
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            if ((Dados.Acerto >= 4) && (Dados.Acerto <= 7))
            {
                richTextBox1.Text = "\nAcertos:" + Dados.MostrarAcertos() + "\nErros:" + Dados.MostrarErros() + "\nPrecisa Melhorar!";
            }

            if ((Dados.Acerto >= 0) && (Dados.Acerto <= 3))
            {
                richTextBox1.Text = "\nAcertos:" + Dados.MostrarAcertos() + "\nErros:" + Dados.MostrarErros() + "\nNão apto.";
            }

            if ((Dados.Acerto >= 7) && (Dados.Acerto <= 9))
            {
                richTextBox1.Text = "\nAcertos:" + Dados.MostrarAcertos() + "\nErros:" + Dados.MostrarErros() + "\nBom!";
            }

            if (Dados.Acerto == 10) 
            {
                richTextBox1.Text = "\nAcertos:" + Dados.MostrarAcertos() + "\nErros:" + Dados.MostrarErros() + "\nParabéns Você entende mesmo!";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
