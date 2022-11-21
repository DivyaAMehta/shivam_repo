using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1Que4
{
    internal class SavingAccount:BankAccount
    {
       private decimal _balance;
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }

        public void Interest()
        {
            throw new NotImplementedException();
        }

        public decimal Balance { get { return _balance; } }
    }
}
