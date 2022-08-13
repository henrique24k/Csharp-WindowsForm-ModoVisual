using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastarPessoaHeranca
{
    internal class Professor : Pessoa
    {
        public string disciplina;
        public float salario;

        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + " Idade: " + idade.ToString() +
                 " Disciplina: " + disciplina + " Salario: " + salario.ToString(), "Usuario Cadastrado");
        }

    }
}
