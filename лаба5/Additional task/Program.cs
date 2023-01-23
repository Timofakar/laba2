using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Additional_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "Добро пожаловать в наш магазин, вот наши цены:" +
                             " 1 кг. яблоки - 90 руб., 2 кг. апельсины - 130 руб. " +
                             "Также в ассортименте орехи в следующей фасовке: 0.5 кг. миндаль - 500 руб.";

            var regex = new Regex(@"(?<weight>\d*(\.\d\d)?кг).*(?<product>[а-я]+\s-).*(?<price>\d*(\.\d\d)?руб)");
            MatchCollection collection = regex.Matches(example);

            foreach (Match m in collection)
            {
                Console.WriteLine(m.ToString());
            }

            double weight;
            double priceByKg;
            var digit = new Regex(@"\d+(\.\d)?");

            
            }
        }

    }
}
