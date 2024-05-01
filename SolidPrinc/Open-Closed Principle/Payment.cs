using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Open_Closed_Principle
{
    public interface IPayment
    {
        public void ProcessPayment(double amount);
    }


    public class Payment
    {
        public void ProcessPayment(IPayment Paymenttype,double amount)
        {
            Paymenttype.ProcessPayment(amount);
        }
    }

    public class CreditCard :IPayment
    {
        public void ProcessPayment(double amount)
        {

        }
    }

    public class PayPal : IPayment
    {
        public void ProcessPayment(double amount)
        {

        }
    }

    public class BankTransfer : IPayment
    {
        public void ProcessPayment(double amount)
        {

        }
    }






}
