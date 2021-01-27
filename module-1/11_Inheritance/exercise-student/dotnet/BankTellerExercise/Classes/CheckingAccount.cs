namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance)
            : base (accountHolderName, accountNumber, balance)
        {
            
        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal newBalance = Balance;
            if (newBalance - amountToWithdraw < 0M && newBalance - amountToWithdraw > -100M)
            {
                
                newBalance = base.Withdraw(amountToWithdraw);
                newBalance = base.Withdraw(10M);
                return newBalance;
            }
            else if (newBalance <= -100M)
            {
                return Balance;
            }
            return base.Withdraw(amountToWithdraw);
        }
    }
}