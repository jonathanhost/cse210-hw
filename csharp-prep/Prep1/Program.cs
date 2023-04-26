using System;

class Program
{
    static void Main(string[] args)
    {  
        bool isEqual = false;
        Console.WriteLine("What is the magic number?");
        string number1 = Console.ReadLine();
        int magicNumber = int.Parse(number1);
        while (isEqual == false)
        {   
            Console.WriteLine("What is your guess?");
            string number2 = Console.ReadLine();
            int guessNumber = int.Parse(number2);
        
            if(magicNumber < guessNumber){
                Console.WriteLine("Less");
            }
            else if(magicNumber > guessNumber){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
                isEqual = true;
            
        }
    }
        
        


    }   
}