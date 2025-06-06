using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_23
{
    class Shop
    {
        private Dictionary<Product, int> products;
        private decimal budget = 0;

        // конструктор 
        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        // методы связанные с бюджетом магазина
        // вывод бюджета
        public decimal Budget()
        {
            return budget;
        }

        // расчет прибыли
        public void Profit(Product product)
        {
            budget += product.Price;
        }

        // расчет прибыли с учётом налогов
        public void Profit(Product product, double tax_proc)
        {
            budget += (decimal)((double)product.Price * ((100 - tax_proc)/100)); 
        }

        // Продуктовые методы
        // добавление продукта
        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }

        // добавление продукта с созданием
        public string[] CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
            return new string[] { name, price.ToString(), count.ToString() };
        }

        // вывод всех продуктов
        public string WriteAllProducts()
        {
            string ans = "";
            foreach (var product in products)
            {
                ans += product.Key.GetInfo() + "; Количество: " + product.Value.ToString();
            }

            return ans;
        }

        // поиск продукта
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        // Смежные методы
        // покупка продукта по объекту
        public bool Sell(Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    return false;
                }
                else
                {
                    this.Profit(product);
                    products[product]--;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        // покупка продукта по строке
        public bool Sell(string ProductName)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell);
                return true;
            }
            else
            {
                return false;
            }
        }

        // множественная покупка
        public void ManySell(string[] prod)
        {
            foreach (string pr in prod)
            {
                this.Sell(pr);
            }
        }

        // множественная покупка
        public void ManySell(Product[] prod)
        {
            foreach (Product pr in prod)
            {
                this.Sell(pr);
            }
        }

        // вывод словаря
        public Dictionary<Product, int> DictProd()
        {
            return products;
        }

        
    }

}
