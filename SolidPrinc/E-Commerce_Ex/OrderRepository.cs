using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SolidPrinc.E_Commerce_Ex
{
    public class OrderRepository
    {
        public List<Order> orders = new List<Order>();

        public void AddOrder(Order o) 
        {
            //orders.Add(new Order
            //{
            //    CustomerName = customerName,
            //    Products = orderedProducts,
            //    TotalCost = totalCost,
            //});

            orders.Add(o);
        }

    }
}
