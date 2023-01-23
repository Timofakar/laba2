using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    internal class Article
    {

        public Person Author { get; set; }

        public string Namen { get; set; }

        public double Rating { get; set; }


        public Article(Person author, string namen, double rating)
        {
            Author = author;
            Namen = namen;
            Rating = rating;
        }

        public Article(ConsoleApp1.Person author1)
        {
            Author = new Person();
            Namen = "Неизвестно";
            Rating = 0;
        }

        public override string ToString()
        {
            //todo:возвращать текстовое описание объекта
            return base.ToString();
        }

        public string ToFullString() { return "Автор: " + Author.ToFullString() + "Название статьи: " + Namen + "Рейтинг статьи: " + Rating; }

    }
}

