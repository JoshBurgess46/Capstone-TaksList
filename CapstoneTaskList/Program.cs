using System;
using System.Collections.Generic;

namespace CapstoneTaskList
{
    class Program
    {
        static void Main(string[] args)
        {

            bool go = true;
            while (go)
            {

                Console.WriteLine("Pick which option your would like to see");

                Task.DisplayTasks();
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    foreach (Task stuff in Task.tasks)
                    {
                        Console.WriteLine(stuff.TeamMemberName);
                        Console.WriteLine();
                        Console.WriteLine(stuff.Description);
                        Console.WriteLine();
                        Console.WriteLine(stuff.DueDate);
                        Console.WriteLine();
                        Console.WriteLine(stuff.Completed);
                        Console.WriteLine();
                    }
                }
                else if (userInput == 2)
                {
                    Task.AddToList();
                }
                else if (userInput == 3)
                {
                    Task.DeleteFromList();
                }
                else if (userInput == 4)
                {
                    Task.MarkComplete();
                    
                }
                else if(userInput == 5)
                {
                    go = Task.AreYouSure();

                    
                    
                }
            }
        }
       

    }
}
