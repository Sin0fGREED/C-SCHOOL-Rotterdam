using System;



class Switch{
    // created a switch statement that ups the X and Y Values by each bidirectional step.

    static void Main()
    {
        int x = 0, y = 0;
        Console.WriteLine("which direction would you like to go?");

        string direction = Console.ReadLine().ToLower();

        switch(direction){
            
            case "up":
                y++;
                break;
            case "down":
                y--;
                break;
            case "left":
                x++;
                break;    
            case "right":
                x--;
                break;

            default:
                Console.WriteLine("Invalid direction");
                break;
        }
        Console.WriteLine($"Current position\nX:{x}, y:{y}");

        }

    }