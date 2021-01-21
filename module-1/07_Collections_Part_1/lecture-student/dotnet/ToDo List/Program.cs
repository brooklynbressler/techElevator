using System;
using System.Collections.Generic;

namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ToDo 2.0");
            Console.WriteLine("Please enter items and hit <Enter>");
            Console.WriteLine("Enter <q> to quit");
            //ask the user to enter some ToDo items

            bool running = true;
            List<string> toDoListItems = new List<string>();
            while (running)
            {
                string userResponse = "";
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "q")
                {
                    running = false;
                }
                else if (userResponse == "")
                {
                    Console.WriteLine("Invalid data, try again");
                } 
                else if (toDoListItems.Contains(userResponse.ToLower()))
                {
                    Console.WriteLine("To do list item already added, try again");
                }
                else
                {
                    toDoListItems.Add(userResponse.ToLower());
                }
                
            }
            int i = 1;

            Console.WriteLine($"You have {toDoListItems.Count} items on your list");
            foreach(string item in toDoListItems)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }

            Console.WriteLine("Enter a todo item to remove");
            string itemToRemove = Console.ReadLine();
            toDoListItems.Remove(itemToRemove);

            //ask the user to enter some ToDo items
            //loop and allow for them to add multiple files
            //don't allow duplicate items

            //display the items
            //allow to remove an item





        }
    }
}
