using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTaskList
{
    public class Task
    {
        #region Fields

        private string teamMemberName;
        private string description;
        private string dueDate;
        private bool completed;
        #endregion

        public static List<Task> tasks = new List<Task>()
            {
                new Task("Johnny","Needs to clean bathroom","08/01/2018", false),
                new Task("Brandyn", "Needs to complete Rocket Futures", "07/27/2019", false),
                new Task("Joe", "Has to mow the lawn", "08/02/2019", false)
            };

        #region Properties
        public string TeamMemberName
        {
            get
            {
                return teamMemberName;
            }
            set
            {
                teamMemberName = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        #endregion

        #region Constructors
        public Task()
        {
            
        }
        public Task(string _teamMemberName, string _description, string _dueDate, bool _completed =false)
        {
            teamMemberName = _teamMemberName;
            description = _description;
            dueDate = _dueDate;
            completed = _completed;
        }
        #endregion

        #region Methods
         
        public static void DisplayTasks()
        {
            Console.WriteLine("1.  List Task");
            Console.WriteLine("2.  Add Task");
            Console.WriteLine("3.  Delete Task");
            Console.WriteLine("4.  Mark Task Complete");
            Console.WriteLine("5.  Quit");

        }
        public static void AddToList()
        {
            Task blah = new Task();

            Console.WriteLine("Please enter Name:");
            string userInput=Console.ReadLine();
            blah.teamMemberName=userInput;

            Console.WriteLine("Please enter Description of task:");
            string userInput2 = Console.ReadLine();
            blah.description = userInput2;

            Console.WriteLine("Enter in due date of task:");
            string userInput3=Console.ReadLine();
            blah.dueDate = userInput3;

            tasks.Add(blah);

        }

        public static void DeleteFromList()
        {

            Console.WriteLine("What would you like to delete");
            int num = 1;
            foreach(Task item in tasks)
            {
                Console.WriteLine(num);
                Console.WriteLine($"{item.TeamMemberName}");
                Console.WriteLine($"{item.Description}");
                Console.WriteLine($"{item.DueDate}");
                Console.WriteLine($"{item.Completed}");
                Console.WriteLine();
                num++;
            }
            
            int userInput = int.Parse(Console.ReadLine());
            userInput--;
            tasks.Remove(tasks[userInput]);
        }
        public static void MarkComplete()
        {
            Console.WriteLine("Which task would you like to mark complete: ");
            Console.WriteLine();
            int num = 1;
            foreach (Task line in tasks)
            {
                Console.WriteLine($"{num}. {line.Description}");
                num++;
            }
            int userInput = int.Parse(Console.ReadLine());
            userInput--;

            Console.WriteLine("Are you sure you want to change this?(y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                tasks[userInput].Completed = true;
            }
          
        }
        public static bool AreYouSure()
        {
            Console.WriteLine($"Are you sure you want to exit? Press {'y'} to continue or press any other key to exit.");
            string response = Console.ReadLine();
            if (response == "y")
            {
                return true;
            }
            else if (response != "y")
            {
                Console.WriteLine("Good-Bye");
                return false;
            }
            else
            {
                return AreYouSure();

            }
        }
        #endregion
    }

}
