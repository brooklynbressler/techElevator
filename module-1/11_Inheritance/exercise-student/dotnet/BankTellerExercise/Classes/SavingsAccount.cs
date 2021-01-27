namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance)
            : base (accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal newBalance = Balance;
            if(Balance < 150 && amountToWithdraw < Balance)
            {
                newBalance = base.Withdraw(amountToWithdraw);
                newBalance = base.Withdraw(2);
                return newBalance;
            }
            else if(amountToWithdraw >= Balance)
            {
                return Balance;
            }
            else if(newBalance - amountToWithdraw < 150)
            {
                newBalance = base.Withdraw(amountToWithdraw);
                newBalance = base.Withdraw(2);
                return newBalance;
            }
            return base.Withdraw(amountToWithdraw);

        }




    }
}
