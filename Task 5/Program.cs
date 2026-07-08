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
                        if (grades[i] <= 0)// checks it once at least
                        {
                            Console.WriteLine("the grade value is invalid.Enter it again.");
                            Console.Write("Enter your grade again:");
                            grades[i] = int.Parse(Console.ReadLine());
                        }
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
            //Task 3 - Browsing History Stack

            Console.WriteLine();
            Console.WriteLine("Task 3 - Browsing History Stack");
            Console.WriteLine();
            //create stack
            Stack<string> history = new Stack<string>();
            string page = "";
            //read from user
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 3 webstie URL:");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Enter your " + (i + 1) + " website URL:");
                        page = Console.ReadLine();
                        //add URL to stack
                        history.Push(page);



                    }
                    //after we print 
                    Console.WriteLine("Your previous tab is: "+history.Pop());
                    
                  
                    //leave loop
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
            //Task 4 - Customer Service Queue

            Console.WriteLine();
            Console.WriteLine("Task 4 - Customer Service Queue");
            Console.WriteLine();
            //create Queue
            Queue<string> customers = new Queue<string>();
            string customer = "";
            //read from user
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 3 Customer names:");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Enter your " + (i + 1) + "  Customer name:");
                        customer = Console.ReadLine();
                        //add customer to queue
                        customers.Enqueue(customer);





                    }
                    //after we print 
                    Console.WriteLine(" The first customer to be served is: " + customers.Dequeue());


                    //leave loop
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }

            //Task 5 - Array Grade Range

            Console.WriteLine();
            Console.WriteLine("Task 5 - Array Grade Range");
            Console.WriteLine();
            //set an array
            int[] grades5 = new int[5];
            //read from user
            while (true)
            {
                try
                {
                    for (int i = 0; i < grades5.Length; i++)
                    {
                        Console.Write("Enter your grades:");
                        grades5[i] = int.Parse(Console.ReadLine());
                        if (grades5[i] <= 0)// checks it once at least
                        {
                            Console.WriteLine("the grade value is invalid.Enter it again.");
                            Console.Write("Enter your grade again:");
                            grades5[i] = int.Parse(Console.ReadLine());
                        }
                    }
                    //sort array
                    grades5.Sort();
                    ///get average grade
                    int total =  0;
                    for (int i = 0; i < grades5.Length; i++)
                    {

                        total += grades5[i];
                    }
                    double average = total / 5;//get average
                    //print all
                    Console.WriteLine("The highest grade :" + grades5[4]);
                    Console.WriteLine("The lowest grade :" + grades5[0]);
                    Console.WriteLine("The average of all grades :" + average);


                    //leave loop
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }

            //Task 6 - Filtered Shopping List

            Console.WriteLine();
            Console.WriteLine("Task 6 - Filtered Shopping List");
            Console.WriteLine();
            //create shopping list
            List<string> shoppingList = new List<string>();
            //ask user until they  type done
            //print menu 
            Console.WriteLine("------------------");
            Console.WriteLine("Add the items to shopping list, when done type 'done'");
            Console.WriteLine("------------------");
            int count = 1;
            string item = "";
            while (true)
            {
                try
                {
                    Console.Write("Your " + count + " item :");
                    item =Console.ReadLine().ToLower();
                    if (item == "done")
                    {
                        //leave loop
                        break;
                    }
                    else
                    {
                        shoppingList.Add(item);
                    }


     
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
            //ask for an item to remove 
            while (true)
            {
                try
                {
                    Console.Write("Give me an item to remove");
                    string remove = Console.ReadLine().ToLower();
                    //print before and after
                    Console.WriteLine("Shopping List before");
                    foreach (string d in shoppingList) {

                        Console.WriteLine(d);//prints elements
                    
                    }
                    shoppingList.Remove(remove);
                    Console.WriteLine("Shopping List after");
                    foreach (string d in shoppingList)
                    {

                        Console.WriteLine(d);//prints elements

                    }
                    //leave loop
                    break;




                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
            //Task 7 - High Score Podium

            Console.WriteLine();
            Console.WriteLine("Task 7 - High Score Podium");
            Console.WriteLine();
            //make list for scores
            List<int> scores = new List<int>();
            int score = 0;
            //read from user
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 5 game scores:");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Enter your " + (i + 1) + " score:");
                         score =int.Parse( Console.ReadLine());
                        //add score to list
                        scores.Add(score);



                    }
                    //after we sort 
                    scores.Sort();
                    scores.Reverse();
                    //print top 3
                    Console.WriteLine("1st place: " + scores[0]);
                    Console.WriteLine("2nd place: " + scores[1]);
                    Console.WriteLine("3rd place: " + scores[2]);

                    //leave loop
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }

            //Task 8 - Undo Last Action

            Console.WriteLine();
            Console.WriteLine("Task 8 - Undo Last Action");
            Console.WriteLine();

            //create stack
            Stack<string> actions = new Stack<string>();
            //ask user until they  type done
            //print menu 
            Console.WriteLine("------------------");
            Console.WriteLine("Add the actions to track them in editor, when done type 'stop'");
            Console.WriteLine("------------------");
            int counts = 1;
            string action = "";
            while (true)
            {
                try
                {
                    Console.Write("Your " + counts + " action :");
                    action = Console.ReadLine().ToLower();
                    if (action == "stop")
                    {
                        //leave loop
                        break;
                    }
                    else
                    {
                        actions.Push(action);
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
            //pressing "undo" twice
            Console.WriteLine("1st undo :"+ actions.Pop());
            Console.WriteLine("2nd undo :"+ actions.Pop());
            //printing rest 
            Console.WriteLine("what's left in stack :");
            foreach (string c in actions)
            {
                Console.WriteLine(c);
            }


            //Task 9 - Grade Analyzer with Functions


            Console.WriteLine();
            Console.WriteLine("Task 9 - Grade Analyzer with Functions\r\n");
            Console.WriteLine();

            //two functions
            double CalculateAverage(List<int> n)
            {
                int total = 0;
                foreach(int i in n)
                {
                    total += i;
                }
                return total /n.Count;
            }

            int FindFirstFailing(List<int> n)
            {
                foreach (int i in n)
                {
                    if (i < 60)
                    {
                        return i;
                    }
                }
                return 0; // in case no value in list less than 60
            }
            //now we ask user
            int amount = 0;
            int grade9 = 0;

            //make list for grade scores
            List<int> grades9 = new List<int>();
            while (true)
            {
                try
                {
                    Console.Write("How many grades you want to enter:");
                    amount = int.Parse(Console.ReadLine());
                    if (amount >0)//ask again if amount is less than 0
                    {
                        //loop for all the grades
                        for (int i = 0; i < amount; i++)
                        {
                            Console.Write("Enter your " + (i + 1) + " grade:");
                            grade9 = int.Parse(Console.ReadLine());
                            //add score to list
                            grades9.Add(grade9);



                        }

                        //leave loop
                        break;
                    }
                    


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
            //here we will print results 
            int lowGrade = FindFirstFailing(grades9);
            if(lowGrade == 0)
            {
                Console.WriteLine("There is no failing grade.");
            }
            else
            {
                Console.WriteLine("The first failing grade is :" + lowGrade);
            }
            double finalAvg = CalculateAverage(grades9);
            Console.WriteLine("The average is :" + finalAvg);

            //Task 10 - Print Queue Manager


            Console.WriteLine();
            Console.WriteLine("Task 10 - Print Queue Manager");
            Console.WriteLine();
            //make function to remove the job

            Queue<string> RemoveJob (Queue<string> n, string job)
            {
                //this is the new  Queue<string>
                Queue<string> newList = new Queue<string>();
                string item = "";
                for (int i = 0; i < n.Count; i++) {
                    item = n.Dequeue().ToLower();
                    if (item != job.ToLower()) {
                        newList.Enqueue(item); }
                    //else we wont add
                
                    
                
                }
                return newList;

            }
            //now we set our QUEUE   
            Queue<string> jobManagerOld = new Queue<string>();
            //read from user

            Console.WriteLine("------------------");
            Console.WriteLine("Add the jobs to track them in Manager, when done type 'done'");
            Console.WriteLine("------------------");
            int counts10 = 1;
            string job = "";
            string jobCancel = "";
            while (true)
            {
                try
                {
                    Console.Write("Your " + counts10 + " job :");
                    job = Console.ReadLine().ToLower();
                    if (job == "done")
                    {
                        //leave loop
                        break;
                    }
                    else
                    {
                        jobManagerOld.Enqueue(job);
                    }
                    while (true)
                    {
                        //ask for job to cancel
                        Console.Write("Enter the job you want to cancel :");
                        jobCancel = Console.ReadLine().ToLower();
                        //leave loop
                        break;


                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error invalid input.Try again.");


                }
                //now we print
                Queue<string> jobManagerNew = RemoveJob(jobManagerOld, jobCancel);
                Console.WriteLine("List of jobs before:");
                foreach (string x in jobManagerOld)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("List of jobs after cancellation:");
                foreach (string x in jobManagerNew)
                {
                    Console.WriteLine(x);
                }
            }





        }
    }
}
