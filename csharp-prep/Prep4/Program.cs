using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello Prep4 World!\n");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.\n");
        int number = 1;
        int soma = 0;
        while (number != 0)
        {   
            Console.WriteLine("Enter a number (0 to quit): ");
            string number1 = Console.ReadLine();
            number = int.Parse(number1);
            if (number != 0){
                soma += number;
                numbers.Add(number);
            }
            
        }
        int smallpositive = 99;
        foreach (int numero in numbers)
        {
            if (numero < smallpositive && numero > 0)
            {
                // if this number is greater than the max, we have found the new max!
                smallpositive = numero;
            }
        }
        float average = ((float)soma) / numbers.Count;
        int lagerst = numbers.Max();
        Console.WriteLine("The sum is:" + soma);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is:" + lagerst);
        Console.WriteLine("The smallest positive number is: " + smallpositive);
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int numero in numbers)
        {
           Console.WriteLine(numero);
        }

    }
    
}