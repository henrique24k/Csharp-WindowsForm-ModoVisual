using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoEncapsulamento
{
    class cl_Calculo
    {
        private double porcentegem1 = 5;
        private double porcentagem2 = 10;
        private double porcentegem3 = 20;

        public double CalculaPrecoFinal(double precoInicial, double tipoProduto)
        {
            double precoFinal = 0;

            switch (tipoProduto)
            {
                case 1:
                    precoFinal = precoInicial + (precoInicial * (porcentegem1 / 100));
                    break;

                case 2:
                    precoFinal = precoInicial + (precoInicial * (porcentagem2 / 100));
                    break;

                case 3:
                    precoFinal = precoInicial + (precoInicial * (porcentegem3 / 100));
                    break;
            }
            return precoFinal;
        }

    }
}
