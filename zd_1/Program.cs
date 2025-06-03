using System;

namespace zd_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Сколько котов вы хотите ввести");
                int countCat = Convert.ToInt32(Console.ReadLine());
                Cat[] cats = new Cat[countCat];

                // цикл для ввода котов
                for (int i = 0; i < countCat; i++)
                {
                    Console.WriteLine($"{i+1} кот. Введите имя и вес (в разных строках)");
                    cats[i] = new Cat(Console.ReadLine(), Console.ReadLine());
                    cats[i].Meow();
                }
            } 
            catch
            {
                Console.WriteLine("Ошибка типов данных");
            }
        }
    }
}
