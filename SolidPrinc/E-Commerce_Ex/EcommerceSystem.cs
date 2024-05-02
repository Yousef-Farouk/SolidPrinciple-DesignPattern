using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.E_Commerce_Ex
{
    internal class EcommerceSystem
    {

        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();
        private IPayment paymentmethod;


        public EcommerceSystem()
        {
            
        }
        public void AddProduct(string name, decimal price, int quantity)
        {
            products.Add(new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity
            });

        }
        public void PlaceOrder(string customerName, List<int> productIds, string paymentMethod)
        {
            decimal totalCost = 0;
            List<Product> orderedProducts = new List<Product>();
            foreach (int productId in productIds)
            {
                Product product = products.Find(p => p.Id == productId);

                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }
            if (orderedProducts.Count > 0)
            {
                if (paymentMethod == "CreditCard")
                {
                    ProcessCreditCardPayment(totalCost);
                }
                else if (paymentMethod == "PayPal")
                {
                    ProcessPayPalPayment(totalCost);
                }
            }

            Order order = new Order
            {
                CustomerName = customerName,
                Products = orderedProducts,
                TotalCost = totalCost,

            };
            orders.Add(order);
            SendOrderConfirmationEmail(order);
        }

        private void ProcessCreditCardPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");

        }

        private void ProcessPayPalPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");


        }

        private void SendOrderConfirmationEmail(Order order)
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


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}


public class Order
{
    public string CustomerName { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalCost { get; set; }
}

