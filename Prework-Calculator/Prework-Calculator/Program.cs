using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Calculator.");
            Console.WriteLine("Please choose from one of the following choices.");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            string choice = Console.ReadLine();
            Console.WriteLine("You will now enter the first number");

            int firstValue = int.Parse(Console.ReadLine());

            if (choice == "5")
            {
                return false;
            } else if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                SecondValueMessage(choice, firstValue);
            } else
            {
                return true;
            }


            int secondValue = int.Parse(Console.ReadLine());

            if (choice == "1")
            {
                Add(firstValue, secondValue);
                return true;
            }
            else if (choice == "2")
            {
                Subtract(firstValue, secondValue);
                return true;
            }
            else if (choice == "3")
            {
                Multiply(firstValue, secondValue);
                return true;
            }
            else if (choice == "4")
            {
                Divide(firstValue, secondValue);
                return true;
            }

        }
        private static void SecondValueMessage(string choice, int firstValue)
        {

            if (choice == "1")
            {
                Console.WriteLine("Please enter the number you wish to add to {0}.", firstValue);
                
            }
            else if (choice == "2")
            {
                Console.WriteLine("Please enter the number you wish to subtract from {0}.", firstValue);
                
            }
            else if (choice == "3")
            {
                Console.WriteLine("Please enter the number you wish to multiply {0} by.", firstValue);
                
            }
            else if (choice == "4")
            {
                Console.WriteLine("Please enter the number you wish to divide {0} by.", firstValue);
                
            }
    
        }
        private static void Add(int firstValue, int secondValue)
        {

        }
        private static void Subtract(int firstValue, int secondValue)
        {

        }
        private static void Multiply(int firstValue, int secondValue)
        {

        }
        private static void Divide(int firstValue, int secondValue)
        {

        }
    }
}
