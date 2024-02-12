using System;


class RandomNumbersPsuedo{

    static void Main(){

        Random rnd = new Random();

        for (int i = 0; i < 10; i++){
            int number = rnd.Next(1, 7);
            Console.WriteLine($"number\n");

        }

    }
}