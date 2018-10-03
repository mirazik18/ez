using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWDAWd
{
    public enum TypeProduct
    {
        chemistry,
        food,
        flour,
        fruits
    
    }
    public class Good
    {
        public List<Good> products = new List<Good>();
        public List<Good> basket = new List<Good>();
        public string Name { get; set; }
        public int Cost { get; set; }
        public TypeProduct Type_product { get; set; }

        public Good(string name, int cost, TypeProduct type_product)
        {
            Type_product = type_product;
            Name = name;
            Cost = cost;
        }

        public Good()
        {

        }

        public void AddProduct(string name, int cost, TypeProduct tp)
        {
            Good product = new Good(name, cost, tp);
            products.Add(product);
        }

        public void PrintProducts()
        {
            int i = 1;
            List<Good> array = products.Where(a => a.Type_product == TypeProduct.chemistry).ToList();
            foreach (var item in array)
            {
                Console.WriteLine("{0}.{1}.{2}тенге", i, item.Name, item.Cost);
                i++;
            }
            array = products.Where(a => a.Type_product == TypeProduct.flour).ToList();
            foreach (var item in array)
            {
                Console.WriteLine("{0}.{1}.{2}тенге", i, item.Name, item.Cost);
                i++;
            }
            array = products.Where(a => a.Type_product == TypeProduct.food).ToList();
            foreach (var item in array)
            {
                Console.WriteLine("{0}.{1}.{2}тенге", i, item.Name, item.Cost);
                i++;
            }
            array = products.Where(a => a.Type_product == TypeProduct.fruits).ToList();
            foreach (var item in array)
            {
                Console.WriteLine("{0}.{1}.{2}тенге", i, item.Name, item.Cost);
                i++;
            }
            Console.ReadLine();
        }
        public void AddToBasket(int num)
        {
            num--;
            basket.Add(products[num]);
            products.RemoveAt(num);
            Console.ReadLine();
        }
        public void ClearBasket()
        {
            basket.Clear();
            Console.ReadLine();
        }
        public void ShowBasket()
        {
         foreach(var item in basket)
            {
                Console.WriteLine(item.Name);

            }
            Console.ReadLine();
        }
    }
   
}
