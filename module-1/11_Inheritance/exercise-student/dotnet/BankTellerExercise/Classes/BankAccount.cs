namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public BankAccount(string accountHolderName, string accountNumber)
        {
            accountHolderName = "Brendan Bressler";
            accountNumber = "2967842";

            this.Balance = 0M;
        }
        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            accountHolderName = "Brendan Bressler";
            accountNumber = "2967842";
            this.Balance = balance;


        }
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }
        public decimal Deposit(decimal amountToDeposit)
        {

            Balance = amountToDeposit + Balance;
            return Balance;
        }
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {

            Balance = Balance - amountToWithdraw;
            return Balance;
        }

    }



}
