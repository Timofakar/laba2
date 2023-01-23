using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class IntegratorTrap : Integrator
    {
        public IntegratorTrap(Equation equation)
        {
            this.equation = equation;
            titleMethod = "Интегрирование методом трапеций";
        }
        public double Integrate(double x1, double x2)
        {
            int N = 100;
            double h = (x2 - x1) / N;
            double integralSum = 0;
            for (int i = 1; i < N; i++) 
            {
                double xCurrent = x1 + i * h;
                double xNext = x1 + (i + 1) * h;
                integralSum += 0.5*(xNext - xCurrent) * (equation.GetValue(xCurrent) + equation.GetValue(xNext));
            }
            return integralSum;
        }
    }
}
