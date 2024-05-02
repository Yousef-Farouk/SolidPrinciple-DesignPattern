using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SolidPrinc.E_Commerce_Ex
{
    public class ProductRepository
    {
        public List<Product> products;

        public ProductRepository(List<Product> _products)
        {
            products = _products;
        }

        public void AddProduct(Product p ) 
        {
            //products.Add(new Product
            //{
            //    Name = name,
            //    Price = price,
            //    Quantity = quantity
            //});

            products.Add(p);
        }

        public Product GetProductByid(int id )
        {
            return products.Find(p => p.Id == id);
        }
    }
}
