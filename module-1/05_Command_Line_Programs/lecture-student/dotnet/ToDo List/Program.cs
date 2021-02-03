using System;

namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Do List!");
            Console.WriteLine("Enter some things you would like to do");
            Console.WriteLine("Enter 'done' when done");

            //ask the user to enter a single item
            //keep asking until they type 'n'
            //display the list 1,2,3 etc
            bool running = true;
            while (running)
            {


                string userTyped;
                userTyped = Console.ReadLine();

                if (userTyped == "done")
                {
                    running = false;
                }



            }
        }
    }
}
