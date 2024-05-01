using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Liskov_Substitution
{
    public class Account
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance");
            }
        }
    }

    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public override void Deposit(decimal amount)
        {
            
        }
        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
              
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance");
            }
        }
    }



}
