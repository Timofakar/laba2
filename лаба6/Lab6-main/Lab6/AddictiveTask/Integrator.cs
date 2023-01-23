using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab6
{
    public abstract class Integrator
    {
        protected string titleMethod;
        public string TitleMethod { get { return titleMethod; } }
        protected Equation equation;
    }
}
