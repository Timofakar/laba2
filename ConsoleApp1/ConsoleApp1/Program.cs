using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

    
    class Magazine
    {
        private string _name;
        private Frequency _period;
        private DateTime _date;
        private int _tiraj;
        private Article[] _statya;

        public Magazine(string _name, Frequency _period, DateTime _date, int _tiraj, Article[] _statya)
        {
            this._name = _name;
            this._period = _period;
            this._date = _date;
            this._tiraj = _tiraj;
            this._statya = _statya;
        }
         public Magazine()
        {

        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public Frequency Period
        {
            get => _period;
            set => _period = value;
        }
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        public int Tiraj
        {
            get => _tiraj;
            set => _tiraj = value;
        }
        public Article[] Statya
        {
            get => _statya;
            set => _statya = value;
        }
        public double GetAverageRating()
        {
            double sum = 0;
            for (int i = 0; i < Statya.Length; i++)
                sum = Statya[i].Rating;
            return sum / Statya.Length;
        }
        void AddArticles(params Article[] _statya)
        {
            Array.Resize(ref _statya, _statya.Length + 5);
            foreach (Object i in _statya)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }
        string ToFullString()
        {
            return "\n" + "Наименование:" + Name + "\n" + "ПЕриод:" + Period + "\n" + "Дата:" + "\n" + Date + "\n" + "Тираж:" + "\n" + Tiraj + "\n" + "Список статетй:" + "\n" + Statya;
        }
        string ToShortString()
        {
            return "\n" + "Наименование:" + Name + "\n" + "ПЕриод:" + Period + "\n" + "Дата:" + "\n" + Date + "\n" + "Тираж:" + "\n" + Tiraj + "\n" ;
        }
        class Program
        {
            static void Main()
            {
                var magazine = new Magazine();
               
                Console.WriteLine();

                magazine.Name = "ара";
                magazine.Period = Frequency.Yearly;
                magazine.Date = magazine.Date.AddDays(+1);
                magazine.Tiraj = 55;
               
                Console.WriteLine(magazine.ToShortString());
                Console.Read();
            }
        }



    }
}

