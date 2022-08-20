using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoCompleteCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            CEP_CorreioService(txtCep.Text);
        }

        private void CEP_CorreioService(String CEP)
        {

            try
            {
                refCorreios.AtendeClienteClient correios = new refCorreios.AtendeClienteClient();
                refCorreios.enderecoERP consulta = correios.consultaCEP(CEP);
                if (consulta != null)
                {
                    txtEnd.Text = consulta.end;
                    txtBairro.Text = consulta.bairro;
                    txtCid.Text = consulta.cidade;
                    txtUf.Text = consulta.uf;
                    txtNum.Focus();
                }
                else
                {
                    MessageBox.Show("Cep não encontrado!");
                }
            }
            catch
            {
                MessageBox.Show("Cep inválido!!");
            }

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        }
    }
}
