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
    public partial class FormP8 : Form
    {
        public FormP8()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rb23.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            FormP9 Q9 = new FormP9();
            Q9.Show();
            this.Hide();
        }
    }
}
