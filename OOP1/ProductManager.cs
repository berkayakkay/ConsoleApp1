    using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {//encapsulation
        public void Add(Product product1,Product product2)
        {
            Console.WriteLine(product1.ProductName + " eklendi.");
            Console.WriteLine(product2.ProductName + " eklendi.");

        }


    }

       
}
