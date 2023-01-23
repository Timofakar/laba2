using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab6
{
    public partial class FunctionGraph : Form
    {
        public FunctionGraph(Equation equation)
        {
            InitializeComponent();
            this.equation = equation;
        }
        Equation equation;

        private void bntDraw_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double x1 = double.Parse(tbLeft.Text);
            double x2 = double.Parse(tbRight.Text);
            double h = 0.1; 
            while(x1 <= x2) 
            {
                chart1.Series[0].Points.AddXY(x1, equation.GetValue(x1));
                x1 += h;
            }
        }

        private void tbLeft_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
