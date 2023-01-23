using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Magazine
    {
        private string _name;
        private ConsoleApp1.Frequency _period;
        private DateTime _date;
        private int _tiraj;
        public ConsoleApp1.Article[] _statyas;
        private string v1;
        private int v2;
        private DateTime today;
        private int v3;

        public Magazine(string _name, ConsoleApp1.Frequency _period, DateTime _date, int _tiraj, ConsoleApp1.Article[] _statya)
        {
            this._name = _name;
            this._period = _period;
            this._date = _date;
            this._tiraj = _tiraj;
            this._statyas = _statya;
        }
        public Magazine()
        {

        }

        public Magazine(string v1, int v2, DateTime today, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.today = today;
            this.v3 = v3;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public ConsoleApp1.Frequency Period
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

        public double GetAverageRating
        {
            get
            {
                return _statyas.Average(Article => Article.Rating);
            }
        }
        public void AddArticles(params ConsoleApp1.Article[] Statya)
        {
            ConsoleApp1.Article[] jam = new ConsoleApp1.Article[(_statyas?.Length ?? 0) + Statya.Length];


            for (int i = 0; i < (_statyas?.Length ?? 0); i++)
            {
                jam[i] = _statyas[i];
            }

            for (int i = (_statyas?.Length ?? 0), j = 0; i < jam.Length; i++, j++)
            {
                jam[i] = Statya[j];
            }

            _statyas = jam;
        }
        public string ToFullString()
        {
            string Catalog = String.Empty;
            String Megahit=String.Empty;
            int maxPrime = 100;
            Article[] _statyas = GetPrimes(maxPrime);
            string separator = ", ";
            //todo: объединить статьи используя string.join
            //todo: еще какой-то способ
                      {
                Megahit += String.Join(separator, _statyas);
                Console.WriteLine("kdfvsidfvsdfvsdv");
                Console.WriteLine(Megahit);

            }

            return $"Название: {_name}\nПериодичность: {_period}\nДата релиза: {_date}\nТираж номер: {_tiraj}\nСписок статей:\n{Megahit.ToString()}";
        }

        private Article[] GetPrimes(int maxPrime)
        {
            throw new NotImplementedException();
        }

        public string ToShortString()
        {
            return $"Название: {_name}\nПериодичность: {_period}\nДата релиза: {_date}\nТираж номер: {_tiraj}\nСредний рейтинг статей: {Convert.ToString(GetAverageRating)}";
        }

    }
}
