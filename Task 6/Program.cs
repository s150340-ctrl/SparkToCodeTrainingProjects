using System.Runtime.Intrinsics.X86;

namespace Task_6
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        //Parameterized Constructor
        public BankAccount(int number, string name, double balance)
        {
            AccountNumber = number;
            HolderName = name;
            Balance = balance;

        }
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
        public static int count = 0;
        int age { get; set; }
        //constructer
        public Student()
        {
            count++;
        }
        //methods
        public static int Count()
        {
            return count;
        }
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
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        //methods
        public void Sell(int quantity)
        {
            if (quantity <= StockQuantity)
            {
                StockQuantity -= quantity;
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







            //main menu
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
                //after switch case 
                Console.WriteLine("Please enter any key");
                Console.Write("");
                Console.Clear();


            }




        }
        static BankAccount ReturnBank(int choice)
        {
            //2 bank accounts
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1163;
            b1.HolderName = "karim";
            b1.Balance = 120;
            //2nd bank account 
            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 15203;
            b2.HolderName = "Ali";
            b2.Balance = 63;
            if (choice == 1)
            {
                return b1;

            }
            if (choice == 2) { return b2; }
            //else
            return null;


        }

        //returns student
        static Student ReturnStudent(int choice)
        {
            //2 students
            Student s1 = new Student();
            s1.Name = "Ali";
            s1.Address = "Muscat";
            s1.Grade = 65;
            //other one
            Student s2 = new Student();
            s2.Name = "Ahmed";
            s2.Address = "Muscat";
            s2.Grade = 70;
            if (choice == 1)
            {
                return s1;

            }
            if (choice == 2) { return s2; }
            //else
            return null;


        }
        static Product ReturnProduct(int choice)
        {
            //2 products
            Product p1 = new Product();
            p1.ProductName = "Wireless Mouse";
            p1.Price = 5.500;
            p1.StockQuantity = 50;
            //other product
            Product p2 = new Product();
            p2.ProductName = "Mechanical Keyboard";
            p2.Price = 15.750;
            p2.StockQuantity = 20;
            if (choice == 1)
            {
                return p1;

            }
            if (choice == 2) { return p2; }
            //else
            return null;


        }


        static void ViewAccountDetails()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BankAccount acc1 = ReturnBank(1);
                        //get details
                        acc1.CheckBalance();
                        break;
                    case 2:
                        BankAccount acc2 = ReturnBank(2);
                        //get details
                        acc2.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }

        static void UpdateStudentAddress()
        {

            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Please Enter an Address:");
                string address = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        Student stu1 = ReturnStudent(1);
                        //get details
                        stu1.Address = address;
                        Console.Write("Your new Address :" + address);



                        break;
                    case 2:
                        Student stu2 = ReturnStudent(2);
                        //get details
                        stu2.Address = address;
                        Console.Write("Your new Address :" + address);


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }


        }
        static void MakeDeposit()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Please Enter an amount to deposit:");
                double amount = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BankAccount bank1 = ReturnBank(1);
                        //get details
                        bank1.Deposit(amount);
                        bank1.CheckBalance();




                        break;
                    case 2:
                        BankAccount bank2 = ReturnBank(2);
                        //get details
                        bank2.Deposit(amount);
                        bank2.CheckBalance();


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }
        static void MakeWithdrawal()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Please Enter an amount to deposit:");
                double amount = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BankAccount bank1 = ReturnBank(1);
                        //get details
                        bank1.Withdraw(amount);
                        bank1.CheckBalance();




                        break;
                    case 2:
                        BankAccount bank2 = ReturnBank(2);
                        //get details
                        bank2.Withdraw(amount);
                        bank2.CheckBalance();


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }
        static void ViewProductDetails()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product pro1 = ReturnProduct(1);
                        //get details
                        pro1.GetInventoryValue();

                        break;
                    case 2:
                        Product pro2 = ReturnProduct(2);
                        //get details
                        pro2.GetInventoryValue();

                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }
        static void RegisterStudent()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Please Enter an email:");
                string email = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        Student stu1 = ReturnStudent(1);
                        //get details
                        stu1.Register(email);
                        Console.Write("Your new Email has been set!");



                        break;
                    case 2:
                        Student stu2 = ReturnStudent(2);
                        //get details
                        stu2.Register(email);
                        Console.Write("Your new Email has been set!");


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }



        }
        static void CompareAccountBalances()
        {
            //first we get the objects from other method
            BankAccount bank1 = ReturnBank(1);
            BankAccount bank2 = ReturnBank(2);///even if name is repeated bec its a local variable name it doesnt matter
            //now we gte both thier balances
            double balance1 = bank1.Balance;
            double balance2 = bank2.Balance;
            if (balance1 == balance2)
            {
                Console.WriteLine("The balances are equal");

            }
            else if (balance1 < balance2)
            {
                Console.WriteLine("The balance in accoount : " + bank2.HolderName + " is greater");
            }
            else
            {
                Console.WriteLine("The balance in accoount : " + bank1.HolderName + " is greater");
            }



        }

        static void RestockProduct()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Enter quantity for product :");
                int quantity = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product pro1 = ReturnProduct(1);
                        //get details
                        pro1.Restock(quantity);
                        //check stockQuantity lvl
                        double stock = pro1.StockQuantity;
                        if (stock < 10) { Console.WriteLine("Low stock"); }
                        else if ((stock >= 10) && (stock <= 49)) { Console.WriteLine("Moderate stock"); }
                        else { Console.WriteLine("Well Stocked"); }
                        break;
                    case 2:
                        Product pro2 = ReturnProduct(2);
                        //get details
                        pro2.Restock(quantity);
                        //check stockQuantity lvl
                        double stock2 = pro2.StockQuantity;
                        if (stock2 < 10) { Console.WriteLine("Low stock"); }
                        else if ((stock2 >= 10) && (stock2 <= 49)) { Console.WriteLine("Moderate stock"); }
                        else { Console.WriteLine("Well Stocked"); }

                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }


        }
        static void TransferBetweenAccounts()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 as a Source account(the other account will be the destination) :");
                int source = int.Parse(Console.ReadLine());
                Console.Write("Please Enter an amount to transfer:");
                double amount = double.Parse(Console.ReadLine());

                switch (source)
                {
                    case 1:
                        BankAccount bank1Source = ReturnBank(1);
                        BankAccount bank2Final = ReturnBank(2);
                        //here we will check balance
                        if (amount <= bank1Source.Balance)
                        {
                            //we can transfer
                            bank1Source.Withdraw(amount);
                            bank2Final.Deposit(amount);
                        }
                        else
                        {
                            //we cannot transfer
                            Console.WriteLine("Error: failure to transfer");

                        }






                        break;
                    case 2:
                        BankAccount bank2Source = ReturnBank(2);
                        BankAccount bank1Final = ReturnBank(1);//final destination for amount
                        if (amount <= bank2Source.Balance)
                        {
                            //we can transfer
                            bank2Source.Withdraw(amount);
                            bank1Final.Deposit(amount);

                        }
                        else
                        {
                            //we cannot transfer
                            Console.WriteLine("Error: failure to transfer");

                        }


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;






                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }


        }
        static void UpdateStudentGrade()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Please Enter a grade:");
                int grade = int.Parse(Console.ReadLine());



                if ((grade >= 0) && (grade <= 100))
                { //valid grade

                    switch (choice)
                    {
                        case 1:
                            Student stu1 = ReturnStudent(1);

                            //get details
                            stu1.Grade = grade;




                            break;
                        case 2:
                            Student stu2 = ReturnStudent(2);
                            //get details
                            stu2.Grade = grade;



                            break;
                        default:
                            Console.WriteLine("Error: please enter a valid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Update grade Rejected");
                }








            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }



        }
        static void StudentReportCard()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                string stat = "";

                switch (choice)
                {
                    case 1:
                        Student stu1 = ReturnStudent(1);
                        if (stu1.Grade >= 60)
                        {
                            stat = "Pass";
                        }
                        else
                        {
                            stat = "Fail";
                           
                        }
                        //print formatted output
                        Console.WriteLine("Name: " + stu1.Name);
                        Console.WriteLine("Address: " + stu1.Address);
                        Console.WriteLine("Grade: " + stu1.Grade);
                        Console.WriteLine("Status: " + stat);



                        break;
                    case 2:
                        Student stu2 = ReturnStudent(2);
                        if (stu2.Grade >= 60)
                        {
                            stat = "Pass";
                        }
                        else
                        {
                            stat = "Fail";
                        }
                        //print formatted output
                        Console.WriteLine("Name: " + stu2.Name);
                        Console.WriteLine("Address: " + stu2.Address);
                        Console.WriteLine("Grade: " + stu2.Grade);
                        Console.WriteLine("Status: " + stat);


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;
                }




            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }


        }
        static void AccountHealthStatus()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                string stat = "";
                double result = 0;

                switch (choice)
                {
                    case 1:
                        BankAccount bank1 = ReturnBank(1);
                        //get details
                        result =bank1.Balance;
                 
                        break;
                    case 2:
                        BankAccount bank2 = ReturnBank(2);
                        result = bank2.Balance;
                    
                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;


                }
                if (result < 50)
                {
                    stat = "Low Balance";
                }
                else if ((result >= 50) && (result <= 1000))
                {
                    stat = "Healthy";
                }
                else
                {
                    stat = "Premium";

                }

                Console.WriteLine("BankAccount Status: " + stat);

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }
        static void BulkSaleWithRevenue()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                int quantity = -1;
                while (quantity <= 0)
                {
                    Console.Write("Enter quantity to sell :");
                    quantity = int.Parse(Console.ReadLine());
                }
                double stock = 0;

                switch (choice)
                {
                    case 1:
                        Product pro1 = ReturnProduct(1);
                        //get details
                        pro1.Restock(quantity);
                        //check stockQuantity lvl
                        stock = pro1.StockQuantity;
                        if(stock >= quantity)//have enough
                        {//we sell
                            pro1.Sell(quantity);
                            //here we sell pro
                            Console.WriteLine("Total revenue made from sale :" +(pro1.Price * quantity));

                        }
                        else
                        {
                            //we dont sell
                            Console.WriteLine("Stock not enough need "+ (quantity - stock)+ " additional units.");


                        }
                   
                        break;
                    case 2:
                        Product pro2 = ReturnProduct(2);
                        //get details
                        pro2.Restock(quantity);
                    
                        stock = pro2.StockQuantity;
                        //check stockQuantity lvl
                        stock = pro2.StockQuantity;
                        if (stock >= quantity)//have enough
                        {//we sell
                            pro2.Sell(quantity);
                            //here we sell pro
                            Console.WriteLine("Total revenue made from sale :" + (pro2.Price * quantity));

                        }
                        else
                        {
                            //we dont sell
                            Console.WriteLine("Stock not enough need " + (quantity - stock) + " additional units.");


                        }


                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;


                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }



        }
        static void ScholarshipEligibilityCheck()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 (Student):");
                int choice = int.Parse(Console.ReadLine());
                Student student = null; 
             

                switch (choice)
                {
                    case 1:
                         student = ReturnStudent(1);
                    
                        break;
                    case 2:
                         student = ReturnStudent(2);
                  
                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;
                }
                if (student == null)
                {
                    return;//break out of function
                }
                else
                {
                    Console.Write("choose 1 or 2 (Bank account):");
                    int choices = int.Parse(Console.ReadLine());
                    BankAccount bankacc = null;


                    switch (choices)
                    {
                        case 1:
                            bankacc = ReturnBank(1);

                            break;
                        case 2:
                            bankacc = ReturnBank(2);

                            break;
                        default:
                            Console.WriteLine("Error: please enter a valid choice");
                            break;
                    }
                    if(bankacc == null)
                    {
                        return; //break out
                    }
                 
                    else
                    {
                        //print reason
                        if ((bankacc.Balance >= 100) && (student.Grade >= 80))
                        {
                            Console.WriteLine("Eligible");
                        } else if ((bankacc.Balance < 100) && (student.Grade <80)) {
                            Console.WriteLine("Both conditions ");
                        }
                        else if (bankacc.Balance < 100)
                        {
                            Console.WriteLine("The balance is less than 100");
                        } else
                        {
                            Console.WriteLine("The grade is less than 80");
                        }
                       
                    }

                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }


        }
        static void FullBalanceTopUpFlow()
        {
            try
            { //ask user 
                Console.Write("choose 1 or 2 :");
                int choice = int.Parse(Console.ReadLine());
                double amountNeeded = 0;
                BankAccount bank = null;



                double result = 0;

                switch (choice)
                {
                    case 1:
                         bank= ReturnBank(1);
                       

                        break;
                    case 2:
                         bank = ReturnBank(2);
                       

                        break;
                    default:
                        Console.WriteLine("Error: please enter a valid choice");
                        break;


                }
                if (bank == null) { return; } //stop here if user entered invalid choice
                else
                {
                    result = bank.Balance;
                    if (result < 50)
                    {
                        amountNeeded = 100 - result;//how much money needed to ==100
                        bank.Deposit(amountNeeded);
                        //then we print
                        Console.WriteLine("Balance before: "+ result);
                        Console.WriteLine("Balance after: " + bank.Balance);


                    }
                    else
                    {
                        Console.WriteLine("No top-up is needed.");

                    }
                }

             

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }


        }
        static void QuickAccountOpening()
        {
            //make an account onlu using that constructer
            try
            {
                //read input
                Console.Write("Enter account number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Enter account name: ");
                string name = Console.ReadLine();
                Console.Write("Enter account Balance: ");
                double amount = double.Parse(Console.ReadLine());
                //assign object + print detail
                BankAccount account = new BankAccount(number, name, amount);
                account.CheckBalance();

            }
            catch(Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }
        static void TotalStudentsCounter() {

            //get student count
            Console.WriteLine("Total amount of Student objects: " + Student.Count());

        }
    }
}

