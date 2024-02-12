using System;


class Switch_expression{

    static void Main(){

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            string ageCategory = DetermineAge(age);
            Console.WriteLine($"Age {age}: {ageCategory}");
        }
        else 
        {
            Console.WriteLine("Invalid input. Please enter a valid integer age");
        }
    }
    static string DetermineAge(int age)
    {
        return age switch
        {
            >= 0 and <= 12 => "a child",
            >= 13 and <= 19 => "a teenager",
            >= 20 and <= 150 => "an adult",
            _=> "invalid",
        };

    }
}