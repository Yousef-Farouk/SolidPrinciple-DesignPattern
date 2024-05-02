using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Liskov_Substitution
{

    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);
    }
    public class Account : BankAccount
    {

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
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

    public class SavingsAccount : BankAccount
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
