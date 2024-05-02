using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.E_Commerce_Ex
{
        public class Payment
        {
            public void ProcessPayment(IPayment Paymenttype, decimal amount)
            {
                Paymenttype.ProcessPayment(amount);
            }
        }
}
