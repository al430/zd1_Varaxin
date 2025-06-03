using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_1
{
    class Cat
    {
        private string name;
        private double weight;

        // конструктор только с именем
        public Cat(string CatName)
        {
            Name = CatName;
        }

        // конструктор только с весом
        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }

        // защищенный конструктор
        public Cat(string CatName, string CatWeight)
        {
            Name = CatName;

            double w;
            if (double.TryParse(CatWeight, out w))
            {
                Weight = w;
            }
            else
            {
                Console.WriteLine("Вес имеет некорректный формат");
            }

            
        }

        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                    
                }
            }
        }

        // свойство ввода веса
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0.1 || value > 1000)
                {
                    Console.WriteLine($"{value} - вес не может быть меньше 0,1 кг");
                }
                else
                {
                    weight = value;
                }
            }
        }

        // метод мяукония кота
        public void Meow()
        {
            if (!(name == "")) Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }

        
    }
}
