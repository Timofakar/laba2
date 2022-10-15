using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal enum Frequency { Weekly, Monthly, Yearly }

    public class Article
    {
        public Article(string name, double rating, Person author)
        {
            Name = name;
            Rating = rating;
            Author = author;
        }
        public Article()
            : this("без названия", 0, new Person(" нет автора"))
        {
        }
        public string Name { get; set; }
        public double Rating { get; set; }
        public Person Author { get; set; }
        public virtual string ToFullString()
            => $" ${Name} с рейтингом {Rating} от {Author}";

    }
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main()
        {


        }
    }

}

