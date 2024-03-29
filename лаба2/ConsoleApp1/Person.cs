﻿using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Person
    {

        string name;
        string suname;
        DateTime birthDay;

        public Person()
        {
            name = "Пусто";
            suname = "Пусто";
            birthDay = new DateTime();
        }

        public Person(string name, string suname, DateTime birthDay)
        {
            this.name = name;
            this.suname = suname;
            this.birthDay = birthDay;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Suname
        {
            get { return suname; }
            set { suname = value; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public int BirthYear
        {
            get { return birthDay.Year; }
            set { birthDay.AddYears(value - birthDay.Year); }
        }

        public string ToFullString() { return "Имя: " + name + "Фамилия: " + suname + "Дата рождения: " + birthDay; }

        public string ToShortString() { return "Имя: " + name + "Фамилия: " + suname; }

    }

}

