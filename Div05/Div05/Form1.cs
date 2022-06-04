namespace Div05
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
            int num, div=0;

            num = int.Parse(textBox1.Text);

            while (num >=1)
            {
                listBox1.Items.Add(num);
                num--;

                if(num %5 == 0)
                {
                    div++;
                }
                

            }

            textBox2.Text = div.ToString();


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}