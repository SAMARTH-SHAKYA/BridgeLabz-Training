using System;

public class SimpleInterest {
    static void Main() {
        
        int p = Convert.ToInt32(Console.ReadLine());
        int r = Convert.ToInt32(Console.ReadLine());
        int t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((p*r*t)/100);
    }
}
