using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_23
{
    class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        //базовый конструктор
        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        // вывод информации в строку
        public string GetInfo()
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }

}
