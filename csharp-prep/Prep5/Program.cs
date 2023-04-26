using System;

class Program
{
    

    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
             Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
         {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
         }
        static int PromptUserNumber()
         {
            Console.WriteLine("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int numberInt = int.Parse(number);
            return numberInt;
         }
        static int SquareNumber(int number)
        {
            int sum = number * number;
            return sum;
        }

        Console.WriteLine("Hello Prep5 World!\n");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        Console.WriteLine($"{userName}, the quare of your number is {squaredNumber}");

    
    }
}