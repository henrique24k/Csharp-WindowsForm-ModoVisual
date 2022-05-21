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
    public partial class FormP6 : Form
    {
        public FormP6()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rb16.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            FormP7 Q7 = new FormP7();
            Q7.Show();
            this.Hide();
        }
    }
}
