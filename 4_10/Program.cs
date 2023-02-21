using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gal, golumn; int val, column;
            gal = Console.ReadLine();
            golumn = Console.ReadLine();
            val = Int32.Parse(gal);
            column = Int32.Parse(golumn);
            int[,] mass = new int[val, column];
            int counter = 1;

            for (int i = 0; i < val; i++)
            {
                if (i % 2 == 0)
                {

                    for (int j = 0; j < column; j++)
                    {
                        mass[i, j] = counter;
                        counter++;

                    }
                }
                else
                {
                    for (int j = column - 1; j >= 0; j--)
                    {
                        mass[i, j] = counter;
                        counter++;

                    }
                }
            }


            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("{0}\t", mass[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
