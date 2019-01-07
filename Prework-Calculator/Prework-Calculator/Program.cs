using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args) //set-up MainMenu
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu() //section for main interaction
        {
            Console.Clear();
            //main menu
            Console.WriteLine("Welcome to the Calculator.");
            Console.WriteLine("Please choose from one of the following choices.");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            string choice = Console.ReadLine();
            
            //executes the different choices

            if (choice == "5") // If 5 exits program
            {
                return false;
            } else if (choice == "1" || choice == "2" || choice == "3" || choice == "4") // calculator choices
            {
                Console.WriteLine("You will now enter the first number");
                int firstValue = int.Parse(Console.ReadLine());

                SecondValueMessage(choice, firstValue);

                int secondValue = int.Parse(Console.ReadLine());

                //activates individual calculator functions
                if (choice == "1")
                {
                    Add(firstValue, secondValue);
                    
                }
                else if (choice == "2")
                {
                    Subtract(firstValue, secondValue);
                    
                }
                else if (choice == "3")
                {
                    Multiply(firstValue, secondValue);
                    
                }
                else if (choice == "4")
                {
                    Divide(firstValue, secondValue);
                    
                }
                return true;

            } else
            {
                return true;
            }



        }
        private static void SecondValueMessage(string choice, int firstValue) // handles message for SecondValueMessage depending on which calculator method is being used
        {

            if (choice == "1") //message for addition
            {
                Console.WriteLine("Please enter the number you wish to add to {0}.", firstValue);
                
            }
            else if (choice == "2") //message for subtraction
            {
                Console.WriteLine("Please enter the number you wish to subtract from {0}.", firstValue);
                
            }
            else if (choice == "3") //message for multiplication
            {
                Console.WriteLine("Please enter the number you wish to multiply {0} by.", firstValue);
                
            }
            else if (choice == "4") //message for division
            {
                Console.WriteLine("Please enter the number you wish to divide {0} by.", firstValue);
                
            }
    
        }
        private static void Add(int firstValue, int secondValue) //final function for addition
        {
            int sumOf = firstValue + secondValue;
            Console.WriteLine("{0} plus {1} equals {2}", firstValue, secondValue, sumOf);
            Console.ReadLine();
        }
        private static void Subtract(int firstValue, int secondValue) //final function for subtraction
        {
            int difOf = firstValue - secondValue;
            Console.WriteLine("{0} minus {1} equals {2}", firstValue, secondValue, difOf);
            Console.ReadLine();
        }
        private static void Multiply(int firstValue, int secondValue) //final function for multiplication
        {
            int times = firstValue * secondValue;
            Console.WriteLine("{0} times {1} equals {2}", firstValue, secondValue, times);
            Console.ReadLine();
        }
        private static void Divide(int firstValue, int secondValue) //final function for division
        {
            int divisor = firstValue / secondValue;
            int remainder = firstValue % secondValue;

            if (remainder == 0) //if the second divides the first evenly
            {
                Console.WriteLine("{0} divided by {1} equals {2}", firstValue, secondValue, divisor);
            } else //if there is a remainder
            {
                Console.WriteLine("{0} divided by {1} equals {2} with a reamainder of {3}", firstValue, secondValue, divisor, remainder);
            }
            Console.ReadLine();
        }
    }
}
