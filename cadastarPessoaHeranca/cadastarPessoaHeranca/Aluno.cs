using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastarPessoaHeranca
{
    internal class Aluno : Pessoa // vai herda da classe pessoa
    {
        public int nMatricula;
        public string curso;

        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + " Idade: " + idade.ToString() +
                 " Matrícula: " + nMatricula.ToString() + " Curso: " + curso, "Usuario Cadastrado");
        }

    }
}
