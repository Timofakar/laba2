using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class IntegratorQuad : Integrator
    {
        public delegate double GetY(double x);
        GetY y;
        
        public IntegratorQuad(QuadEquation equation)
        {
            this.equation = equation;
            titleMethod = "Интегрирование методом прямоугольников";
            y = equation.GetValue;
        }
        public double Integrate(double x1, double x2)
        {

            int N = 100; //Количество шагов
            double h = (x2 - x1) / N; //Ширинa шага
            double integralSum = 0;
            for (int i = 0; i < N; i++) { integralSum += y(x1 + i * h) * h; }
            return integralSum;
        }
    }
}
