using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularArea
{
    public partial class Form1 : Form
    {
        Retangulo re = new Retangulo();
        Triangulo tri = new Triangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            double baseRe;
            double altura;

            baseRe = double.Parse(txtBase.Text);
            altura = double.Parse(txtAltura.Text);

            txtArea.Text = (re.CalcularArea(baseRe, altura)).ToString();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            double baseTri;
            double altura;

            baseTri = double.Parse(txtBase.Text);
            altura = double.Parse(txtAltura.Text);

            txtArea.Text = (tri.CalcularArea(baseTri, altura)).ToString();
        }
    }
}
