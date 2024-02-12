using System;


class For{

    static void Main(){
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine("Enter your PIN");
            Console.WriteLine($"{i} attempts left");

            if (Console.ReadLine() == "1234")
            {
                Console.WriteLine("Correct!");
                break;
            }

            if (i == 1)
                Console.WriteLine("Your pass is confiscated.");
        }

    }
}