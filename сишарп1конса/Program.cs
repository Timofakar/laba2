using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp1
{
    
    class InputConsoleDemo
    {
        static void Main()
        {
            // Текстовая переменная:
            string name, gon;
            int born, gorn, sum, notsum;
            // Заголовок консольного окна:
            Console.Title = "Сбор данных";
            // Сообщение в консоли:
            Console.Write("Первое число : ");
            // Считывание текста:
            name = Console.ReadLine();
            born = Int32.Parse(name);
            Console.Title = "Сбор данных";
            // Сообщение в консоли:
            Console.Write("Второе число : ");
            // Считывание текста:
            gon = Console.ReadLine();
            gorn = Int32.Parse(gon);
            sum = born + gorn;
            notsum = born - gorn;
            // Еще одна текстовая переменная:
            string tхt = "Cумма =  " + sum + "\nа разность = "+notsum;
            // Заголовок консольного окна:
            Console.Title = "Результат";
            // Сообщение в консоли:
            Console.WriteLine(tхt);
            Console.ReadKey();
        }
    }
        }
