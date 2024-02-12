using System;

class Clear_conditions{

    static void Main(){
        int age = Convert.ToInt32(Console.ReadLine());
        int age2 = Convert.ToInt32(Console.ReadLine());

        if (age == age2) {
            Console.WriteLine("Your ages are equal");
        }
        else if (age > age2){
            Console.WriteLine("You are older");
        }
        else if (age < age2){
            Console.WriteLine("You are younger");
        }
    }
}