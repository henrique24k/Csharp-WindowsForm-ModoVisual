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
    public partial class FormP5 : Form
    {
        public FormP5()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rb14.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            FormP6 Q6 = new FormP6();
            Q6.Show();
            this.Hide();
        }
    }
}
