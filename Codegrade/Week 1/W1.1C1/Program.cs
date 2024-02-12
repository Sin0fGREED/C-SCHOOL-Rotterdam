using System;

class Hello_User
{
    static void Main(){
        string Lname;
        char Fname;


        Console.WriteLine("Hello. Please enter your last name.");
        Lname = Console.ReadLine();

        Console.WriteLine("What is the initial of your first name?");
        Fname = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($"Welcome to the course, {Fname} {Lname}. We will watch your career with great interest.");

    }

}