using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter_grade = "";
        if (grade >= 90 )
        {
            letter_grade = "A";
        }
        else if (grade >= 80 )
        {
            letter_grade = "B";
        }
        else if (grade >= 70 )
        {
            letter_grade = "C";
        }
        else if (grade >= 60 )
        {
            letter_grade = "D";
        }
        else if (grade <  60 )
        {
            letter_grade = "E";;
        };
        Console.WriteLine($"Your grade is {letter_grade}!");
        if (grade < 70 ){
            Console.WriteLine("You are repproved, please try again");
        }
    }
}