using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        ClassOperacoes calc = new ClassOperacoes();
        //Criar um objeto chamado calc

        double valor1, valor2;

        public Form1()
        {
            InitializeComponent();
        }

        private void entradaDeDados()
        {
            valor1 = double.Parse(txtV1.Text);
            valor2 = double.Parse(txtV2.Text);
            //Método sem parâmetro e sem retorno

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            entradaDeDados();
            txtResultado.Text = calc.Subtrair(valor1, valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            entradaDeDados();
            txtResultado.Text = calc.Multiplicar(valor1, valor2).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            entradaDeDados();
            txtResultado.Text = calc.Dividir(valor1, valor2).ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtV1.Clear();
            txtV2.Clear();
            txtResultado.Clear();
            txtV1.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            entradaDeDados();
            txtResultado.Text = calc.Somar(valor1, valor2).ToString();
        }

        

    }
}
