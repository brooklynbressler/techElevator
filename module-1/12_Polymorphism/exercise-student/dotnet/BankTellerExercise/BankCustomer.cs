using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
      class BankCustomer : IAccountable
    {

        public string Name { get; set; } = "Brooklyn Bressler";
        public string Address { get; set; } = "414 Hoge Street";
        public string PhoneNumber { get; set; } = "937-287-8077";

        public bool IsVip { get; set; } = false;
        
        public int Balance { get; }

        public  List<IAccountable> customersAccounts { get; private set; } = new List<IAccountable>();
        public void AddAccount(IAccountable newAccount)
        {
            
            this.customersAccounts.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            IAccountable[] customs = customersAccounts.ToArray();
            return customs;
        }


    }
}
