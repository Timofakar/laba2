using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal enum Frequency { Weekly, Monthly, Yearly }






    class Program
    {
        static void Main(string[] args)

        {

            DateTime date1 = new DateTime(2000, 6, 6);
            ConsoleApp1.Person author1 = new Person(
                    "Лев",
                    "Толстой",
                    date1);
            ConsoleApp1.Article a1 = new ConsoleApp1.Article(author1, "Война и мир", 3.5);

            DateTime date2 = new DateTime(1500, 12, 11);
            Person author2 = new Person("Владислав", "Ольгович", date2);
            ConsoleApp1.Article a2 = new ConsoleApp1.Article(author2, "Атака атакует", 2.4);
            ConsoleApp1.Article a3 = new ConsoleApp1.Article(author2, "Водолазка", 4.6);

            Magazine magazine = new Magazine("Журналище", 0, DateTime.Today, 2);

            magazine.AddArticles(a1, a2, a3);


            Console.WriteLine($"Короткое представление информации о журнале\n{magazine.ToShortString()}");
            Console.WriteLine($"Полное представление информации о журнале\n{magazine.ToFullString()}");

            magazine.Name = "Изменёнус";
            magazine.Tiraj = 100500;
            magazine.Date = date1;
            magazine.Period = ConsoleApp1.Frequency.Monthly;

            Console.WriteLine(magazine.ToFullString());




            Console.ReadLine();
        }
    }
}

