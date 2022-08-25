using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularArea
{
    class Retangulo
    {
        public virtual double CalcularArea(double Base, double Altura)
        {
            double Area; 
            Area = Base * Altura;
            return Area;
        }
    }
}
