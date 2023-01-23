using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e1 = new QuadEquation(1, 2, 3);
            e1.DrawGraph();
        }
    }
}
