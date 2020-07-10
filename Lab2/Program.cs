using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool userContinue;

            Console.WriteLine("Welcome to Justin's Room Detail Generator!");

            do
            {

                double length;
                double height;
                double width;

                //Length
                Console.WriteLine("\nEnter Length: ");
                string userLength = Console.ReadLine();
                while (!double.TryParse(userLength, out length) || length <= 0) 
                {
                    Console.WriteLine("\nIncorrect Value. Please try again.");
                    Console.WriteLine("Enter Length:");
                    userLength = Console.ReadLine();
                }

                //Width
                Console.WriteLine("\nEnter Width: ");
                string userWidth = Console.ReadLine();
                while (!double.TryParse(userWidth, out width) || width <= 0)
                {
                    Console.WriteLine("\nIncorrect Value. Please try again.");
                    Console.WriteLine("Enter Width:");
                    userWidth = Console.ReadLine();
                }

                //Height
                Console.WriteLine("\nEnter Height: ");
                string userHeight = Console.ReadLine();
                while (!double.TryParse(userHeight, out height) || height <= 0)
                {
                    Console.WriteLine("\nIncorrect Value. Please try again.");
                    Console.WriteLine("Enter Height:");
                    userHeight = Console.ReadLine();
                }

                //Calculations
                double area = Math.Round((length * width), 2);
                double perimiter = Math.Round((2 * (length + width)), 2);
                double volume = Math.Round((length * width * height), 2);


                //Output
                Console.WriteLine($"\nArea: {area}");
                Console.WriteLine($"Perimiter: {perimiter}");
                Console.WriteLine($"Volume: {volume}");


                //Run again prompt
                Console.WriteLine("\nWould you like to run again? (y/n)");
                string continuePrompt = Console.ReadLine().ToLower();
                while(continuePrompt != "y" && continuePrompt != "n")
                {
                    Console.WriteLine("\nIncorrect entry. Please try again");
                    Console.WriteLine("Would you like to run again? (y/n)");
                    continuePrompt = Console.ReadLine().ToLower();
                }

                userContinue = (continuePrompt == "y") ? true : false;


            } while (userContinue);
        }
    }
}
