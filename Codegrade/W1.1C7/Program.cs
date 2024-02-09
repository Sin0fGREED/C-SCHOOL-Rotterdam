using System;


class Length_Case{

    static void Main(){
        string Secret = "Length";

        Console.WriteLine("Guess the six-lettered word");
        
        string guess = Console.ReadLine();

        if (guess.Length == 6)
        {
            if (guess.Equals(Secret)){
                Console.WriteLine("Correct!");
            }
            else if (guess.ToLower() == Secret.ToLower())
            {
                Console.WriteLine("Kind of correct; the case was just wrong");
            }
            else 
            {
                Console.WriteLine("Incorrect!");
            }
        }
        else {
            Console.WriteLine("Incorrect! That is not even a six-letter word!");
        }
    }
}