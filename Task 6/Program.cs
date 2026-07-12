namespace Task_6
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        //methods
        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                SendEmail();
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;

        }
        private void PrintInformation()
        {
            Console.WriteLine("Name : " + HolderName);
            Console.WriteLine("Balance : " + Balance);
        }
        private void SendEmail()
        {
            Console.WriteLine(" *email notification being sent*");

        }
    }
    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; }
        int age { get; set; }
        //methods
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine(" *email notification being sent*");

        }
    }
    public class Product {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        //methods
        public void Sell(int quantity)
        {
            if (quantity <= StockQuantity)
            {
                StockQuantity-=quantity;
                LogTransaction();
            }
            else
            {
                Console.WriteLine("not enough stock");
                LogTransaction();

            }

        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();

        }
        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;

        }
        private void PrintDetails()
        {
            Console.WriteLine("Name of Product : " + ProductName);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Stock Quantity : " + StockQuantity);

        }
        private void LogTransaction()
        {
            Console.WriteLine(" *transaction being logged*");


        }







    }









    internal class Program
    {
        static void Main(string[] args)
        {

            // Required Objects
            //2 bank accounts
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1163;
            b1.HolderName = "karim";
            b1.Balance = 120;

        }
    }
}
