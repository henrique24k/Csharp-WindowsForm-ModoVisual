using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    class ClassOperacoes
    {
        public double Somar(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Subtrair(double v1, double v2)
        {
            return v1 - v2;
        }

        public double Multiplicar(double v1, double v2)
        {
            return v1 * v2;
        }

        public double Dividir(double v1, double v2)
        {
            if(v2==0)
            {
                return 0;
            }
            else
            {
                return v1 / v2;
            }
        }
    }
}
