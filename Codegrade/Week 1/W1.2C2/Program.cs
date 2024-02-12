using System;
using System.Collections.Generic;

class While_fair
{
    static void Main()
    {
        var fileList = new List<string> { "OODP assignment.docx", "Project Presentation.pptx", "TODO list.xlsx" };
        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);

        string confirm;
        do
        {
            Console.WriteLine("Really delete this file? (y/n)");
            confirm = Console.ReadLine()?.Trim().ToLower();
        } while (confirm != "y" && confirm != "n");

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
        else
        {
            Console.WriteLine("Deletion canceled");
        }
    }
}
