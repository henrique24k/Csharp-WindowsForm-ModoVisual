namespace cadastarPessoaHeranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno objAluno = new Aluno();

            objAluno.nome = txtNome.Text;
            objAluno.idade = int.Parse(txtIdade.Text);
            objAluno.nMatricula = int.Parse(txtMatricula.Text);
            objAluno.curso = txtCurso.Text;
            objAluno.exibir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor objProfessor = new Professor();

            objProfessor.nome = txtNomeP.Text;
            objProfessor.idade = int.Parse(txtIdadeP.Text);
            objProfessor.disciplina = txtDisciplina.Text;
            objProfessor.salario = float.Parse(txtSalario.Text);
            objProfessor.exibir();

        }
    }
}