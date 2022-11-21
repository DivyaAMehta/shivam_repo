using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1Que4
{
     class RateofInterest:BankAccount
    {
        private decimal _balance;
        public void Interest()
        {
            _balance +=_balance*5/100;
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        public decimal Balance { get { return _balance; } }


    }
}
