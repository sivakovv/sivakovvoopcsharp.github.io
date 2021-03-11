﻿using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Menu();
        }

    }
    class Student
    {
        List<People> people = new List<People>();
        public void InputInfo()
        {
            Console.WriteLine("Введите имя");
            String name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            String Age = Console.ReadLine();
            Console.WriteLine("Введите пол");
            String Sex = Console.ReadLine();
            Console.WriteLine("Введите телефон");
            String Telephone = Console.ReadLine();
            people.Add(new People() { Name = name, Age = Age, Sex = Sex, Telephone = Telephone });
        }
        public void GetInfo()
        {
            foreach (People p in people)
            {
                Console.WriteLine("Имя: " + p.Name);
                Console.WriteLine("Фамилия: " + p.Age);
                Console.WriteLine("Отчество: " + p.Sex);
                Console.WriteLine("Номер телефона: " + p.Telephone);
            }
        }
        public void GetSolo()
        {
            Console.WriteLine("Введите номер студента");
            int poz = Convert.ToInt32(Console.ReadLine());
            poz--;
            if (poz < people.Count)
            {

                Console.WriteLine("Имя: " + people[poz].Name);
                Console.WriteLine("Фамилия: " + people[poz].Age);
                Console.WriteLine("Отчество: " + people[poz].Sex);
                Console.WriteLine("Номер телефона: " + people[poz].Telephone);
            }
            else Console.WriteLine("Введите правильный номер студента");
        }

        public void ChangeStudent()
        {
            Console.WriteLine("Введите номер студента, которого хотите изменить");
            int poz = Convert.ToInt32(Console.ReadLine());
            if (poz < people.Count)
            {
                poz--;
                Console.WriteLine("Введите имя");
                people[poz].Name = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                people[poz].Age = Console.ReadLine();
                Console.WriteLine("Введите пол");
                people[poz].Sex = Console.ReadLine();
                Console.WriteLine("Введите телефон");
                people[poz].Telephone = Console.ReadLine();
            }
            else Console.WriteLine("Введите правильный id");
        }
       
        public void Menu()
        {
            Console.WriteLine("Выберите действие: + - новый студент, == - посмотреть всёх студентов, ? - посмотреть определенного студента, +- - изменить студента");
           string quer =Console.ReadLine();
            if(quer=="+")
            {
                InputInfo();
                Menu();
            }
            if (quer == "==")
            {
                Console.WriteLine("Всё студенты:");
                GetInfo();
                Menu();
            }
            if (quer == "?")
            {
                GetSolo();
                Menu();
            }
            if (quer == "+-")
            {
                ChangeStudent();
                Menu();
            }
        }
    }
    class People
    {
        public string Name;
        public string Age;
        public string Sex;
        public string Telephone;
    }
}

