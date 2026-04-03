using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define two sets
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        // Compute Union
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        // Compute Intersection
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);

        // Display results
        Console.WriteLine("Union: " + string.Join(", ", union));
        Console.WriteLine("Intersection: " + string.Join(", ", intersection));
    }
}
