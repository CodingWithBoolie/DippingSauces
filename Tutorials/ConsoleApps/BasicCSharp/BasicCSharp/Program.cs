using System;

class Program
{
    static void Main()
    {
        int score = 100; // Declare a variable
        Console.WriteLine("Player's score is: " + score);

        Console.WriteLine("What's your name?");
        string firstName = Console.ReadLine() ?? "there";
        Console.WriteLine("Hi, " + firstName + "! Welcome to C# programming!!");
    }
}
