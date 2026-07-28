using Microsoft.EntityFrameworkCore;
using Task_8_EF.Models;

namespace Task_8_EF
{
    internal class Program
    {
        // Shared DbContext - created ONCE, here, so every function below reuses
        // the exact same instance instead of each function opening its own.
        static ProjectContext context = new ProjectContext();
        // Shared login state - 0 means "nobody is logged in".
        // Set by Login(), read by any function that requires a logged-in user,
        // reset back to 0 by Logout().
        static int loggedInUserId = 0;
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        // ===================== FUNCTIONS =====================
        // Every function below talks to the console itself AND uses the
        // shared "context" field declared above - never create a new
        // AppDbContext() inside any of these functions.
        static void RegisterUser()
        {
            // TODO: implement (see Part 3 requirements)
            try
            {
                //first we will read 
                User newUser = new User();
                Console.Write("Enter your name: ");
                newUser.UserName = Console.ReadLine();
                Console.Write("Enter your email: ");
                newUser.UserEmail = Console.ReadLine();
                Console.Write("Enter your password: ");
                newUser.UserPassword = Console.ReadLine();
                Console.Write("Enter your Address: ");
                newUser.UserAddress = Console.ReadLine().ToLower();

                //add info
                context.users.Add(newUser);
                context.SaveChanges();  


            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : invalid input");
            }
        }
        static void Login()
        {
            // TODO: implement - on success, set loggedInUserId = <found user's Id>
            try
            {
                Console.Write("Enter your email: ");
                string UserEmail = Console.ReadLine();
                Console.Write("Enter your password: ");
                string UserPassword = Console.ReadLine().ToLower();
                //search for user in database
                User foundUser = context.users.FirstOrDefault(u => u.UserEmail.ToLower() == UserEmail.ToLower() && u.UserPassword.ToLower() == UserPassword);
                if (foundUser != null) {
                    loggedInUserId = foundUser.UserID;
                    Console.WriteLine("Login successful. Welcome, " + foundUser.UserName + "!");
                }
                else
                {
                    Console.WriteLine("Invalid email or password.");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : invalid input");
            }

        }
        static void AddCategory()
        {
            // TODO: implement
            try
            {
                //first we will read 
                Category newCategory = new Category();
                Console.Write("Enter category name: ");
                newCategory.CategoryName = Console.ReadLine();

                //add info
                context.Categories.Add(newCategory);
                context.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : invalid input");
            }
        }
        static void AddProduct()
        {
            // TODO: implement product details
            //first we check if there are any categories in the database
            if (!context.Categories.Any())
            {
                Console.WriteLine("No categories found. Please add a category first.");
                return;
            }
            else
            {
                try
                {
                    //first we will read 
                    Product newProduct = new Product();
                    Console.Write("Enter product name: ");
                    newProduct.ProductName = Console.ReadLine();
                    //as well as price
                    double price = -1;
                    Console.Write("Enter product price: ");
                    while(price < 0)
                    {
                        try
                        {
                            price = double.Parse(Console.ReadLine());
                            if (price < 0)
                            {
                                Console.WriteLine("ERROR :Price cannot be negative");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERROR :Invalid input.");
                        }
                    }
                    newProduct.ProductPrice = price; //set price


                    //then we will display all categories and ask user to select one
                    Console.WriteLine("Select a category for the product:");
                    var categories = context.Categories.ToList(); //ok so this is better than using it directly in case we want to use it later
                    foreach (var category in categories) { 
                        Console.WriteLine(category.CategoryName);//get all names
                    
                    }
                    Console.Write("Enter category name of your choice: ");
                    string CategoryName = Console.ReadLine();
                    Category foundCategory = categories.FirstOrDefault(c => c.CategoryName.ToLower() == CategoryName.ToLower());
                    if (foundCategory != null) {
                        //then we save the product
                        int categoryId = foundCategory.CategoryId;
                        newProduct.CategoryId = categoryId;
                        //save product info
                        context.products.Add(newProduct);
                        context.SaveChanges();

                    }
                    else
                    {
                        Console.WriteLine("ERROR :Invalid category name.");
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : invalid input");
                }
            }
        }
        static void ViewAllProducts()
        {
            // TODO: implement
            try
            {
                //ask for a catgory name
                Console.Write("Enter category name to view products: ");
                string CategoryName = Console.ReadLine().ToLower();
                Category foundCategory = context.Categories.FirstOrDefault(c => c.CategoryName.ToLower() == CategoryName.ToLower());
                if (foundCategory != null)
                {
                    //we get id
                    int categoryId = foundCategory.CategoryId;

                    //search for category in database from products
                    var products = context.products.Where(p => p.CategoryId == categoryId).ToList();
                    //display products
                    Console.WriteLine("=============================");
                    Console.WriteLine($"    ALL PRODUCTS IN {foundCategory.CategoryName}");
                    Console.WriteLine("=============================");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"Product Name: {product.ProductName}, Price: {product.ProductPrice}");
                    }

                   
                }
                else
                {
                    Console.WriteLine("ERROR :Invalid category name.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : invalid input");
            }
        }
        static void PlaceOrder()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }
        static void ViewMyOrders()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }
        static void ViewOrderDetails()
        {
            // TODO: implement
        }
        static void AddReview()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }
        static void ViewReviewsForProduct()
        { 

        
        }
        // TODO: implement
        static void Logout()
        {
            // TODO: implement - reset loggedInUserId back to 0
        }
    }
}

