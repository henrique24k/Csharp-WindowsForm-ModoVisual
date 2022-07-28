using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public string imc (double peso, double altura)
        {
            double imc;

            imc = peso / (altura * altura);

            if(imc > 25)
            {
                return "Acima do peso";
            }
            else if (imc < 18)
            {
                return "Abaixo do peso";
            }
            else
            {
                return "Peso Normal";
            }

        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);


            txtResultado.Text = imc(peso, altura);
        }
    }
}
