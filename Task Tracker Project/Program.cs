namespace Task_Tracker_Project
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskindex = 0;
        static void Main(string[] args)
        {
            // Welcome user
            // 1. Add task
            // 2. View all tasks
            // 3. Mark task complete
            // 4. Remove task
            // 5. Exit
            Console.Write("What is your name ? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name );
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
           
            Console.WriteLine("                                             Welcome to my task tracker                                              ");
          
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1 For Add a task. ");
            Console.WriteLine(" 2 For View all tasks.");
            Console.WriteLine(" 3 For Mark task complete.");
            Console.WriteLine(" 4 For Remove task.");
            Console.WriteLine(" 5 For Exit program.");
            
            while (true) 
            {
                Console.WriteLine() ;
                Console.Write("Please, Enter your choice from 1 to 5 : ");
                string userchoice = Console.ReadLine();

                switch (userchoice)
                {
                    case "1":
                        // Add task
                        AddTask();
                        break;
                    case "2":
                        // View all tasks
                        ViewTasks();
                        break;
                    case "3":
                        // Mark task complete
                        TaskComplete();
                        break;
                    case "4":
                        // Remove task
                        RemoveTask();
                        break;
                    case "5":
                        // Exit program
                        Environment.Exit(0);
                        
                        break;
                    default:
                        Console.WriteLine("Please enter number from 1 to 5 only ");
                        break;
                }
                

            }

           


        }

        private static void AddTask()
        {
            Console.Write("Enter task title to add : ");
            string tasktitle = Console.ReadLine();
            tasks[taskindex] = tasktitle;
            Console.WriteLine("The task has been added successfully.");
            taskindex++;
            
        }

        private static void ViewTasks()
        {
            Console.WriteLine("Task list : ");
            for (int i = 0; i < taskindex; i++)
            {
                Console.WriteLine($"{i + 1}.   Task title : {tasks[i]} ");
                  
            }
        }

        private static void TaskComplete()
        {
            Console.Write("Enter task number to mark complete : ");
            string tasknumber = Console.ReadLine();
            int taskid = Convert.ToInt32(tasknumber);
            tasks[taskid - 1] = tasks[taskid - 1] + "   -- COMPLETED --   ";
            Console.WriteLine("The task has been completed successfully.");
        }

        private static void RemoveTask()
        {
            Console.Write("Enter task number to delete : ");
            string Tasknumber = Console.ReadLine();
            int taskId = Convert.ToInt32(Tasknumber);
            tasks[taskId - 1] = "";
            Console.WriteLine("The task has been removed successfully.");
        }


    }
}
