using System;

class While
{

    static void Main()
    {
        int money = 4;

        while (money > 0){
            Console.WriteLine($"Money left: {money}");
            Console.WriteLine("Look around (1) or go in a ride (2)?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1){
                Console.WriteLine("Yay!");
            }
            else if (userInput == 2){
                Console.WriteLine("Wheee!");
                money--;
            }
            if (money == 0){
                Console.WriteLine("Time to go home");
            }      
        }
    }
}