using System;

class Celsiusnr1_Fahrenheitnr3{


    static void Main(){
        int Celsius = Convert.ToInt32(Console.ReadLine());
        double fahrenheit = Celsius*1.8+32;

        Console.WriteLine($"{Celsius} C = {fahrenheit} F ");
        Console.WriteLine($"Truncated that is {(int)fahrenheit} F");

    }
}