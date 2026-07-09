using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Delete account");
                Console.WriteLine("7. Apply for membership");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        DeleteAccount();
                        break;
                    case 7:
                        SearchAccount();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            while (true) {
                try
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine().ToLower();
                    Console.Write("Enter your account number : ");
                    string number = Console.ReadLine().ToLower();

                    double amount = -1;
                    while(amount< 0)//keeps on assking until user enters a positive amount or non-negative
                    {
                        Console.Write("Enter your initial deposit amount : ");
                        amount = double.Parse(Console.ReadLine());

                    }
                    bool check = false;
                    if (accountNumbers.Count > 0)//check if number id exists
                    {
                        foreach (string c in accountNumbers)
                        {
                            if (c == number)
                            {
                                Console.Write("ERROR : number already exists");
                                check = true;
                                break; //leave loop

                            }
                        }
                        if (check)//means if true the number pre-exists
                        {
                            break; //leave outer loop

                        }
                        else
                        {
                            customerNames.Add(name);
                            accountNumbers.Add(number);
                            balances.Add(amount);
                            Console.WriteLine("Your new bank account details:");
                            Console.WriteLine("Account name: "+ name);
                            Console.WriteLine("Account ID :"+ number);
                            Console.WriteLine("Balance: "+ amount);
                            break; //leave outer loop after adding an account

                        }
                    }
                    else
                    {
                        customerNames.Add(name);
                        accountNumbers.Add(number);
                        balances.Add(amount);
                        Console.WriteLine("Your new bank account details:");
                        Console.WriteLine("Account name: " + name);
                        Console.WriteLine("Account ID :" + number);
                        Console.WriteLine("Balance: " + amount);

                        break;
                    } }
                catch (Exception) { Console.WriteLine("ERROR: invalid input."); }
            }
          
        }
        static void DepositMoney()
        {
            while (true)
            {
                try
                {
                  
                    Console.Write("Enter your account number : ");
                    string number = Console.ReadLine().ToLower();
                    int indexAccount = 0;
                    bool accountCheck = true;
                    if (accountNumbers.Count > 0) // if not empty
                    {
                        for (int i = 0; i < accountNumbers.Count; i++)
                        {
                            if (accountNumbers[i] == number) { // number is found
                                indexAccount = i;
                                accountCheck = false;
                                break;
                            }
                        }
                        if (accountCheck)//still true means account DNE
                        {
                            Console.Write("ERROR : number doesn't exist");
                            break; //leave loop

                        }
                        else
                        {
                            //ask for amount
                            double deposit = -1;
                            while (deposit < 0)//keeps on assking until user enters a positive amount or non-negative
                            {
                                Console.Write("Enter your deposit amount : ");
                                deposit = double.Parse(Console.ReadLine());

                            }
                            //now we add
                            balances[indexAccount] += deposit;
                            //print updated balance
                            Console.WriteLine("Your updated balance: " + balances[indexAccount]);
                            break;
                            


                        }
                    }
                    
                
                }
                catch (Exception) { Console.WriteLine("ERROR: invalid input."); }
            }

        
        }
        static void WithdrawMoney()
        {
            while (true)
            {
                try
                {

                    Console.Write("Enter your account number : ");
                    string number = Console.ReadLine().ToLower();
                    int indexAccount = 0;
                    bool accountCheck = true;
                    if (accountNumbers.Count > 0) // if not empty
                    {
                        for (int i = 0; i < accountNumbers.Count; i++)
                        {
                            if (accountNumbers[i] == number)
                            { // number is found
                                indexAccount = i;
                                accountCheck = false;
                                break;
                            }
                        }
                        if (accountCheck)//still true means account DNE
                        {
                            Console.Write("ERROR : number doesn't exist");
                            break; //leave loop

                        }
                        else
                        {
                            //ask for amount
                            double withdraw = -1;
                            while ((withdraw < 0)&& (withdraw > balances[indexAccount]))//keeps on assking until user enters a positive amount or non-negative
                            {
                                Console.Write("Enter your withdrawal amount : ");
                                withdraw = double.Parse(Console.ReadLine());
                                if((withdraw < 0) && (withdraw > balances[indexAccount]))
                                {
                                    Console.Write("ERROR : your number is neqative or it exceedes balance amount.");
                                }

                            }
                            //now we deduct
                            balances[indexAccount] -= withdraw;
                            //print updated balance
                            Console.WriteLine("Your updated balance: " + balances[indexAccount]);
                            break;



                        }
                    }


                }
                catch (Exception) { Console.WriteLine("ERROR: invalid input."); }
            }


        }
        
        static void ShowBalance()
        {
            while (true)
            {
                try
                {

                    Console.Write("Enter your account number : ");
                    string number = Console.ReadLine().ToLower();
                    int indexAccount = 0;
                    bool accountCheck = true;
                    if (accountNumbers.Count > 0) // if not empty
                    {
                        for (int i = 0; i < accountNumbers.Count; i++)
                        {
                            if (accountNumbers[i] == number)
                            { // number is found
                                indexAccount = i;
                                accountCheck = false;
                                break;
                            }
                        }
                        if (accountCheck)//still true means account DNE
                        {
                            Console.Write("ERROR : number doesn't exist");
                            break; //leave loop

                        }
                        else
                        {

                            //print customer  balance and info
                            Console.WriteLine("Your bank account details:");
                            Console.WriteLine("Account name: " + customerNames[indexAccount]);
                            Console.WriteLine("Account ID :" + accountNumbers[indexAccount]);
                            Console.WriteLine("Balance: " + balances[indexAccount]);
                            break;



                        }
                    }


                }
                catch (Exception) { Console.WriteLine("ERROR: invalid input."); }
            }


        }
        
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void DeleteAccount()
        {

        }
        static void SearchAccount()
        {

        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
    }
}