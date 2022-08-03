using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introPoo
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        public void Falar()
        {
            System.Windows.Forms.MessageBox.Show("Olá meu nome  é " + nome + " e tenho " + idade + " anos.");
        
        }

        public string nomeCompleto(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        public string situacao(int idade)
        {
            if(idade >= 18)
            {
                return "maior de idade";
            }
            else
            {
                return "Menor de idade";
            }
        }
    }
}
