using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comissaoVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Comissao comissao = new Comissao();

            double venda = double.Parse(txtVvenda.Text);

            string categoria = "";

            if (rbA.Checked)
            {
                categoria = "a";
            }
            else if (rbB.Checked)
            {
                categoria = "b";
            }
            else if (rbC.Checked)
            {
                categoria = "c";
            }

            double resultado = comissao.calcularComissao(venda, categoria);

            txtVcomissao.Text = resultado.ToString();

        }
    }
}
