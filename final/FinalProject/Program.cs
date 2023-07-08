using System;

class Program
{
    static void Main(string[] args)
    {  
     
        Game _game = new Game{};
        _game.DiplayWelCome();
        _game.DisplayLoad();
         _game.DisplayMenu();
         string option = Console.ReadLine();
         while(option != "3")
        { 
            switch(option) 
            {
                case "1":
                    _game.Start();
                    break;
                case "2":
                    //newGame.ListGoals();
                    break;
                case "3":
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
