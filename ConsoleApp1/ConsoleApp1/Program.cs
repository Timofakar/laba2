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
    class Magazine
    {
        private string name;
        private Frequency period;
        private DateTime date;
        private int tiraj;
        private List<Article> statya = new List<Article> ();

        private string Name
        {
            get { return name; }
            set { name = value; }
        }

       
        private Frequency Period
        {
            get { return period; }
            set { period=value; }
        }
        private DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private int Tiraj
        {
            get { return tiraj; }
            set { tiraj = value; }
        }
        private List<Article> statyaProperty
        {
            get { return statya; }
            set { statya = value; }
        }
        


}

