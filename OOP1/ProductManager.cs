using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) // bana product cinsinde product ver demek //metodumuzun nasıl çağırılacağını belirtiyor
            // aslında burdaki product product1 demek-Product değil product-

        {
            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Update(Product product)
        {

            Console.WriteLine(product.ProductName + " güncellendi. ");
        }

       

            
        }



    }
}
