using System;

class Program
{
    static void Main(string[] args)
    {
        Game newGame = new Game();

        while(newGame.GetChoice() != "quit")
        { 
            newGame.DisplayPoints();
            newGame.DisplayMenu();
            switch(newGame.GetChoice()) 
            {
                case "1":
                    newGame.DisplayCreateGoal();
                    break;
                case "2":
                    newGame.ListGoals();
                    break;
                case "3":
                    newGame.SaveGoals();
                    break;
                case "4":
                    newGame.LoadGoals();
                break;
                case "5":
                    newGame.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Bye Bye");
                    System.Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    } 
}