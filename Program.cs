namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenAccount obj = new OpenAccount();
            double initialbal = 2000.00;
            double deposit = 500.00;
            double withdraw = 398.50;
            double interest = 4.5;
            deposit = obj.GetDeposit(deposit);
            withdraw = obj.Withdraw(withdraw);
            interest = obj.AddInterest(interest,initial, deposit);

            double balance;
            balance = obj.GetBalance(initialbal, deposit, withdraw, interest);


            initialbal = 2850.6;
            deposit = 500.75;
            withdraw = 398.00;
            interest = 4;
            deposit = obj.GetDeposit(deposit);
            withdraw = obj.Withdraw(withdraw);
            interest = obj.AddInterest(interest, initial, deposit);

            balance = obj.GetBalance(initialbal, deposit, withdraw, interest);
            
        }
    }

    public interface BankInterface
    {
        double GetBalance(double initial, double deposit, double withdraw, double interest);
        double GetDeposit(double deposit);

        double AddInterest(double interest);
        double Withdraw(double withdraw);
    }

    public class OpenAccount : BankInterface
    {
        public double GetDeposit(double deposit)
        {
            return deposit;
        }

		public double AddInterest(double interest, double initial, double deposit)
        {
            return (Initial+deposit) * interest / 100;
        }

        public double GetBalance(double initial, double deposit, double withdraw, double interest)
        {
            return initial + deposit + interest-withdraw;
        }

        public double Withdraw(double withdraw)
        {
            return withdraw;
        }
    }

}
