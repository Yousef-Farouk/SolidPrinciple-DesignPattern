using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.E_Commerce_Ex
{
    public class OrderManager
    {
        public Payment payment;
        public ISendEmail sendorder;
        private  ProductRepository productRepository;
        private OrderRepository orderRepository;

        public OrderManager( List<Product> _products, Payment _payment,ISendEmail _sendorder,ProductRepository _productRepository,OrderRepository _orderRepository)
        {
            payment = _payment;
            sendorder = _sendorder;
            productRepository = _productRepository;
            orderRepository = _orderRepository;

        }

        public void PlaceOrder(string customerName, List<int> productIds, IPayment paymentMethod,List<Product> orderedProducts)
        {
            decimal totalCost = 0;
            foreach (int productId in productIds)
            {
                Product product = productRepository.GetProductByid(productId);

                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }
            if (orderedProducts.Count > 0)
            {
                payment.ProcessPayment(paymentMethod, totalCost);
            }

            Order order = new Order
            {
                CustomerName = customerName,
                Products = orderedProducts,
                TotalCost = totalCost,

            };
            orderRepository.AddOrder(order);
            sendorder.SendOrderConfirmationEmail(order);
        }
    }
}
