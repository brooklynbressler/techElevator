using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }
        
        
        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt { get; set; } = 0;

        public int Balance { get; private set; } 
        public int Pay(int amountToPay)
        {
            this.Debt = Debt - amountToPay;
            Balance = Debt * -1;
            return this.Debt;
        }
        public int Charge(int amountToCharge)
        {
             this.Debt = amountToCharge + Debt;
            Balance = Debt * -1;
            return this.Debt;
        }


    }
}
