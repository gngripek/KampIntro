using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();   //1 numaralı ürünü oluşturduk

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, UnitsInStock = 5, ProductName ="Kalem",UnitPrice = 35 } // 2 numaralı ürün oluşturduk

            //PascalCase-class   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager(); //productmanager türünde productmanager tanımladık
            string isim = "Engin"; //string türünde isim tanımladık

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            
        }
    }
}
