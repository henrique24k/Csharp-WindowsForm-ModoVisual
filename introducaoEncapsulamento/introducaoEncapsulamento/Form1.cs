using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introducaoEncapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cl_Calculo Calculo = new cl_Calculo();

            double precoInicial = double.Parse(txtValor.Text);

            int tipoProduto = 0;

            if (rbLeite.Checked)
            {
                tipoProduto = 1;
            }
            else if (rbMartelo.Checked)
            {
                tipoProduto = 2;
            }
            else if (rbProtetorSolar.Checked)
            {
                tipoProduto = 3;
            }

            double resultado = Calculo.CalculaPrecoFinal(precoInicial, tipoProduto);

            lblResultado.Text = resultado.ToString();

        }
    }
}
