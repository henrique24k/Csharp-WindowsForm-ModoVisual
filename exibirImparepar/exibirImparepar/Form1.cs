using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exibirImparepar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int inicio, final, impar = 0, par = 0;

            inicio = int.Parse(textBox1.Text);
            final = int.Parse(textBox2.Text);

            while(inicio <= final)
            {
                listBox1.Items.Add(inicio);
                inicio++;

                if (inicio %2 ==0)
                {
                    impar++;
                }
                else
                {
                    par++;
                }
            }

            textBox3.Text = impar.ToString();
            textBox4.Text = par.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
