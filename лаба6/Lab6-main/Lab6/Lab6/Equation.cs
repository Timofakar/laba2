﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Equation
    {
        public abstract double GetValue(double x);
        public void DrawGraph()
        {
            var form = new FunctionGraph(this);
            form.ShowDialog();
        }
    }
}
