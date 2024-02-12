using System;
using System.Collections.Generic;

class While_the_getting_bad
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);
        string confirm = "n";
        do
        {
            Console.WriteLine("Really delete this file? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                confirm = "y";
            }
            else if (answer == "n")
            {
                break;
            }
        } while (confirm != "y");

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}
