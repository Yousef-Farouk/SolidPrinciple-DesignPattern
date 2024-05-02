using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.E_Commerce_Ex
{
    public class SendOrder : ISendEmail
    {
            public void SendOrderConfirmationEmail(Order order)
            {
                string message = $"Order confirmation for {order.CustomerName}:\n";
                message += $"Total Cost: ${order.TotalCost}\n";
                message += "Products:\n";
                foreach (Product product in order.Products)
                {
                    message += $"- {product.Name} (${product.Price})\n";
                }


            }

        
    }
}
