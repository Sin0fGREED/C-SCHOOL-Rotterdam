using System;


class While_the_getting_bad{
    
    static void Main()
    {
        ﻿Console.WriteLine("What is the person's name?");
        string personName = Console.ReadLine();

        if (!string.IsNullOrEmpty(personName))
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i == 2 ? $"Happy birthday dear {personName}!" : "Happy birthday to you!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid name.");
        }
    }
}