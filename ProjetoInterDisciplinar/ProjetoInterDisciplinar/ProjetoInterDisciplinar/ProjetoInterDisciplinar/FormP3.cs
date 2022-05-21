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
    public partial class FormP3 : Form
    {
        public FormP3()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rb7.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            FormP4 Q4 = new FormP4();
            Q4.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
