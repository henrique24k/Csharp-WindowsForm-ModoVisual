using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularArea
{
    class Triangulo : Retangulo
    {
        public virtual double CalcularArea(double Base, double Altura)
        {
            double Area;
            Area = (Base * Altura) / 2;
            return Area;
        }
    }
}

