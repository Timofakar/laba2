using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            var Job = new List<ParProduct>()
            {
                new ParProduct()
                {
                    Tovar="картошка",
                    kategory="закупка",
                    Postavshik="Беларусь",
                    Nomer=12,
                    Date= new DateTime(12,02,2023),
                    Kolichestvo=25,
                    Priznak="есть"
                },
            new ParProduct()
                {
                    Tovar="картошка",
                    kategory="Производство",
                    Postavshik="Беларусь",
                    Nomer=13,
                    Date= new DateTime(12,02,2022),
                    Kolichestvo=26,
                    Priznak="Нет"
                }
            };
            iJob.ItemsSource = Job;
            BJob.ItemsSource = Job;
        }
        public class ParProduct
        {
            public string Tovar { get; set; }
            public string kategory { get; set; }
            public string Postavshik { get; set; }
            public int Nomer { get; set; }
            public DateTime Date { get; set; }
            public int Kolichestvo { get; set; }
            public string Priznak { get; set; }



        }

    }
}
