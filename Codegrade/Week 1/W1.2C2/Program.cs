using System;

class Program
{
    static void Main()
    {
        string userInput;

        do
        {
            Console.WriteLine("Really delete this file? (y/n)");
            userInput = Console.ReadLine()?.Trim().ToLower();

        } while (userInput != "y" && userInput != "n");

        Console.WriteLine(userInput == "y" ? "File deleted" : "Deletion canceled");
    }
}
