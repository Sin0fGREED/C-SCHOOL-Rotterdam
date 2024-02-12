using System;
using System.Collections.Generic;
using System.Linq;

class List_and_indices
{
    static void Main()
    {
        var pack = new List<string> { "laptop", "lunch", "notebook", "pen" };

        Console.WriteLine($"The first item in the pack is a {pack.First()}");
        Console.WriteLine($"The last item in the pack is a {pack.Last()}");
    }
}
