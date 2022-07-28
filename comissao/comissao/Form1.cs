using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comissao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double comissao (string categoria, double venda)
        {
      

            if((categoria == "A") || (categoria == "a"))
            {
                return venda * 0.1;
            }
            else
            {
                return venda * 0.15;
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double venda;
            string categoria;

            venda = double.Parse(txtVenda.Text);
            categoria = txtCategoria.Text.ToUpper();

            txtComissao.Text = comissao(categoria, venda).ToString();




        }
    }
}
