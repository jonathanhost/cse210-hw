using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string option = "0";
        Journal _journal = new Journal();
        while (option != "6") 
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Clear Journal \n6. Quit\nWhat would you like to do? ");
        option = Console.ReadLine();
        
        
            if (option == "1")
            {
                PromptGenerator _prompt = new PromptGenerator();
                Entry _entry = new Entry();
                _entry._question = _prompt.Display();
                Console.WriteLine(_entry._question);
                _entry._answer = Console.ReadLine();
                Console.WriteLine(_entry._answer);
                DateTime theCurrentTime = DateTime.Now;
                _entry._dateText = theCurrentTime.ToShortDateString();
                 Console.WriteLine( _entry._dateText);
                _journal._entries.Add(_entry);
            } 
            else if (option == "2"){
                _journal.DisplayAllEntries();
            }
            else if (option == "3"){
               Console.WriteLine("What is the filename?");
                string filename_load = Console.ReadLine();
                _journal.LoadToFile(filename_load);
            }
            else if (option == "4"){
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                _journal.SaveToFile(filename);
            }
             else if (option == "5"){
                Console.WriteLine("Are you sure? yes/no");
                string removing = Console.ReadLine();
                if(removing.ToLower() == "yes"){
                _journal._entries.Clear();
                }
                
            }

             else if (option == "6"){
                Console.WriteLine("Bye Bye");
            }
            else{
                Console.WriteLine("Please try again!");
            }
        
    }
    }
}


