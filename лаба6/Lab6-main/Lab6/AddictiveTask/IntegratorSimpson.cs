using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class IntegratorSimpson : Integrator
    {
        public IntegratorSimpson(Equation equation)
        {
            this.equation = equation;
            titleMethod = "Интегрирование методом Симпсона";
        }
        public double Integrate(double x1, double x2)
        {
            int N = 100; //Количество шагов
            double h = (x2 - x1) / N; //Ширинa шага
            double integralSum = 0;
            double x = x1 + h;
            while (x < x2)
            {
                integralSum += 4 * equation.GetValue(x);
                x += h;
                if(x >= x2)
                    break;
                integralSum += 2 * equation.GetValue(x);
                x += h;
            }
            integralSum = (h / 3) * (integralSum + equation.GetValue(x1) + equation.GetValue(x2));
            return integralSum;
        }
    }
}
