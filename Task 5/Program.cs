namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            Console.WriteLine();
            Console.WriteLine("Task 1 - Fixed Grades Array");
            Console.WriteLine();
            //set an array
            int[] grades = new int[5];
            //read from user
            while (true)
            {
                try
                {
                    for (int i = 0; i < grades.Length; i++)
                    {
                        Console.Write("Enter your grades:");
                        grades[i] =int.Parse(Console.ReadLine());
                    }
                    //after we print 
                    Console.WriteLine("Your grades are:");
                    foreach (int x in grades)
                    {
                        Console.WriteLine(x);
                    }
                    //leave loop
                    break;
                }
                catch (Exception e) {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
            //Task 2 - Dynamic To-Do List

            Console.WriteLine();
            Console.WriteLine("Task 2 - Dynamic To-Do List");
            Console.WriteLine();
            //create list
            List<string> toDoList = new List<string>();
            string task = "";
            //read from user
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 5 tasks:");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Enter your " + (i+1)+" task:");
                        task = Console.ReadLine();
                        //add task to list
                        toDoList.Add(task);



                    }
                    //after we print 
                    Console.WriteLine("Your tasks are:");
                    int counter = 1;
                    foreach (string x in toDoList)
                    {
                        Console.WriteLine(counter +") "+ x);
                        counter++;
                    }
                    //leave loop
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }

        }
    }
}
