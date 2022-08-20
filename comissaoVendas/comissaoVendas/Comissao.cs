using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comissaoVendas
{
    class Comissao
    {
        private double percentagem1 = 10;
        private double percentagem2 = 15;
        private double percentagem3 = 20;

        public double calcularComissao(double vVenda, string CategoriaV)
        {
            double vComissao = 0;

            switch (CategoriaV)
            {
                case "a":
                    vComissao = vVenda * (percentagem1 / 100);
                    break;

                case "b":
                    vComissao = vVenda * (percentagem2 / 100);
                    break;

                case "c":
                    vComissao = vVenda * (percentagem3 / 100);
                    break;
            }
            return vComissao;
        }

    }
}
