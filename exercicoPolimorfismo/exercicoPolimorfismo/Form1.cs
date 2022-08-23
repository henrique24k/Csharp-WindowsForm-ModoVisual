using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicoPolimorfismo
{
    public partial class Form1 : Form
    {
        contaEspecial ce = new contaEspecial();
        contaPoupanca cp = new contaPoupanca();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (rbCe.Checked)
            {
                ce.creditar(double.Parse(textBox1.Text));
                lblSaldoCe.Text = Convert.ToString(ce.Saldo);
            }
            else
            {
                cp.creditar(Convert.ToDouble(textBox1.Text));
                lblSaldoCp.Text = Convert.ToString(cp.Saldo);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (rbCe.Checked)
            {
                ce.debitar(Convert.ToDouble(textBox1.Text));
                lblSaldoCe.Text = Convert.ToString(ce.Saldo);
            }
            else
            {
                cp.debitar(Convert.ToDouble(textBox1.Text));
                lblSaldoCp.Text = Convert.ToString(cp.Saldo);
            }
        }
    }
}
