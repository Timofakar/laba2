using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main()
        {
           
            {
                string i, b, c;
                int x;
                i=Console.ReadLine();
                x = Int32.Parse(i);
                c= Convert.ToString(x, 2);
                Console.WriteLine(c);
                x = x ^ (1 << 3);
               

               b= Convert.ToString(x, 2);
                Console.WriteLine(Convert.ToString(x),b) ;
                Console.WriteLine(b);
            }
        }
    }
}
