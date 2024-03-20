using System.Xml.Serialization;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                //print menu;
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                Console.WriteLine();

                //ask user for choice
                Console.WriteLine("enter number of choice from menu (1,2,3,4)");
                choice = int.Parse(Console.ReadLine());
                //console writeline(choice)

                //print message using if statements
                if (choice == 1)
                {
                    Console.WriteLine("loading new game...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("loading game...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("options available:");
                }
                else if (choice > 4 || choice < 0)
                {
                    Console.WriteLine("please enter 1,2,3,4");
                }

            }
        }
    }
}