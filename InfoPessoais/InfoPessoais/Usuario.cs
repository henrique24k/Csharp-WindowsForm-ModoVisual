using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoPessoais
{
    class Usuario
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public string cpf;

        public void Alert() // método sem retorno, com messagebox
        {
            System.Windows.Forms.MessageBox.Show
                ("Ola meu nome é " + nome + " e tenho " + idade + " anos.");
        }

        public string NomeCompleto(string nome, string sobrenome)// método com retorno do tipo strign
        {
            return nome + " " + sobrenome; 
        }

        public string SituacaoIdade(int idade) // método com retorno e condição
        {
            if(idade >= 18)
            {
                return "Maior de idade";
            }
            else
            {
                return "menor de idade";
            }
        }

        public bool validaCPF(string cpf) // método para a validação do Cpf
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

    }
}
