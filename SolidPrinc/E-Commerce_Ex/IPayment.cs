using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.E_Commerce_Ex
{
    public interface IPayment
    {
        public void ProcessPayment(decimal amount);
    }
}
