using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicoPolimorfismo
{
    class Conta
    {
        // herança, virtual, override
        private double saldo;

        public double Saldo { get => saldo; set => saldo = value; } /*Aqui criamos com o botão direito*/

        public virtual void creditar(double valor)
        {
            saldo += valor;
        }

        public virtual void debitar(double valor)
        {
            saldo -= valor;
        }

    }
}
