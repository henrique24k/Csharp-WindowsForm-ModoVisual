namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {

            int numero, mult, resultado;

            numero = int.Parse(textBox1.Text);

            for (mult = 1; mult <= 10; mult++)
            {
                resultado = numero * mult;
                listBox1.Items.Add(numero + "x" + mult + "=" + resultado);
                
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}