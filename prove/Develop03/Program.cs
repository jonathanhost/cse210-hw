using System;

class Program
{
    static void Main(string[] args)
    {  
        //Scripture reference and content
        Loadscripture newScripture = new Loadscripture();
        newScripture.LoadToFile();
        string type = " ";
        Scripture scripture = newScripture.getScripture();
        Reference reference = scripture.getReference();
        while (type != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{reference.getReference()} {scripture.getRenderedText()}\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:\n");
            type = Console.ReadLine();
            Console.Clear();
            scripture.hideWords();

            if(scripture.isCompletelyHidden())
            {
                type = "quit";
            }
        }
    }
}