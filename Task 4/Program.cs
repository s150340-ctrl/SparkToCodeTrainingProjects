namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.WriteLine();
            Console.WriteLine("Task 1 - Personalized Welcome Function");
            Console.WriteLine();
            string name = ""; //set name

            //welcome function
            static void PrintWelcome(string message) {

                Console.Write("Welcome "+ message);

            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your name:");
                    name=Console.ReadLine();
                    PrintWelcome(name); //function prints name
                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }


            //Task 2 - Square Number Function
            Console.WriteLine();
            Console.WriteLine("Task 2 - Square Number Function");
            Console.WriteLine();

            //function
            int Square(int n) {
             return Convert.ToInt32(Math.Pow(n, 2));
            }
            int number = 0; //just for now
            while (true)
            {
                try
                {
                    Console.Write("Enter a number:");
                    number = Convert.ToInt32(Console.ReadLine());
                    int numSquared = Square(number);
                    Console.WriteLine("The number square is "+ numSquared);



                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }

            //Task 3 - Celsius to Fahrenheit Function
            Console.WriteLine();
            Console.WriteLine("Task 3 - Celsius to Fahrenheit Function");
            Console.WriteLine();
            //function
            double CelsiusToFahrenheit(double celsius) {


                return ((celsius * 9 / 5) + 32); //returns Fahrenheit value (double) 
            }
            //variables needed
            double celsius = 0;
            double fahrenheit = 0;
            //read from user
            while (true)
            {
                try
                {
                    Console.Write("Enter a Celsius value:");
                    celsius =double.Parse(Console.ReadLine());
                    fahrenheit=CelsiusToFahrenheit(celsius); //conversion happens
                    Console.WriteLine("The celsius value in fahrenheit:" + fahrenheit+" F");

                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }


            //Task 4 - Fixed Menu Display Function
            Console.WriteLine();
            Console.WriteLine("Task 4 - Fixed Menu Display Function");
            Console.WriteLine();

            //function for display
            static void DisplayMenu(){
                Console.WriteLine("============");
                Console.WriteLine("1) Start");
                Console.WriteLine("2) Help");
                Console.WriteLine("3) Exit");
                Console.WriteLine("============");

            }

            //call to actually display menu
            DisplayMenu();


            //Task 5 - Even or Odd Function
            Console.WriteLine();
            Console.WriteLine("Task 5 - Even or Odd Function");
            Console.WriteLine();

            //function to check even or odd
            bool IsEven(int n)
            {
                if (n %2 == 0) return true;
                return false;//else it will return false
            }

            //now we ask user for a number
            while (true)
            {
                try
                {
                    Console.Write("Enter a number(int):");
                    int number5 = Convert.ToInt32(Console.ReadLine());
                    bool check = IsEven(number5); // checks value
                    if (check) { Console.WriteLine("number is even "); }
                    else
                    {
                        Console.WriteLine("number is odd");
                    }


                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }




        }
    }
}

