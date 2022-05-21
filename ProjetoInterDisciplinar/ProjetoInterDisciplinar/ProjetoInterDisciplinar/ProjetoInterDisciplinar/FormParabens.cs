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
    public partial class FormParabens : Form
    {
        public FormParabens()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se Você sair os dados salvos serão perdidos" + "\n" +
                "Deseja continuar ?", "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
 
        }

        private void btnResultador_Click(object sender, EventArgs e)
        {
            FormResultado r = new FormResultado();
            r.Show();
            this.Hide();

        }
    }
}
