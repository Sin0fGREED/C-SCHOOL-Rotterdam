using System;

class Water_state_Watching{

    static void Main(){
        double Celsius = Convert.ToDouble(Console.ReadLine());

        if (Celsius == 0){
            Console.WriteLine($"At {Celsius} degrees Celsius, the water will be solid");

        }
        if (Celsius >=0 && Celsius <=99.99){
            Console.WriteLine($"At {Celsius} degrees Celsius, the water will be liquid");   
       
        }
        if (Celsius >=100){
            Console.WriteLine($"At {Celsius} degrees Celsius, the water will be gas");
        
        }


    }
}