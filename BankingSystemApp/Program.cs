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
                Console.WriteLine("6. List all accounts");
                Console.WriteLine("7. Find the Richest Customer");
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
                        ListAll();
                        break;
                    case 7:
                        FindRichest();
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
            while (true)
            {
                try
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine().ToLower();
                    Console.Write("Enter your account number : ");
                    string number = Console.ReadLine().ToLower();

                    double amount = -1;
                    while (amount < 0)//keeps on assking until user enters a positive amount or non-negative
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
                                Console.WriteLine("ERROR : number already exists");
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
                            Console.WriteLine("Account name: " + name);
                            Console.WriteLine("Account ID :" + number);
                            Console.WriteLine("Balance: " + amount);
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
                    }
                }
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
                            if (accountNumbers[i] == number)
                            { // number is found
                                indexAccount = i;
                                accountCheck = false;
                                break;
                            }
                        }
                        if (accountCheck)//still true means account DNE
                        {
                            Console.WriteLine("ERROR : number doesn't exist");
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
                    else
                    {

                        Console.WriteLine("ERROR : number doesn't exist.Please add more accounts");
                        break; //leave loop



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
                            Console.WriteLine("ERROR : number doesn't exist");
                            break; //leave loop

                        }
                        else
                        {
                            //ask for amount
                            double withdraw = -1;
                            while ((withdraw < 0))//keeps on assking until user enters a positive amount or non-negative
                            {
                                Console.Write("Enter your withdrawal amount : ");
                                withdraw = double.Parse(Console.ReadLine());
                                if ((withdraw < 0) || (withdraw > balances[indexAccount]))
                                {
                                    withdraw = -1;

                                    Console.WriteLine("ERROR : your number is neqative or it exceedes balance amount.");

                                }

                            }
                            //now we deduct
                            balances[indexAccount] -= withdraw;
                            //print updated balance
                            Console.WriteLine("Your updated balance: " + balances[indexAccount]);
                            break;



                        }
                    }
                    else
                    {

                        Console.WriteLine("ERROR : number doesn't exist.Please add more accounts");
                        break; //leave loop


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
                            Console.WriteLine("ERROR : number doesn't exist");
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
                    else //means there is nothing in the list
                    {

                        Console.WriteLine("ERROR : number doesn't exist.Please add more accounts");
                        break; //leave loop


                    }


                }
                catch (Exception) { Console.WriteLine("ERROR: invalid input."); }
            }


        }

        static void TransferAmount()
        {
            while (true)
            {
                try
                {

                    Console.Write("Enter the sender's account number : ");
                    string senderNum = Console.ReadLine().ToLower();
                    Console.Write("Enter the  receiver's account number : ");
                    string receiverNum = Console.ReadLine().ToLower();
                    int indexAccountSend = 0;
                    int indexAccountRec = 0;
                    bool accountCheckSend = true;
                    bool accountCheckRec = true;
                    if (accountNumbers.Count > 0) // if not empty
                    {
                        for (int i = 0; i < accountNumbers.Count; i++)
                        {
                            if (accountNumbers[i] == senderNum)
                            { // number is found
                                indexAccountSend = i;
                                accountCheckSend = false;
                            }
                            if (accountNumbers[i] == receiverNum)
                            {
                                indexAccountRec = i;
                                accountCheckRec = false;

                            }
                        }
                        if (accountCheckRec || accountCheckSend)//still true means account DNE
                        {
                            Console.WriteLine("ERROR : One or both numbers dont exist");
                            break; //leave loop

                        }
                        else
                        {
                            //now we transfer amount
                            double transfer = -1;
                            while (transfer < 0)//keep Asking while transfer amount is negative
                            {
                                Console.Write("Enter your transfer amount : ");
                                transfer = double.Parse(Console.ReadLine());
                                if ((transfer < 0) || (transfer > balances[indexAccountSend]))
                                {
                                    transfer = -1;

                                    Console.WriteLine("ERROR : your number is neqative or it exceedes balance amount.");

                                }

                            }
                            //transfer amount
                            balances[indexAccountSend] -= transfer;
                            balances[indexAccountRec] += transfer;
                            //print customer  balance and info
                            Console.WriteLine("Your bank account details:");

                            Console.WriteLine("Sender's Balance: " + balances[indexAccountSend]);
                            Console.WriteLine("Receiver's Balance: " + balances[indexAccountRec]);
                            break;



                        }
                    }


                }
                catch (Exception) { Console.WriteLine("ERROR: invalid input."); }
            }


        }
        static void ListAll()
        {
            Console.WriteLine("----All bank accounts---");
            if (accountNumbers.Count > 0) // if not empty
            {
                for (int i = 0; i < accountNumbers.Count; i++)
                {
                    Console.WriteLine((i + 1) + " bank account details:");
                    Console.WriteLine("Account name: " + customerNames[i]);
                    Console.WriteLine("Account ID :" + accountNumbers[i]);
                    Console.WriteLine("Balance: " + balances[i]);


                }




            }
            else
            {
                Console.WriteLine("ERROR : number doesn't exist.Please add more accounts");

            }
        }
            static void FindRichest()
            {
            if (accountNumbers.Count > 0) // if not empty
            {
                //first set first balance as max
                int maxIndex = 0;
                for (int i = 0; i < accountNumbers.Count; i++)
                {
                    if (balances[i] > balances[maxIndex])
                    {
                        maxIndex = i;//finds max index
                    }


                }
                //after we print
                Console.WriteLine("Richest bank account details:");
                Console.WriteLine("Account name: " + customerNames[maxIndex]);
                Console.WriteLine("Account ID :" + accountNumbers[maxIndex]);
                Console.WriteLine("Balance: " + balances[maxIndex]);





            }

            else
            {
                Console.WriteLine("ERROR : number doesn't exist.Please add more accounts");

            }

            }
        }
    }

        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
    
