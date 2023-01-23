using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class IntegratorTrap : Integrator
    {
        public IntegratorTrap(QuadEquation equation)
        {
            this.equation = equation;
            titleMethod = "Интегрирование методом трапеций";
        }
        public double Integrate(double x1, double x2)
        {
            int N = 100;
            double h = (x2 - x1) / N;
            double integralSum = equation.GetValue(x1) + equation.GetValue(x2);
            for (int i = 1; i < N; i++) 
            {
                integralSum += equation.GetValue(x1 + i*h);
            }
            integralSum *= h;
            return integralSum;
        }
    }
}
