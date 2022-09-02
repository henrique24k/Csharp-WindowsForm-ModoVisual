using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introClasseAbstrata
{
    public partial class rbDw : Form
    {
        public rbDw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Programador p1 = new Programador();
            Designer d1 = new Designer();
            DesenvolvedorWeb dw1 = new DesenvolvedorWeb();

            decimal salario;
            string nome;

            salario = Convert.ToDecimal(txtSalario.Text);
            nome = txtNome.Text;

            if (rbD.Checked)
            {
                d1.Salario = salario;
                d1.Reajustar();
                lblResultado.Text = d1.Salario.ToString();
            }
            else if(rbP.Checked)
            {
                p1.Salario = salario;
                p1.Reajustar();
                lblResultado.Text = p1.Salario.ToString();

            }
            else
            {
                dw1.Salario = salario;
                dw1.Reajustar();
                lblResultado.Text = dw1.Salario.ToString();
            }

        }
    }
}
